using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportDataFromExcel.Models
{
    public class TotalAssets
    {

        #region Properties
        public int Asset_Id { get; set; }

        public int Assets { get; set; }
        public int FK_Bank_Id { get; set; }

        public DateTime Date { get; set; }

        #endregion

        #region Constructor

        public TotalAssets()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public TotalAssets(TotalAssets totalAssets)
        {
            try
            {
                Assets =      totalAssets.Assets;
                FK_Bank_Id =    totalAssets.FK_Bank_Id;
                Date = totalAssets.Date;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}