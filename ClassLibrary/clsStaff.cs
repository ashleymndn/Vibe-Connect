using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public Int32 StfID { get; set; }
        public string StfName { get; set; }
        public string StfEmail { get; set; }
        public string StfRole { get; set; }
        public Int32 StfSalary { get; set; }
        public DateTime StfDateJoined { get; set; }
        public Boolean StfIsActive { get; set; }
    }
}