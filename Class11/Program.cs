using System;

namespace Class11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static members (methods, variables, properties) are accessed at
            // the CLASS level.
            Console.WriteLine(Pizza.Cost);
            
            // Pizza is the class and defined in the Pizza.cs file.
            // chrisPizza is a object (an instance of the Pizza class).
            // From outside the Pizza class, we can only access public members
            //    ie. methods, variables, properties
            // Non-static or (instance members) are accessed at the OBJECT level.
            var chrisPizza = new Pizza("cheese");
            chrisPizza.Eat();

            // Constructors can have parameters (just like any other method)
            // In this case, the parameter is initializing a private (NON STATIC) field.
            // Non static fields are tied to the INSTANCE which is why we get two different results
            var jasonPizza = new Pizza("meat lovers");
            jasonPizza.Eat();
        }
    }
}
