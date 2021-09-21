using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportDataFromExcel.Models
{
    public class BankName
    {
        #region Properties
        public int Bank_Id { get; set; }

        public Boolean Approved { get; set; }
        public string Bank_Name { get; set; }

        #endregion

        #region Constructor

        public BankName()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public BankName(Boolean approved, String bankName)
        {
            try
            {
                Bank_Name = bankName;
                Approved = approved;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}