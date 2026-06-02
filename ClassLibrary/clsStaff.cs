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
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StfID", StfID);
            DB.Execute("sproc_tblStaff_FilterByStfID");

            if (DB.Count == 1)
            {
                this.StfID = Convert.ToInt32(DB.DataTable.Rows[0]["StfID"]);
                this.StfName = Convert.ToString(DB.DataTable.Rows[0]["StfName"]);
                this.StfEmail = Convert.ToString(DB.DataTable.Rows[0]["StfEmail"]);
                this.StfRole = Convert.ToString(DB.DataTable.Rows[0]["StfRole"]);
                this.StfSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StfSalary"]);
                this.StfDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["StfDateJoined"]);
                this.StfIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["StfIsActive"]);

                return true;
            }

            return false;
        }

        public string Valid(string stfName,
                            string stfEmail,
                            string stfRole,
                            string stfSalary,
                            string stfDateJoined)
        {
            string Error = "";
            DateTime DateTemp;
            Int32 SalaryTemp;

            if (stfName.Length == 0)
            {
                Error += "The staff name may not be blank. ";
            }

            if (stfName.Length > 100)
            {
                Error += "The staff name must be less than 100 characters. ";
            }

            if (stfEmail.Length == 0)
            {
                Error += "The staff email may not be blank. ";
            }

            if (stfEmail.Length > 100)
            {
                Error += "The staff email must be less than 100 characters. ";
            }

            if (stfEmail.Contains("@") == false)
            {
                Error += "The staff email must contain @. ";
            }

            if (stfRole.Length == 0)
            {
                Error += "The staff role may not be blank. ";
            }

            if (stfRole.Length > 50)
            {
                Error += "The staff role must be less than 50 characters. ";
            }

            try
            {
                SalaryTemp = Convert.ToInt32(stfSalary);

                if (SalaryTemp < 0)
                {
                    Error += "The staff salary cannot be negative. ";
                }

                if (SalaryTemp > 1000000)
                {
                    Error += "The staff salary is too high. ";
                }
            }
            catch
            {
                Error += "The staff salary must be a valid number. ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(stfDateJoined);

                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date joined cannot be in the future. ";
                }

                if (DateTemp < DateTime.Now.Date.AddYears(-50))
                {
                    Error += "The date joined is too far in the past. ";
                }
            }
            catch
            {
                Error += "The date joined must be a valid date. ";
            }

            return Error;
        }
    }
}