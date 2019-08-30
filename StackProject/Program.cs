using System;
using System.Collections.Generic;
namespace StackProject {
    class Program {
        static Stack<long> stack = new Stack<long>();
        static bool Calculate() {
            Console.Write("Enter an op or nbr: ");
            var response = Console.ReadLine();
            switch(response) {
                case "+": {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 + p1;
                    stack.Push(result);
                    break;
                }
                case "-": {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 - p1;
                    stack.Push(result);
                    break;
                }
                case "*": {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 * p1;
                    stack.Push(result);
                    break;
                }
                case "/": {
                    var p1 = stack.Pop();
                    var p2 = stack.Pop();
                    var result = p2 / p1;
                    stack.Push(result);
                    break;
                }
                case "x": {
                    var answer = stack.Pop();
                    Console.WriteLine($"Answer is {answer}");
                    break;
                }
                case "X": {
                    return false;
                }
                default: {
                    var number = long.Parse(response); 
                    stack.Push(number);
                    break;
                }
            }
            return true;
        }

        static void Main(string[] args) {
            var runAgain = true;
            while (runAgain) {
              runAgain =   Calculate();
            }
        }
        static void Test() { 


        }
    }
}
