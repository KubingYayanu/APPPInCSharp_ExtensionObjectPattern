using System.Xml;

namespace APPPInCSharp_ExtensionObjectPattern
{
    public class XmlAssemblyExtension : XmlPartExtension
    {
        public XmlAssemblyExtension(Assembly assembly)
        {
            this.assembly = assembly;
        }

        private Assembly assembly;

        public override XmlElement XmlElement
        {
            get
            {
                XmlElement e = NewElement("Assembly");
                e.AppendChild(NewTextElement("PartNumber", assembly.PartNumber));
                e.AppendChild(NewTextElement("Description", assembly.Description));

                XmlElement parts = NewElement("Parts");
                foreach (var part in assembly.Parts)
                {
                    XmlPartExtension xpe = part.GetExtension("XML") as XmlPartExtension;
                    parts.AppendChild(xpe.XmlElement);
                }
                e.AppendChild(parts);

                return e;
            }
        }
    }
}