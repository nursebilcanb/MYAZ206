using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public  class PostFixExample
    {
//        Stack.Stack<char> stack = new Stack<char>();
//        int i ;
//        string postFix = "";
//        string message = "(2*4)+3";

//    for (i = 0; i<; i++)
//{
//    if (char.IsDigit(message[i]))
//    {
//        postFix += message[i];
//    }
//    else
//    {
//        switch (message[i])
//        {
//            case '+':
//                stack.Push(message[i]);
//                break;
//            case '-':
//                stack.Push(message[i]);
//                break;
//            case '*':
//                stack.Push(message[i]);
//                break;
//            case '/':
//                stack.Push(message[i]);
//                break;


//                break;
//            default:
//                break;
//        }




////+* = stack

//var n = stack.Count;


//for (i = 0; i < n; i++)
//{
//    postFix += stack.Pop();

//}

//int c = 0;
//Console.WriteLine(postFix);
////243+*
//do
//{
//    for (i = 0; i < postFix.Length; i++)
//    {
//        if (char.IsDigit(postFix[i]))
//        {
//            stack.Push(postFix[i]);
//            i++;

//        }
//        else
//        {
//            var a = int.Parse(stack.Pop().ToString());
//            var b = int.Parse(stack.Pop().ToString());
//            switch (postFix[i])
//            {
//                case '+':
//                    c = a + b;
//                    stack.Push((char)c);
//                    break;

//                case '*':
//                    c = a * b;
//                    stack.Push((char)c);
//                    break;
//                case '-':
//                    c = a - b;
//                    stack.Push((char)c);
//                    break;
//                case '/':
//                    c = a / b;
//                    stack.Push((char)c);
//                    break;



//                default:
//                    break;
//            }
//            stack.Push(postFix[i]);


        }
    }


    i = i + 1;

} while (postFix.Length != 1);
var result = stack.Peek();
Console.WriteLine(result);
    }
}
