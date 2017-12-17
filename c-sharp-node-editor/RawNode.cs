namespace c_sharp_node_editor
{
    internal class RawNode : INode
    {
        public RawNode()
        {
        }
        public string RawCode { get; set; }

        public string GetNodeOutput()
        {
            return RawCode;
        }

        public bool IsMethod()
        {
            return false;
        }

        public bool IsParameter()
        {
            return false;
        }
    }
}