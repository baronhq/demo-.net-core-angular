using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Console;

namespace Demo_.net_core_angular
{
    public class csharp6Demo1
    {
        //System.Console

        public bool a() => 1 == 1;

        public string b => a() + "aaa";
    }

    public class Person
    {
        public int age { get; set; } = 42;

        //private readonly int _bookId;
        public int BookId { get; }

        public void A(object o)
        {
            throw new ArgumentNullException(nameof(o));
        }
    }
}