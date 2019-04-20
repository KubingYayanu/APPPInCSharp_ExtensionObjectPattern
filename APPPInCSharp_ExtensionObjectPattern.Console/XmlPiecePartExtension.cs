using System.Xml;

namespace APPPInCSharp_ExtensionObjectPattern
{
    public class XmlPiecePartExtension : XmlPartExtension
    {
        public XmlPiecePartExtension(PiecePart part)
        {
            piecePart = part;
        }

        private PiecePart piecePart;

        public override XmlElement XmlElement
        {
            get
            {
                XmlElement e = NewElement("PiecePart");
                e.AppendChild(NewTextElement("PartNumber", piecePart.PartNumber));
                e.AppendChild(NewTextElement("Description", piecePart.Description));
                e.AppendChild(NewTextElement("Cost", piecePart.Cost.ToString()));

                return e;
            }
        }
    }
}