using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iwenli.NHLearn.Part1.Model;
using Iwenli.NHLearn.Part1.DAL;

namespace Iwenli.NHLearn.Part1.MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "zhang";
            customer.LastName = "san";

            CustomerService cs = new CustomerService();
            cs.Insert(customer);

            //IList<Customer> list = cs.LoadAll();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(string.Format("客户编号为{0}的人叫{1}{2}",item.CustomerId,item.FirstName,item.LastName));
            //}
            Console.ReadKey();
        }
    }
}
