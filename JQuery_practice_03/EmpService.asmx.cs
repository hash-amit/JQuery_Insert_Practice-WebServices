using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace JQuery_practice_03
{
    /// <summary>
    /// Summary description for EmpService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmpService : System.Web.Services.WebService
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-IOJE25P\\SQLEXPRESS;initial catalog=DB_Practice_JQuery;integrated security=true");

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [WebMethod]
        public void Insert(string A, int B)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EName", A);
            cmd.Parameters.AddWithValue("@Age", B);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
