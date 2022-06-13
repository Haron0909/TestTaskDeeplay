using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDeeplayWpf.DbModels
{
    class Staff
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string UniqueInfo { get; set; }
        public string Post { get; set; }
    }
}
