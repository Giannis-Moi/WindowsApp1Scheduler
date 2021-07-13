using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

using UniversityApp.Implementation;

namespace UniversityApp.WUI {

    public partial class ScheduleForm : Form {

        public University university = new University();
        public Storage newStorage = new Storage();
        public BindingList<Schedule> scheduleList = new BindingList<Schedule>();

        public ScheduleForm() {
            InitializeComponent();

            ctrl_Date.MinDate = DateTime.Now;   

        }

        #region Display and Create

        public void DisplayData() {

            foreach (Student student in university.Students) {
                List_Students.Items.Add(student.GetFullName());
            }

            foreach (Course course in university.Courses) {

                List_Subjects.Items.Add(string.Format("{0}", course.Subject));
            }

            foreach (Professor professor in university.Professors) {
                List_Professors.Items.Add(professor.GetFullName());
            }

            PopulateSchedules();

        }

        public void PopulateSchedules() {

            gridViewSchedule.AutoGenerateColumns = false;
            scheduleList = new BindingList<Schedule>(university.Schedules); //Bind scheduleList with my university.Schedules
            var source = new BindingSource(scheduleList, null); //Sets data source of my grindview
            gridViewSchedule.DataSource = source;

        }

        public Schedule CreateSchedule() {
            var selectedCourse = List_Subjects.SelectedItem.ToString();
            var selectedStudent = List_Students.SelectedItem.ToString();
            var selectedprofessor = List_Professors.SelectedItem.ToString();
            var selectedDate = ctrl_Date.Value.Date.Add(dateTimePicker1.Value.TimeOfDay);
            var selectedHours = dateTimePicker2.Value.TimeOfDay - dateTimePicker1.Value.TimeOfDay;


            var schedule = new Schedule {
                Course = selectedCourse,
                Student = selectedStudent,
                Professor = selectedprofessor,
                Calendar = selectedDate,
                Duration = selectedHours.TotalHours
            };


            return schedule;


        }
        public void AddSchedule(Schedule schedule) {

            scheduleList.Add(schedule);
        }


        public void DisplayStudentCategoryEnum(string studentName) {

            var categories = FindAppliedCategories(studentName);
            lbl_StudentCategory.Text = string.Join(" | ", categories);

        }

        public void DisplayProfessorCategoryEnum(string professorName) {

            var categories = FindAssignedCategories(professorName);
            lbl_ProfessorCategory.Text = string.Join(" | ", categories);


        }

        public void DisplaySubjectCategory(string courseName) {
            var categories = FindSubjectCategory(courseName);
            lbl_SubjectCategory.Text = categories.ToString();
        }



        #endregion

        #region Events
        private void List_Subjects_SelectedValueChanged(object sender, EventArgs e) {
            ctrl_Selectedsubject.Text = List_Subjects.SelectedItem.ToString();
            DisplaySubjectCategory(ctrl_Selectedsubject.Text);


        }

        private void List_Students_SelectedValueChanged(object sender, EventArgs e) {
            ctrl_SelectedStudent.Text = List_Students.SelectedItem.ToString();
            DisplayStudentCategoryEnum(ctrl_SelectedStudent.Text);
        }

        private void List_Professors_SelectedValueChanged(object sender, EventArgs e) {
            ctrl_SelectedProfessor.Text = List_Professors.SelectedItem.ToString();
            DisplayProfessorCategoryEnum(ctrl_SelectedProfessor.Text);
        }

        private void Ctrl_Date_ValueChanged(object sender, EventArgs e) {
            ctrl_SelectedDate.Text = ctrl_Date.Text;
        }


        private void ScheduleForm_Load(object sender, EventArgs e) {

            university = newStorage.Load();

            DisplayData();

        }


        private void Btn_Save_Click(object sender, EventArgs e) {
            newStorage.Save(university);
        }

        private void Btn_Add_Click(object sender, EventArgs e) {

            try {

                if (ValidateEmptySelections() == false) {
                    return;
                }

                var schedule = CreateSchedule();
                if (ValidateStudentSchedule(schedule) == false
                    || ValidateProfessorSchedule(schedule) == false
                    || ValidateStudentCourses(schedule) == false
                    || ValidateProfessorCourses(schedule) == false
                    || TimeCheck() == false
                    || CheckCoursesOftheweek(schedule) == false) {
                    return;
                }

                AddSchedule(schedule);

            }
            catch (Exception ex) {
                MessageBox.Show("Creation failed :" + ex.Message);

            }

        }

        private void Ctrl_Remove_Click(object sender, EventArgs e) {

            if (gridViewSchedule.CurrentCell != null) {
                var selectedIndex = gridViewSchedule.CurrentCell.RowIndex;
                gridViewSchedule.Rows.RemoveAt(selectedIndex);
            }
            else {
                MessageBox.Show("Schedule table is empty!");
            }
        }


        #endregion

        #region Helper Methods

        public CoursesCategoryEnum FindCourseCategory(Schedule newSchedule) {

            foreach (Course course in university.Courses) {

                if (course.Subject == newSchedule.Course) {
                    return course.Category;
                }

            }
            MessageBox.Show("Category not found!");
            return CoursesCategoryEnum.None;

        }

        public List<CoursesCategoryEnum> FindAppliedCategories(string studentName) {

            foreach (Student student in university.Students) {

                if (student.GetFullName() == studentName) {

                    return student.AppliedCategories;
                }

            }
            return null;

        }

        public List<CoursesCategoryEnum> FindAssignedCategories(string professorName) {

            foreach (Professor professor in university.Professors) {

                if (professor.GetFullName() == professorName) {

                    return professor.AssignedCourses;
                }

            }
            return null;

        }

        public CoursesCategoryEnum FindSubjectCategory(string courseName) {

            foreach (Course course in university.Courses) {

                if (course.Subject == courseName) {

                    return course.Category;
                }

            }
            return CoursesCategoryEnum.None;
        }

        public int GetWeek(Schedule schedule) {
            // Taken from https://docs.microsoft.com/en-us/dotnet/api/system.globalization.calendar.getweekofyear?view=net-5.0

            CultureInfo culteInfo = new CultureInfo("el");
            Calendar calendar = culteInfo.Calendar;
            CalendarWeekRule calendarWeekRule = culteInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek dayOfWeek = culteInfo.DateTimeFormat.FirstDayOfWeek;

            var weekOfTheYear = calendar.GetWeekOfYear(schedule.Calendar, calendarWeekRule, dayOfWeek);

            return weekOfTheYear;

        }


        #endregion

        #region Validation checks

        public bool ValidateEmptySelections() {
            if (List_Students.SelectedItem == null) {
                MessageBox.Show("Please select Student!");
                return false;

            }
            if (List_Professors.SelectedItem == null) {
                MessageBox.Show("Please select Professor!");
                return false;
            }
            if (List_Subjects.SelectedItem == null) {
                MessageBox.Show("Please select Subject!");
                return false;
            }
            if (string.IsNullOrEmpty(ctrl_SelectedDate.Text)) {
                MessageBox.Show("Please select Date!");
                return false;
            }

            return true;

        }
        public bool ValidateProfessorSchedule(Schedule newSchedule) {
            int count = 1;
            foreach (Schedule schedule in university.Schedules) {

                if (schedule.Professor == newSchedule.Professor && schedule.Calendar.Day == newSchedule.Calendar.Day

                    ) {

                    if (schedule.Student == newSchedule.Student && schedule.Course == newSchedule.Course) {
                        if (schedule.Calendar.Hour == newSchedule.Calendar.Hour)
                            MessageBox.Show("Professor is assigned to a course");
                        return false;
                    }
                }


                count++;
                if (count > 4 && schedule.Calendar.Day == newSchedule.Calendar.Day) {

                    MessageBox.Show("Professor can not have more than 4 courses per day");
                    return false;
                }



            }

            return true;

        }

        public bool ValidateProfessorCourses(Schedule newSchedule) {

            var courseCategory = FindCourseCategory(newSchedule);
            var professorCategories = FindAssignedCategories(newSchedule.Professor);

            if (professorCategories == null
                || courseCategory == CoursesCategoryEnum.None
                || !professorCategories.Contains(courseCategory)) {
                MessageBox.Show("Professor does not teach that category of subjects!");
                return false;
            }

            return true;

        }


        public bool ValidateStudentSchedule(Schedule newSchedule) {

            int count = 1; // The new schedule is not included in university schedules thats why we start from 1
            foreach (Schedule schedule in university.Schedules) {

                if (schedule.Student == newSchedule.Student && schedule.Calendar.Day == newSchedule.Calendar.Day) {


                    if (schedule.Calendar.Hour == newSchedule.Calendar.Hour) {
                        MessageBox.Show("Student is registered at that time!");
                        return false;
                    }

                    if (schedule.Course == newSchedule.Course) {
                        MessageBox.Show("Can not have same subject at the same day!");
                        return false;
                    }
                    count++;
                    if (count > 3) {

                        MessageBox.Show("Can not have more than 3 subjects");
                        return false;
                    }

                }

            }
            return true;

        }

        public bool ValidateStudentCourses(Schedule newSchedule) {

            var courseCategory = FindCourseCategory(newSchedule);
            var studentCategories = FindAppliedCategories(newSchedule.Student);

            if (studentCategories == null
                || courseCategory == CoursesCategoryEnum.None
                || !studentCategories.Contains(courseCategory)) {
                MessageBox.Show("Student is not registered to that category!");
                return false;
            }

            return true;
        }

        public bool TimeCheck() {
            if (dateTimePicker2.Value < dateTimePicker1.Value) {
                MessageBox.Show("Select a valid time!");
                return false;

            }
            return true;

        }

        public bool CheckCoursesOftheweek(Schedule newSchedule) {

            double totalWeeklyHours = newSchedule.Duration;
            foreach (Schedule schedule in university.Schedules) {

                if (schedule.Professor == newSchedule.Professor) {


                    if (GetWeek(schedule) == GetWeek(newSchedule)) {

                        totalWeeklyHours += schedule.Duration;
                        if (totalWeeklyHours > 40) {
                            MessageBox.Show("Professor can not have more than 40 hours per week!");
                            return false;
                        }
                    }

                }

            }
            return true;

        }



        #endregion




    }




}

