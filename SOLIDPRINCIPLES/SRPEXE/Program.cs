using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPEXE
{

    /*
        The Single Responsibility Principle states that every object should only have one reason to change and a single focus of responsibility. 
        In other words every object should perform one thing only. You can apply this idea at different levels of your software: a method should only carry out one action; 
        a domain object should only represent one domain within your business; the presentation layer should only be responsible for presenting your data; etc. This principle aims to achieve the following goals:

        Short and concise objects: avoid the problem of a monolithic class design that is the software equivalent of a Swiss army knife
            Testability: if a method carries out multiple tasks then it’s difficult to write a test for it
            Readability: reading short and concise code is certainly easier than finding your way through some spaghetti code
            Easier maintenance
    
        SRP is strongly related to what is called Separation of Concerns (SoC). 
        SoC means dissecting a piece of software into distinct features that encapsulate unique behaviour and data 
        that can be used by other classes. Here the term ‘concern’ represents a feature or behaviour of a class. 
        Separating a programme into small and discrete ‘ingredients’ significantly increases code reuse, maintenance 
        and testability.

        Other related terms include the following:

            Cohesion: how strongly related and focused the various responsibilities of a module are
            Coupling: the degree to which each programme module relies on each one of the other modules

        In a good software design we are striving for a high level of cohesion and a low level of coupling. 
        A high level of coupling, also called tight coupling, usually means a lot of concrete dependency among the various elements of your software. 
        This leads to a situation where changing the design of one class leads to the need of changing other classes that are dependent 
        on the class you’ve just changed. Also, with tight coupling changing the design of one class can introduce errors in the dependent classes.
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
