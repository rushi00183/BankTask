using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportDataFromExcel.Models
{
    public class CustomModel
    {
        #region Properties
       
        public string Bank_Name     { get; set; }
        public int Assets        { get; set; }
        public string Date          { get; set; }
        public int Rating        { get; set; }
        public int DailyLimit { get; set; }
        #endregion

        #region Constructor

        public CustomModel()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CustomModel(CustomModel custom)
        {
            try
            {
                Bank_Name=custom.Bank_Name; 
                Assets   =custom.Assets    ;
               Date      =custom.Date      ;
               Rating    =custom.Rating    ;
               DailyLimit=custom.DailyLimit;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}