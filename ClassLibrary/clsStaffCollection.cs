using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mStaffList = new List<clsStaff>();
        private clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }

        public int Count
        {
            get { return mStaffList.Count; }
        }

        public clsStaff ThisStaff
        {
            get { return mThisStaff; }
            set { mThisStaff = value; }
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;

            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();

                AStaff.StfID = Convert.ToInt32(DB.DataTable.Rows[Index]["StfID"]);
                AStaff.StfName = Convert.ToString(DB.DataTable.Rows[Index]["StfName"]);
                AStaff.StfEmail = Convert.ToString(DB.DataTable.Rows[Index]["StfEmail"]);
                AStaff.StfRole = Convert.ToString(DB.DataTable.Rows[Index]["StfRole"]);
                AStaff.StfSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StfSalary"]);
                AStaff.StfDateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["StfDateJoined"]);
                AStaff.StfIsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["StfIsActive"]);

                mStaffList.Add(AStaff);
                Index++;
            }
        }
    }
}