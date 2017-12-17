namespace c_sharp_node_editor
{
    internal class DoubleNode:INode
    {
        public DoubleNode()
        {
        }

        public double DoubleValue { get; internal set; }

        public string GetNodeOutput()
        {
            return DoubleValue + "D";
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