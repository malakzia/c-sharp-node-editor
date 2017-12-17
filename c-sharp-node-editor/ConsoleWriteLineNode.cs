namespace c_sharp_node_editor
{
    internal class ConsoleWriteLineNode : INode
    {
        public ConsoleWriteLineNode()
        {
        }

        public INode NextNode { get; set; } = null;
        public INode PreviousNode { get; set; } = null;

        public object Parameter { get; set; }


        public string GetNodeOutput()
        {
            try
            {

                var nodeParameter = (INode)Parameter;
                if (nodeParameter != null)
                {
                    if (nodeParameter.IsParameter())
                    {
                        return "Console.WriteLine(" + nodeParameter.GetNodeOutput() + ");";
                    }
                    else
                    {
                        return "Console.WriteLine(\"" + nodeParameter.GetNodeOutput() + "\");";

                    }
                }
                else
                {
                    return "Console.WriteLine(\"" + nodeParameter.GetNodeOutput() + "\");";

                }
            }
            catch (System.Exception)
            {
                return "Console.WriteLine(\"" + Parameter + "\");";

            }
        }

        public bool IsMethod()
        {
            return true;
        }

        public bool IsParameter()
        {
            return false;
        }
    }
}