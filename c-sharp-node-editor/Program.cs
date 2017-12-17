using System;
using System.Collections;

namespace c_sharp_node_editor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteLineNode node = new ConsoleWriteLineNode();
            node.Parameter = "Hello World!";

            RawNode rawNode = new RawNode();
            rawNode.RawCode = "Console.Read();";

            StringNode stringNode = new StringNode();
            stringNode.StringValue = "This is another string";

            DoubleNode doubleNode = new DoubleNode();
            doubleNode.DoubleValue = 1000D;


            ConsoleWriteLineNode outputFromStringNode = new ConsoleWriteLineNode();
            outputFromStringNode.Parameter = stringNode;

            ConsoleWriteLineNode outputFromDoubleNode = new ConsoleWriteLineNode();
            outputFromDoubleNode.Parameter = doubleNode;

            CodeStack stack = new CodeStack();
            stack.Push(outputFromDoubleNode);
            stack.Push(outputFromStringNode);
            stack.Push(rawNode);
            stack.Push(new RawNode() { RawCode = "Console.WriteLine(\"This line and the next line is of raw code\");"});
            stack.Push(node);
            Console.WriteLine(stack.PopAllAndGetCodeString());
            


        }
    }
}
