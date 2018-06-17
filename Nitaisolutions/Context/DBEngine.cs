using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Nitaisolutions.Models;


namespace Nitaisolutions.NitaiDB
{
    public class DBEngine : DbContext
     {

        public DBEngine() :  base("name=Nitaisol_DB")

        {

        }
        public DbSet<Userinfo> Users { get; set; }
    }
}