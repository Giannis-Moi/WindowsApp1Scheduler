using System;

namespace UniversityApp.Base {
    public class Entity {

        public Guid ID { get; }

        public Entity() {

            ID = Guid.NewGuid();
        }
    }
}

