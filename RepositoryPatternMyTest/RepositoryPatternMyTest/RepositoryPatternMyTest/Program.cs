using System;
using System.Collections.Generic;
using DRepositoryPatternMyTest.DomainModel;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using RepositoryPatternMyTest.DomainModel;
using RepositoryPatternMyTest.ORM.Mapping.Nhibernate;
using RepositoryPatternMyTest.ORM.Nhibernate;

namespace RepositoryPatternMyTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISessionFactory factory = CreateConfiguration();


            using (var u = new UnitOfWork(factory))
            {
                var re = new Repository<Employee, int>(factory.OpenSession());
                var rc = new Repository<Customer, int>(factory.OpenSession());
                var ro = new Repository<Order, int>(factory.OpenSession());
                var rp = new Repository<Product, int>(factory.OpenSession());


                var emp = new Employee();
                emp.Name = new Name("test1111", "Test", "Test again");
                re.Add(emp);


                var c = new Customer();
                c.Address = new Address();
                c.Address.City = "asdasdasd";
                c.Address.ZipCode = "123";
                c.Address.Line1 = "123";
                c.Address.Line2 = "123";
                c.Address.State = "123";
                c.ChangeCustomerName("asd", "asd", "asd", "identif");

                rc.Add(c);


                var p = new Product();
                p.Name = "product1";
                p.UnitPrice = 123;
                rp.Add(p);

                var p2 = new Product();
                p2.Name = "product2";
                p2.UnitPrice = 12;
                rp.Add(p2);


                var o = new Order(c);
                o.AddProduct(c, p, 3);
                o.AddProduct(c, p2, 12);
                ro.Add(o);

                u.Commit();
            }
            using (var u = new UnitOfWork(factory))
            {
                var r = new Repository<Customer, int>(factory.OpenSession());
                IEnumerable<Customer> customers = r.GetAll();
                foreach (Customer c in customers)
                {
                    Console.WriteLine(c.CustomerName.FirstName + " " + c.CustomerName.LastName + " " + c.ID);
                    foreach (Order o in c.Orders)
                    {
                        Console.WriteLine("Order total: " + o.OrderTotal + " Customer ID :" + o.Customer.ID +
                                          "Order date:" + o.OrderDate);
                    }
                }
                u.Commit();
            }
            Console.Write("Hit enter to exit:");
            Console.ReadLine();
        }

        private static ISessionFactory CreateConfiguration()
        {
            Configuration config;
            config = Fluently.Configure()
                .Database(
                    MsSqlConfiguration
                        .MsSql2008
                        .ConnectionString(
                            @"Data Source=localhost;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
                .BuildConfiguration();
            var exporter = new SchemaExport(config);
            exporter.Execute(true, true, false);

            return config.BuildSessionFactory();
        }
    }
}