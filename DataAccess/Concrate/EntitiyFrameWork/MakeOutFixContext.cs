using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrate;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrate.EntitiyFrameWork
{
    public class MakeOutFixContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MakeOutFix;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<DietMethod> DietMethods { get; set; }
        public DbSet<Illness> Illnesses { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
