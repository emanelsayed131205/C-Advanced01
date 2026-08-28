using System.ComponentModel;
using System.Reflection;

namespace C_Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 What is a generic class? Why use generics?

            //generic class is class has more than one type of parameters ,using generics provides reusability of the code , clean code and better performance
            #endregion

            #region q2 Write a generic class Container<T> with Add and Get methods.

            Container<string> box = new Container<string>();
            box.Add("hello");
            string text = box.Get(0);
            #endregion

            #region q3 Q3:What are multiple type parameters? Write Pair<TKey,TValue >.

            //class or interface or method can accept more than one placeholder type (not just <t> we can now make more than one )
            Pair<string, int> score = new Pair<string, int>("eman", 100);
            Console.WriteLine(score.Key+" "+score.Value);
            #endregion

            #region q4 What is a generic method? Write Swap<T> method.

            /*a method declared with type parameters, allowing it to process
             different data types with a single implementation while maintaining
             full type safety and avoiding performance overhead like boxing/unboxing.
            */
            int x = 5, y = 10;
            Utilities.Swap(ref x, ref y);
            string first = "Hello", second = "World";
            Utilities.Swap(ref first, ref second);
            #endregion

            #region q5 Write a generic method FindMax<T> that finds maximum value

            int[] numbers = { 3, 15, 7, 2, 9 };
            int maxNum = ArrayUtils.FindMax(numbers);
            string[] names = { "Apple", "Orange", "Banana" };
            string maxName = ArrayUtils.FindMax(names);
            #endregion

            #region q6 What is a generic interface? Write IRepository<T>.
            //A generic interface is an interface declared with type parameters,
            //allowing it to define a strongly-typed contract for classes to implement without committing to a specific data type up front.

            #endregion

            #region q7 What is the 'struct' constraint? Write an example.
            //allows you to specify which type can be used as arguments for a generic type
            var valid = new Calc<int>();
            #endregion

            #region q8 What is the 'class' constraint? Write an example.
            //allows only ref type 
            var validator = new Validator<string>();
            #endregion

            #region q9 What is the 'new()' constraint? Write an example.
            //constraints have public parameterless constructor
            var creator = new Creator<List<int>>(); 
            List<int> myList = creator.Build();
            #endregion

            #region q10 What is the interface constraint? Write an example.
            //restricts a generic type parameter T to types that implement a specific interface
            var saver = new Saver<StreamReader>();
            #endregion

            #region q11 What is the base class constraint? Write an example.
            //The base class constraint restricts a generic type parameter T to a specific class or its derived subclasses.
            var canvas = new Canvas<Circle>();

            #endregion

            #region q12 How do you apply multiple constraints? Write an example.
            /*When combining constraints, C# requires them to follow a strict order:

             *Primary constraint(Class, Struct, or Base Class) — must be first,Secondary constraints(Interfaces) — middle,Constructor constraint(new()) — must be last.
           */

            var manager = new Manager<Service>();
            manager.CreateAndLog();
            #endregion

            #region q13 What does the 'default' keyword do in generics?
            //the default keyword returns the default value of a type parameter
            //T when you do not know in advance whether T will be a reference type (like string or class) or a value type (like int or struct).

            #endregion

           
            #region q14 Write a SafeList<T> that returns default when the index is invalid.
            SafeList<int> number = new SafeList<int>();
            number.Add(42);

            Console.WriteLine(number.Get(0));
            Console.WriteLine(number.Get(99));

            #endregion

            #region q15 Q15: What is covariance? Explain the 'out' keyword.
            /*Covariance allows you to use a more derived type (subclass) than originally specified.
             * The out keyword makes a generic type parameter covariant, meaning T can only be returned (output), never accepted as a parameter (input).
             * 
             */
            #endregion


            #region q16 Q16: What is contravariance? Explain the 'in' keyword.
            /*Contravariance allows you to use a less derived type (a base class) where a
             * more derived type is expected. It reverses normal inheritance compatibility.
             * The in keyword marks a generic type parameter as contravariant.
             * 
             */
            #endregion

            #region q17 What is the difference between covariance and contravariance ?
            /*The core difference comes down to data direction:
             * Covariance (out): Preserves inheritance order. Allows returning a more derived type (subclass).
             * Contravariance (in): Reverses inheritance order. Allows passing a less derived type (base class).
             * 
             */

            #endregion

            #region q18 How do static members work in generic types?
            /*Static members in a generic class are not shared across different type arguments.
             * Each distinct closed type gets its own independent copy of static fields and static constructors.
             * 
             */

            #endregion

            #region q19 How can you inherit from a generic class?
            /*Specify a Concrete Type Provide a specific type (like string or int) when inheriting
             * Keep the Derived Class Generic Pass the type parameter T through to the base class
             */
            #endregion

            #region q20 Complete Exercise - Create a generic Cache<TKey,TValue > with Add, Get, Remove, Contains, and expiration support.
            var cache = new Cache<string, string>();

           
            cache.Add("session", "ActiveUser123", TimeSpan.FromSeconds(2));

            
            if (cache.Get("session", out string val))
            {
                Console.WriteLine($"Found: {val}"); 
            }

            
            Console.WriteLine(cache.Contains("session")); 

            
            cache.Remove("session");
            Console.WriteLine(cache.Contains("session")); 

            #endregion
        }
    }
}
