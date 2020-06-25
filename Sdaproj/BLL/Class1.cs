using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class bal
    {
        Class1 h = new Class1();


        SqlCommand cmd = new SqlCommand();

        public int Product_Id
        {
            get;
            set;
        }
        public string Product_Name
        {
            get;
            set;
        }

        public int UnitPrice
        {
            get;
            set;
        }

        public int UnitInstock
        {
            get;
            set;
        }


        public int Category_Id 
        {
            get;
            set;
        }
        public string Category_Name
        {
            get;
            set;
        }
        public string Category_Desc 
        {
            get;
            set;
        }

        public int Employee_Id 
        {
            get;
            set;
        }

        public string Emp_Name 
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
     public string  Birthdate 
        {
            get;
            set;
        }
     public string Hiredate
        {
            get;
            set;
        }
     public string Salary
        {
            get;
            set;
        }
     public string City
        {
            get;
            set;
        }
 
     public int Customer_Id
     {
         get;
         set;
     }

     public string Cus_Name
     {
         get;
         set;
     }
     public string Cus_Address
     {
         get;
         set;
     }
     public string Contact_No
     {
         get;
         set;
     }
     public string Gender
     {
         get;
         set;
     }
 
     public string Country
     {
         get;
         set;
     }
     public string Region
     {
         get;
         set;
     }

     public string PostalCode
     {
         get;
         set;
     }
        
        public DataSet Bl_Bind()
        {
            return h.AL_bind();
        }

        public void insert_record()
        {
            cmd.Parameters.AddWithValue("@Product_Id", Product_Id);
            cmd.Parameters.AddWithValue("@Product_Name",Product_Name);
            cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
            cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            cmd.Parameters.AddWithValue("@UnitInstock", UnitInstock);
            h.insertdata(cmd);


        }
        public void insert_record1()
        {
            cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
            cmd.Parameters.AddWithValue("@Category_Name", Category_Name);
            cmd.Parameters.AddWithValue("@Category_Desc",Category_Desc);
            h.insertdata1(cmd);
        }

        public void insert_record2()
        {
            cmd.Parameters.AddWithValue("Customer_Id", Customer_Id);
            cmd.Parameters.AddWithValue("@Cus_Address ", Cus_Address );
            cmd.Parameters.AddWithValue("@Contact_No ",Contact_No  );
            cmd.Parameters.AddWithValue("@Gender ",Gender );
            cmd.Parameters.AddWithValue("@City", City);
             cmd.Parameters.AddWithValue("@Country ",Country );
            cmd.Parameters.AddWithValue("@Region ", Region );
             cmd.Parameters.AddWithValue("@Postal_Code",PostalCode);
             h.insertdata2(cmd);


        }

        public void insert_record3()
        {
            cmd.Parameters.AddWithValue("@Employee_Id",Employee_Id );
            cmd.Parameters.AddWithValue("@Emp_Name",Emp_Name );
            cmd.Parameters.AddWithValue("@Email",Email );
            cmd.Parameters.AddWithValue("@Birthdate", Birthdate);
            cmd.Parameters.AddWithValue("@Hiredate",Hiredate );
            cmd.Parameters.AddWithValue("@Salary",Salary );
            cmd.Parameters.AddWithValue("@City",City );
            cmd.Parameters.AddWithValue("@Country ",Country );
            cmd.Parameters.AddWithValue("@Region ", Region);

            h.insertdata3(cmd);
        }


        public void Update_record(int Product_Id)
        {
            cmd.Parameters.AddWithValue("@Product_Id", Product_Id);
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name);
            cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
            cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            cmd.Parameters.AddWithValue("@UnitInstock", UnitInstock);
            h.Updatedata(cmd);

        }


        public void Update_record1(int Category_Id)
        {
            cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
            cmd.Parameters.AddWithValue("@Category_Name", Category_Name);
            cmd.Parameters.AddWithValue("@Category_Desc", Category_Desc);
            h.insertdata1(cmd);
        }

        public void Update_record2(int Customer_Id)
        {
            cmd.Parameters.AddWithValue("Customer_Id", Customer_Id);
            cmd.Parameters.AddWithValue("@Cus_Address ", Cus_Address);
            cmd.Parameters.AddWithValue("@Contact_No ", Contact_No);
            cmd.Parameters.AddWithValue("@Gender ", Gender);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@Country ", Country);
            cmd.Parameters.AddWithValue("@Region ", Region);
            cmd.Parameters.AddWithValue("@Postal_Code", PostalCode);
            h.Updatedata2(cmd);


        }

        public void Update_record3(int Employee_Id)
        {
            cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
            cmd.Parameters.AddWithValue("@Emp_Name", Emp_Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Birthdate", Birthdate);
            cmd.Parameters.AddWithValue("@Hiredate", Hiredate);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@Country ", Country);
            cmd.Parameters.AddWithValue("@Region ", Region);

            h.Updatedata3(cmd);
        }

        
  


        public void delete_record(int Product_Id)
        {
            cmd.Parameters.AddWithValue("@Product_Id", Product_Id);
            h.Deletedata(cmd);

        }
        public void delete_record1(int Category_Id)
        {
            cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
            h.Deletedata(cmd);

        }
        public void delete_record2(int Customer_Id)
        {
            cmd.Parameters.AddWithValue("Customer_Id", Customer_Id);
            h.Deletedata(cmd);

        }

        public void delete_record3(int Employee_Id)
        {
            cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
            h.Deletedata(cmd);

        }
    }
}
