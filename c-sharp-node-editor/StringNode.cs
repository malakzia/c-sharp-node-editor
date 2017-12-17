namespace c_sharp_node_editor
{
    internal class StringNode:INode
    {
        public StringNode()
        {
        }

        public string StringValue { get; internal set; }

        public string GetNodeOutput()
        {
            return "\"" + StringValue + "\"";
        }

        public bool IsMethod()
        {
            return false;
        }

        public bool IsParameter()
        {
            return true;
        }
    }
}