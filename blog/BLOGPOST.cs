using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Diagnostics;

namespace blog
{
    public class BLOGPOST
    {

        private string PTitle;
        private string PBody;
        //private DateTime PDate;


        public string GetPTitle()
        {
            return PTitle;
        }
        public string GetPBody()
        {
            return PBody;
        }
       // public DateTime GetPDate()
       // {
       //     return PDate;
      //  }

        public void SetPTitle (string value)
        {
            PTitle = value;
        }
        public void SetPBody (string value)
        {
            PBody = value;
        }

       // public void SetPDate (DateTime value)
       // {
      //      PDate = value;
       // }
  
    }
}