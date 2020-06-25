using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Class1
    {
        public string conString = "Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True ";


        public  DataSet AL_bind()
        {
             SqlDataAdapter da = new SqlDataAdapter("select",conString);
             DataSet ds=new DataSet();
             da.Fill(ds);
            return ds;
        }

        public void insertdata(SqlCommand cmd)
        {
              SqlConnection con = new SqlConnection(conString);
              con.Open();
              cmd.Connection=con;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "SP_InsertProducts";
              cmd.ExecuteNonQuery();

        }

        public void insertdata1(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertCategories";
            cmd.ExecuteNonQuery();

        }
        public void insertdata2(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertCustomers";
            cmd.ExecuteNonQuery();

        }

        public void insertdata3(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertEmployees";
            cmd.ExecuteNonQuery();

        }

        public void Updatedata(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UpdateProducts";
            cmd.ExecuteNonQuery(); 

        }
        public void Updatedata1(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UpdateCategories";
            cmd.ExecuteNonQuery();

        }
        public void Updatedata2(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UpdateCustomer";
            cmd.ExecuteNonQuery();

        }
        public void Updatedata3(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UpdateEmplyoees";
            cmd.ExecuteNonQuery();

        }
        public void Deletedata(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DeleteProducts";
            cmd.ExecuteNonQuery();

        }
        public void Deletedata1(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DeleteCategories";
            cmd.ExecuteNonQuery();

        }
        public void Deletedata2(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DeleteCustomers";
            cmd.ExecuteNonQuery();

        }
        public void Deletedata3(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DeleteEmployees";
            cmd.ExecuteNonQuery();

        }

        
        }
    }
