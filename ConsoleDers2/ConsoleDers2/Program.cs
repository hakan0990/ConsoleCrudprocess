using ConsoleDers2.DAL;
using ConsoleDers2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDers2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Code first sınıfları tablo yapar 
            //Person 
            //Job
            //Entitiesde sınıflar tutulur DAL-Contextte ise database ilişkikeri kurulur
            //Context yapmadan önce yapılandırılma ayarı yapılmalı 
            //Code First Crud işlemleri datababasede  dört temel veritabanı işlemi olan "Oluşturma, Okuma, Güncelleştirme ve Silme" anlamına gelir bunları visual studioda yapmamızı sağlar.
             
            Context c=new Context();

            var values = c.Customers.ToList();

            void Listele()
            {
                foreach (var item in values)
                {

                    Console.WriteLine(item.CustomerName + " ----- " + item.CustomerCity);



                }


            }

            //Ekleme

            //Customer customer = new Customer();
            //customer.CustomerName = "Eylül Yücedağ";
            //customer.CustomerCity = "Lviv";
            // c.Customers.Add(customer);
            //c.SaveChanges();
            //Listele();


            //Silme

            //var values2=c.Customers.Where(x=>x.CustomerID==8).FirstOrDefault();

            //c.Customers.Remove(values2);

            //c.SaveChanges();
            //Console.WriteLine("İşlem Tamamlandı");

            //Güncelleme

            //var values3=c.Customers.Where(x=>x.CustomerID==3).FirstOrDefault();

            //values3.CustomerName = "Ahmet Karalı";
            //values3.CustomerCity = "Trabzon";

            //c.SaveChanges();

            //Console.WriteLine("İşlem Tamamlandı");

            //Listele();



            

         




            Console.ReadLine();

            

        }
    }
}
