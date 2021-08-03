using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Moderation.BLL
{
    class ClassDetails
    {
        public ClassDetails()
        {

        }
        public ClassDetails(string classTime, int classNo, string dayName, string classDate)
        {
            this.ClassTime = classTime;
            this.ClassNo = classNo;
            this.DayName = dayName;
            this.ClassDate = classDate;
        }
        public string ClassTime { get; set; }
        public int ClassNo { get; set; }
        public string DayName { get; set; }
        public string ClassDate { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | {3}",
               this.DayName, this.ClassDate, this.ClassTime, this.ClassNo);
        }
    }
}
