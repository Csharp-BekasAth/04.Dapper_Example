using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   public class Customer
    {

        public int ID { get; set; }
        public string NAME { get; set; }     
        public string AFM { get; set; }
    }
}

/*  CREATE TABLE CUSTOMER (ID INT PRIMARY KEY IDENTITY(1,1),
                           NAME NVARCHAR(30),
                           AFM NVARCHAR(30))*/