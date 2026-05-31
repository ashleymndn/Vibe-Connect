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

        public bool Find(int StfID)
        {
            this.StfID = 21;
            this.StfName = "Test Staff";
            this.StfEmail = "teststaff@email.com";
            this.StfRole = "Manager";
            this.StfSalary = 25000;
            this.StfDateJoined = Convert.ToDateTime("01/01/2024");
            this.StfIsActive = true;

            return true;
        }
    }
}