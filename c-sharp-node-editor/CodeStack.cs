using System.Collections;
using System.Text;

namespace c_sharp_node_editor
{
    internal class CodeStack :Stack
    {
        public string PopAllAndGetCodeString()
        {
            StringBuilder stringBuilder = new StringBuilder(); 
            var node = (INode)this.Pop();
            while (node != null)
            {
                stringBuilder.AppendLine(node.GetNodeOutput());
                try
                {
                    node = (INode)this.Pop();
                }
                catch
                {
                    node = null;
                }
                
            }
            return stringBuilder.ToString();
        }
    }
}