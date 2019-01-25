using System;
using StacksAndQueues.Classes;


namespace MultiBracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MultiBracketValidation("{}");
            MultiBracketValidation("{}(){}");
            MultiBracketValidation("()[[Extra Characters]]");
            MultiBracketValidation("(){}[[]]");
            MultiBracketValidation("{}{Code}[Fellows](())");
            MultiBracketValidation("[({}]");
            MultiBracketValidation("(](");
            MultiBracketValidation("{(})");
            Console.ReadLine();
        }

        /// <summary>
        /// Checks a string input to make sure brackets within string are balanced.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack validationStack = new Stack();
            bool validation = true;

            char[] charParse = input.ToCharArray();
            int counter = 0;

            while (validation == true)
            {
                if (counter > charParse.Length - 1)
                {
                    Console.WriteLine($"Is {input} balanced? {validation}");
                    return validation;
                }
                char targetChar = charParse[counter];
                switch (targetChar)
                {
                    case '(':
                        validationStack.Push(')');
                        counter++;
                        break;
                    case '[':
                        validationStack.Push(']');
                        counter++;
                        break;
                    case '{':
                        validationStack.Push('}');
                        counter++;
                        break;
                    case ')':
                        validation = CharValidate(targetChar);
                        counter++;
                        break;
                    case ']':
                        validation = CharValidate(targetChar);
                        counter++;
                        break;
                    case '}':
                        validation = CharValidate(targetChar);
                        counter++;
                        break;
                    default:
                        counter++;
                        break;
                }
            }
            Console.WriteLine($"Is {input} balanced? {validation}");
            return validation;

            //Helper method to validate targetChar
            bool CharValidate(char targetChar)
            {
                char compareChar = validationStack.Pop();
                    if(compareChar != targetChar)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
