using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registaration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ndevr\OneDrive\Desktop\ASP(Active  Server Pages).NET\Cricket\App_Data\players.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("insert into players values (@Name,@Email,@Matches_Played,@Age,@Mabile)", con);

        cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Matches_Played", TextBox3.Text);
        cmd.Parameters.AddWithValue("@Age", TextBox4.Text);
        cmd.Parameters.AddWithValue("@Mabile", TextBox5.Text);

        cmd.ExecuteNonQuery();


        Response.Write("<script>alert('Data Inserted Succesfully')</script>");
        
        con.Close();

    }
}