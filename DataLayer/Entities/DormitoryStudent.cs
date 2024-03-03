using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeRoom.DataLayer.Entities
{
    public class DormitoryStudent
    { 
        [Key]
        public int ID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; } // Here name of object must
                                             // match with foreing key annotation name
                                             //(emrin brenda kllapave te foreign key)

        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }
    }

}

