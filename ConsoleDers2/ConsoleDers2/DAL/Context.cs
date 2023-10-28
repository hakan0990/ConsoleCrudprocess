using ConsoleDers2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDers2.DAL
{
    internal class Context:DbContext
    {


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}

/*
 
Tablo yanındaki s  eklemeleri databasede tablo sütunu adı gözükür.
sınıf ve tablolar karışmasın diye yalın hali sınıf çoğul hali tablo olarak alınır

job-Class
jobs-table
 
migration -->Göç İşlemi C# daki sınıf database tablo olarak gönderir

Yeni bir sınıf eklerken veya silerken migrations göç işlemini gene uygulayabiliriz

yeni göç ekle gibisinden add-migrations mig 1 gibi 



*/