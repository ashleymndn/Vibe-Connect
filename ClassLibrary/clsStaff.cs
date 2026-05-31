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
                StfID = Convert.ToInt32(DB.DataTable.Rows[0]["StfID"]);
                StfName = Convert.ToString(DB.DataTable.Rows[0]["StfName"]);
                StfEmail = Convert.ToString(DB.DataTable.Rows[0]["StfEmail"]);
                StfRole = Convert.ToString(DB.DataTable.Rows[0]["StfRole"]);
                StfSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StfSalary"]);
                StfDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["StfDateJoined"]);
                StfIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["StfIsActive"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}