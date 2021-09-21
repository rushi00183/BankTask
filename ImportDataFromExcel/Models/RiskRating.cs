using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportDataFromExcel.Models
{
    public class RiskRating
    {
        #region Properties
        public int Risk_Id { get; set; }

        public int Risk_Percentage { get; set; }
        public int FK_Bank_Id { get; set; }

        public DateTime Date { get; set; }

        #endregion

        #region Constructor

        public RiskRating()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public RiskRating(RiskRating riskRating)
        {
            try
            {
                Risk_Percentage = riskRating.Risk_Percentage;
                FK_Bank_Id = riskRating.FK_Bank_Id;
                Date = riskRating.Date;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}