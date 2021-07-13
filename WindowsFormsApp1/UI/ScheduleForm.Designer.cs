
namespace UniversityApp.WUI {
    partial class ScheduleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlRemove = new System.Windows.Forms.Button();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.lbl_University = new System.Windows.Forms.Label();
            this.gridViewSchedule = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlAdd = new System.Windows.Forms.Button();
            this.ctrl_SelectedStudent = new System.Windows.Forms.TextBox();
            this.ctrl_SelectedProfessor = new System.Windows.Forms.TextBox();
            this.ctrl_Selectedsubject = new System.Windows.Forms.TextBox();
            this.ctrl_SelectedDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_SubjectCategory = new System.Windows.Forms.Label();
            this.lbl_ProfessorCategory = new System.Windows.Forms.Label();
            this.lbl_StudentCategory = new System.Windows.Forms.Label();
            this.ctrl_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.lbl_Professors = new System.Windows.Forms.Label();
            this.lbl_Subjects = new System.Windows.Forms.Label();
            this.List_Professors = new System.Windows.Forms.ListBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.List_Students = new System.Windows.Forms.ListBox();
            this.List_Subjects = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlRemove
            // 
            this.ctrlRemove.BackColor = System.Drawing.Color.SaddleBrown;
            this.ctrlRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ctrlRemove.Location = new System.Drawing.Point(579, 669);
            this.ctrlRemove.Name = "ctrlRemove";
            this.ctrlRemove.Size = new System.Drawing.Size(76, 27);
            this.ctrlRemove.TabIndex = 9;
            this.ctrlRemove.Text = "Remove";
            this.ctrlRemove.UseVisualStyleBackColor = false;
            this.ctrlRemove.Click += new System.EventHandler(this.Ctrl_Remove_Click);
            // 
            // ctrlSave
            // 
            this.ctrlSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.ctrlSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ctrlSave.Location = new System.Drawing.Point(705, 669);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(76, 27);
            this.ctrlSave.TabIndex = 12;
            this.ctrlSave.Text = "Save";
            this.ctrlSave.UseVisualStyleBackColor = false;
            this.ctrlSave.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // lbl_University
            // 
            this.lbl_University.AutoSize = true;
            this.lbl_University.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_University.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_University.Location = new System.Drawing.Point(3, -3);
            this.lbl_University.Name = "lbl_University";
            this.lbl_University.Size = new System.Drawing.Size(538, 54);
            this.lbl_University.TabIndex = 13;
            this.lbl_University.Text = "University Courses Scheduler";
            // 
            // gridViewSchedule
            // 
            this.gridViewSchedule.AllowUserToAddRows = false;
            this.gridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Professor,
            this.Course,
            this.Calendar,
            this.Id,
            this.Duration});
            this.gridViewSchedule.Location = new System.Drawing.Point(12, 431);
            this.gridViewSchedule.Name = "gridViewSchedule";
            this.gridViewSchedule.RowHeadersVisible = false;
            this.gridViewSchedule.RowHeadersWidth = 51;
            this.gridViewSchedule.RowTemplate.Height = 24;
            this.gridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSchedule.Size = new System.Drawing.Size(785, 185);
            this.gridViewSchedule.TabIndex = 16;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            // 
            // Professor
            // 
            this.Professor.DataPropertyName = "Professor";
            this.Professor.HeaderText = "Professor";
            this.Professor.MinimumWidth = 6;
            this.Professor.Name = "Professor";
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            // 
            // Calendar
            // 
            this.Calendar.DataPropertyName = "Calendar";
            this.Calendar.HeaderText = "Date";
            this.Calendar.MinimumWidth = 6;
            this.Calendar.Name = "Calendar";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            // 
            // ctrlAdd
            // 
            this.ctrlAdd.BackColor = System.Drawing.Color.SaddleBrown;
            this.ctrlAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ctrlAdd.Location = new System.Drawing.Point(101, 295);
            this.ctrlAdd.Name = "ctrlAdd";
            this.ctrlAdd.Size = new System.Drawing.Size(76, 27);
            this.ctrlAdd.TabIndex = 8;
            this.ctrlAdd.Text = "Add";
            this.ctrlAdd.UseVisualStyleBackColor = false;
            this.ctrlAdd.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // ctrl_SelectedStudent
            // 
            this.ctrl_SelectedStudent.Location = new System.Drawing.Point(44, 36);
            this.ctrl_SelectedStudent.Name = "ctrl_SelectedStudent";
            this.ctrl_SelectedStudent.ReadOnly = true;
            this.ctrl_SelectedStudent.Size = new System.Drawing.Size(194, 22);
            this.ctrl_SelectedStudent.TabIndex = 24;
            // 
            // ctrl_SelectedProfessor
            // 
            this.ctrl_SelectedProfessor.Location = new System.Drawing.Point(44, 103);
            this.ctrl_SelectedProfessor.Name = "ctrl_SelectedProfessor";
            this.ctrl_SelectedProfessor.ReadOnly = true;
            this.ctrl_SelectedProfessor.Size = new System.Drawing.Size(194, 22);
            this.ctrl_SelectedProfessor.TabIndex = 23;
            // 
            // ctrl_Selectedsubject
            // 
            this.ctrl_Selectedsubject.Location = new System.Drawing.Point(44, 173);
            this.ctrl_Selectedsubject.Name = "ctrl_Selectedsubject";
            this.ctrl_Selectedsubject.ReadOnly = true;
            this.ctrl_Selectedsubject.Size = new System.Drawing.Size(194, 22);
            this.ctrl_Selectedsubject.TabIndex = 22;
            // 
            // ctrl_SelectedDate
            // 
            this.ctrl_SelectedDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrl_SelectedDate.Location = new System.Drawing.Point(44, 248);
            this.ctrl_SelectedDate.Name = "ctrl_SelectedDate";
            this.ctrl_SelectedDate.ReadOnly = true;
            this.ctrl_SelectedDate.Size = new System.Drawing.Size(194, 22);
            this.ctrl_SelectedDate.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_SubjectCategory);
            this.groupBox2.Controls.Add(this.lbl_ProfessorCategory);
            this.groupBox2.Controls.Add(this.lbl_StudentCategory);
            this.groupBox2.Controls.Add(this.ctrlAdd);
            this.groupBox2.Controls.Add(this.ctrl_SelectedDate);
            this.groupBox2.Controls.Add(this.ctrl_SelectedStudent);
            this.groupBox2.Controls.Add(this.ctrl_SelectedProfessor);
            this.groupBox2.Controls.Add(this.ctrl_Selectedsubject);
            this.groupBox2.Location = new System.Drawing.Point(535, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 328);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Schedule";
            // 
            // lbl_SubjectCategory
            // 
            this.lbl_SubjectCategory.AutoSize = true;
            this.lbl_SubjectCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_SubjectCategory.Location = new System.Drawing.Point(41, 202);
            this.lbl_SubjectCategory.Name = "lbl_SubjectCategory";
            this.lbl_SubjectCategory.Size = new System.Drawing.Size(0, 17);
            this.lbl_SubjectCategory.TabIndex = 28;
            // 
            // lbl_ProfessorCategory
            // 
            this.lbl_ProfessorCategory.AutoSize = true;
            this.lbl_ProfessorCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_ProfessorCategory.Location = new System.Drawing.Point(41, 128);
            this.lbl_ProfessorCategory.Name = "lbl_ProfessorCategory";
            this.lbl_ProfessorCategory.Size = new System.Drawing.Size(0, 17);
            this.lbl_ProfessorCategory.TabIndex = 27;
            // 
            // lbl_StudentCategory
            // 
            this.lbl_StudentCategory.AutoSize = true;
            this.lbl_StudentCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_StudentCategory.Location = new System.Drawing.Point(41, 61);
            this.lbl_StudentCategory.Name = "lbl_StudentCategory";
            this.lbl_StudentCategory.Size = new System.Drawing.Size(0, 17);
            this.lbl_StudentCategory.TabIndex = 26;
            // 
            // ctrl_Date
            // 
            this.ctrl_Date.CustomFormat = "MMMMdd, yyyy ";
            this.ctrl_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrl_Date.Location = new System.Drawing.Point(215, 307);
            this.ctrl_Date.MinDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.ctrl_Date.Name = "ctrl_Date";
            this.ctrl_Date.Size = new System.Drawing.Size(213, 22);
            this.ctrl_Date.TabIndex = 10;
            this.ctrl_Date.ValueChanged += new System.EventHandler(this.Ctrl_Date_ValueChanged);
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_Students.Location = new System.Drawing.Point(4, 18);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(74, 18);
            this.lbl_Students.TabIndex = 19;
            this.lbl_Students.Text = "Students :";
            // 
            // lbl_Professors
            // 
            this.lbl_Professors.AutoSize = true;
            this.lbl_Professors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Professors.Location = new System.Drawing.Point(6, 109);
            this.lbl_Professors.Name = "lbl_Professors";
            this.lbl_Professors.Size = new System.Drawing.Size(90, 18);
            this.lbl_Professors.TabIndex = 18;
            this.lbl_Professors.Text = "Professors :";
            // 
            // lbl_Subjects
            // 
            this.lbl_Subjects.AutoSize = true;
            this.lbl_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Subjects.Location = new System.Drawing.Point(6, 203);
            this.lbl_Subjects.Name = "lbl_Subjects";
            this.lbl_Subjects.Size = new System.Drawing.Size(73, 18);
            this.lbl_Subjects.TabIndex = 17;
            this.lbl_Subjects.Text = "Subjects :";
            // 
            // List_Professors
            // 
            this.List_Professors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.List_Professors.FormattingEnabled = true;
            this.List_Professors.ItemHeight = 28;
            this.List_Professors.Location = new System.Drawing.Point(84, 109);
            this.List_Professors.Name = "List_Professors";
            this.List_Professors.Size = new System.Drawing.Size(344, 88);
            this.List_Professors.TabIndex = 6;
            this.List_Professors.SelectedValueChanged += new System.EventHandler(this.List_Professors_SelectedValueChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Date.Location = new System.Drawing.Point(6, 312);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(107, 18);
            this.lbl_Date.TabIndex = 20;
            this.lbl_Date.Text = "Date and time :";
            // 
            // List_Students
            // 
            this.List_Students.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.List_Students.FormattingEnabled = true;
            this.List_Students.ItemHeight = 28;
            this.List_Students.Location = new System.Drawing.Point(84, 15);
            this.List_Students.Name = "List_Students";
            this.List_Students.Size = new System.Drawing.Size(344, 88);
            this.List_Students.TabIndex = 5;
            this.List_Students.SelectedValueChanged += new System.EventHandler(this.List_Students_SelectedValueChanged);
            // 
            // List_Subjects
            // 
            this.List_Subjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.List_Subjects.FormattingEnabled = true;
            this.List_Subjects.ItemHeight = 28;
            this.List_Subjects.Location = new System.Drawing.Point(84, 203);
            this.List_Subjects.Name = "List_Subjects";
            this.List_Subjects.Size = new System.Drawing.Size(344, 88);
            this.List_Subjects.TabIndex = 4;
            this.List_Subjects.SelectedValueChanged += new System.EventHandler(this.List_Subjects_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.List_Subjects);
            this.groupBox1.Controls.Add(this.List_Students);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.List_Professors);
            this.groupBox1.Controls.Add(this.lbl_Subjects);
            this.groupBox1.Controls.Add(this.lbl_Professors);
            this.groupBox1.Controls.Add(this.lbl_Students);
            this.groupBox1.Controls.Add(this.ctrl_Date);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 374);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your options";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(338, 335);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(90, 22);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2021, 7, 12, 10, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 22);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 12, 8, 0, 0, 0);
            // 
            // ScheduleForm
            // 
            this.ClientSize = new System.Drawing.Size(825, 737);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridViewSchedule);
            this.Controls.Add(this.lbl_University);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlRemove);
            this.Name = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Button ctrlRemove;
        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Label lbl_University;
        private System.Windows.Forms.DataGridView gridViewSchedule;
        private System.Windows.Forms.Button ctrlAdd;
        private System.Windows.Forms.TextBox ctrl_SelectedStudent;
        private System.Windows.Forms.TextBox ctrl_SelectedProfessor;
        private System.Windows.Forms.TextBox ctrl_Selectedsubject;
        private System.Windows.Forms.TextBox ctrl_SelectedDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker ctrl_Date;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.Label lbl_Professors;
        private System.Windows.Forms.Label lbl_Subjects;
        private System.Windows.Forms.ListBox List_Professors;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.ListBox List_Students;
        private System.Windows.Forms.ListBox List_Subjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ProfessorCategory;
        private System.Windows.Forms.Label lbl_StudentCategory;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Label lbl_SubjectCategory;
    }
}