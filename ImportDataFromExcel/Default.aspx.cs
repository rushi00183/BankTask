using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ImportDataFromExcel.Models;

namespace ImportDataFromExcel
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
                FileUpload.PostedFile.SaveAs(Server.MapPath("~/DailyFiles/") + fileName);

                label1.InnerText = "File Uploaded Successfully";

                string path = MapPath("~/DailyFiles/" + fileName);
                Extract_Data(path);

                   
            }
         

        }


        //Data Extraction method for Excel
        private void Extract_Data(string path)
        {
           
            string POCConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\";";

            OleDbConnection POCcon = new OleDbConnection(POCConnection);
            OleDbCommand POCcommand = new OleDbCommand();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            OleDbDataAdapter POCCommand = new OleDbDataAdapter("select * from [Banks$] ", POCcon);
            POCCommand.Fill(dt);
            OleDbDataAdapter POCCommand1 = new OleDbDataAdapter("select * from [Approved Banks$] ", POCcon);
            POCCommand1.Fill(dt1);

            DataRow[] rows1 = dt1.Select();
          
            List<BankName> abc= new List<BankName>();
            for (int i = 0; i < rows1.Length; i++)
            {
                BankName bankobj = new BankName();
                bankobj.Bank_Name = rows1[i]["BankName"].ToString();
              
                if (rows1[i]["Approved"].ToString().Trim() == "True")
                {
                    bankobj.Approved = true;
                }
                else
                {
                    bankobj.Approved = false;
                }

              
                abc.Add(bankobj);
            }

            DataRow[] rows = dt.Select();
           
            List<CustomModel> abc1 = new List<CustomModel>();
            for (int i = 0; i < rows.Length; i++)
            {
                CustomModel custobj = new CustomModel();
                custobj.Bank_Name = rows[i]["Name"].ToString();
                custobj.Rating   = Convert.ToInt32(rows[i]["Rating"].ToString());
                custobj.Assets = Convert.ToInt32(rows[i]["Total Assets"].ToString());
                custobj.Date =rows[i]["Date"].ToString();
                BankName temp = abc.Where(c => c.Bank_Name.ToLower() == custobj.Bank_Name.ToLower() && c.Approved == true).FirstOrDefault();
                if(temp != null)
                {
                    custobj.DailyLimit = CalculateAsset(custobj.Assets, custobj.Rating);

                    abc1.Add(custobj);
                }
                
            }

            grid1.DataSource = abc1;
            grid1.DataBind();
        }

        public int CalculateLimit(int asset, int Risk)
        {
            int Daily_limit = 0;


            if (asset >= 3000000)
            {
                int increment = (2000000 * 23) / 100;
                Daily_limit = 2000000 + increment;
            }
            else
            {
                Daily_limit = CalculateAsset(2000000, Risk);
            }



            return Daily_limit;
        }



        public int CalculateAsset(int asset, int Risk)
        {

            if (Risk >= -5 && Risk <= -3)
            {

                int deduction = (asset * 12) / 100;
                asset = 2000000 - deduction;

            }
            else if (Risk >= -2 && Risk <= 0)
            {
                int deduction = (asset * 9) / 100;
                asset = 2000000 - deduction;
            }
            else if (Risk >= 1 && Risk <= 3)
            {
                int deduction = (asset * 5) / 100;
                asset = 2000000 + deduction;
            }
            else if (Risk >= 4 && Risk <= 6)
            {
                int deduction = (asset * 8) / 100;
                asset = 2000000 + deduction;
            }
            else if (Risk >= 7 && Risk <= 10)
            {
                int deduction = (asset * 13) / 100;
                asset = 2000000 + deduction;
            }




            return asset;
        }
    }
}