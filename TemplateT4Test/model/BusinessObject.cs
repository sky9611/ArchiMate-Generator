using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateT4Test.model
{
    partial class A
    {
        private static string documentation_ = "hdghdgh";
        B b;
        C c;
        public A()
        {
            b = new B();
            c = new C();
        }

        public static string Documentation_ { get => documentation_; set => documentation_ = value; }
    }

    partial class B
    {
        private static string documentation_ = "jhjhgjh";
    }

    partial class C
    {
        private static string documentation_ = "jhjhgjh";
    }
}
