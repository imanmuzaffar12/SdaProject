using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDA_project
{
      class Login
        {
            
            public static Login obj;

            private Login()
            {
            }
            public static Login GetObject()
            {
                if (obj == null)
                {
                    obj = new Login();
                }
                return obj;
            }
            public void User()
            {
                Console.WriteLine("Instance Created");
            }
        }

    }
