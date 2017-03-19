using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iwenli.NHLearn.Part1.Model
{
    public class Customer
    {
        public virtual int CustomerId { set; get; }
        public virtual String FirstName { set; get; }
        public virtual String LastName { set; get; }
        public virtual int Version { set; get; }
    }
}
