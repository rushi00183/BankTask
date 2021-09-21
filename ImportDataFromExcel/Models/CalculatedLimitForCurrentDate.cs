using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportDataFromExcel.Models
{
    public class CalculatedLimitForCurrentDate
    {

        #region Properties
        public int Transaction_Id { get; set; }

        public int FK_Bank_Id { get; set; }
        public int Calculated_Limit_For_Current_Day { get; set; }

        public DateTime Date { get; set; }

        #endregion

        #region Constructor

        public CalculatedLimitForCurrentDate()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CalculatedLimitForCurrentDate(CalculatedLimitForCurrentDate calculatedLimitForCurrentDate)
        {
            try
            {
                FK_Bank_Id = calculatedLimitForCurrentDate.FK_Bank_Id;
                Calculated_Limit_For_Current_Day = calculatedLimitForCurrentDate.Calculated_Limit_For_Current_Day;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}