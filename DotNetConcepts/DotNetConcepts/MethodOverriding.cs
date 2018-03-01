using System;

class MethodOverriding
{
    class A
    {
        public void Foo()
        {
            Console.WriteLine("Foo - A");
        }

        public virtual void Bar()
        {
            Console.WriteLine("Bar - A");
        }
    }

    class B : A
    {
        public new void Foo() 
        {
            Console.WriteLine("Foo - B");
        }

        public override void Bar() 
        {
            Console.WriteLine("Bar - B");
        }

        public void Extra()
        {
            Console.WriteLine("Extra C");
        }
    }
}
 