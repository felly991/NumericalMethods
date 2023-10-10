//x^2 - sin(x) = 0
using MVkyrsachDD.Method;
using MVkyrsachDD.Methods;

new NewtonMethod(0.0001, 1, 15).Print();
Console.WriteLine("____________________________");
new SimpleIterMethod(0.0001, 3).Print();
Console.WriteLine("____________________________");
new HordMethod(0.0001, 1, 15).Print();
Console.WriteLine("____________________________");
new HalfDivided(0.0001, 0.0001, 5).Print();