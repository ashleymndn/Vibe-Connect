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
            else
            {
                return false;
            }
        }

        public string Valid(string stfName,
                            string stfEmail,
                            string stfRole,
                            string stfSalary,
                            string stfDateJoined)
        {
            string Error = "";

            if (stfName.Length == 0)
            {
                Error = Error + "The staff name may not be blank. ";
            }

            if (stfName.Length > 100)
            {
                Error = Error + "The staff name must be less than 100 characters. ";
            }

            return Error;
        }
    }
}