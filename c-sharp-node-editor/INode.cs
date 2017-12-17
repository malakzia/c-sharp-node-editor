namespace c_sharp_node_editor
{
    internal interface INode
    {
        string GetNodeOutput();
        bool IsMethod();
        bool IsParameter();
    }
}