using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OOTest_CSharp
{
    public class A
    {
        public virtual void M1()
        {
            Debug.WriteLine("A.M1");
        }

        public virtual void M2()
        {
            Debug.WriteLine("A.M2");
        }

      
    }


    public class B : A
    {

        public override void M1()
        {
            Debug.WriteLine("B.M1");
        }


        public new void M2()
        {
            Debug.WriteLine("B.M2");
        }



    }

    class C : B
    {

        public override void M1()
        {
            Debug.WriteLine("C.M1");
        }


        public new void M2(int i)
        {
            Debug.WriteLine("C.M2(i)");
        }

    }

   
}
