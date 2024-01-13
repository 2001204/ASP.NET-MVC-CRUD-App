using Microsoft.EntityFrameworkCore;
using MyMVCDemo1.Models;

namespace MyMVCDemo1.Data
{
    public class MyWebAppDb: DbContext
    {
        //it have one constructor 
        public MyWebAppDb(DbContextOptions options):base(options) 
        {

        }

        //list o tables to be operated by DbContext
        //it will create Employees table for Employee model class
        public DbSet<Employee> Employees { get; set; }

        //it will create Depts table for Employee model class
        public DbSet<Dept> Depts { get; set; }

        //it will create Persons table for Employee model class
        public DbSet<Person> Persons { get; set; }


        //join table queries are DTOs are also registerd here 



        //ModalBuilder : 

    }
}
