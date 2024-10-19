using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Claysys_application
{
    public partial class Task1 : System.Web.UI.Page
    {
        SqlConnection Con = new SqlConnection(@"server=DESKTOP-EA5Q4E5\SQLEXPRESS;database=DB_Ado;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string==> '"+...+"'              '"++"'
            //int==> "+...+"

            string ins = "Insert into Table_1 values('" + TextBox1.Text + "'," + TextBox2.Text + ")";

            // to read query in connected mode

            SqlCommand cmd = new SqlCommand(ins,Con); // cmd= insert query

            // open connection with db

            Con.Open();
            int i=cmd.ExecuteNonQuery();  // used to execute the query which returns no any data
            Con.Close();

            if (i == 1)
            {
                Label2.Text = "Inserted!";
            }
        }
    }
}