using System.Text;

namespace APPPInCSharp_ExtensionObjectPattern
{
    public class CsvPiecePartExtension : CsvPartExtension
    {
        public CsvPiecePartExtension(PiecePart part)
        {
            piecePart = part;
        }

        private PiecePart piecePart;

        public string CsvText
        {
            get
            {
                StringBuilder sb = new StringBuilder("PiecePart,");
                sb.Append(piecePart.PartNumber);
                sb.Append(",");
                sb.Append(piecePart.Description);
                sb.Append(",");
                sb.Append(piecePart.Cost.ToString());

                return sb.ToString();
            }
        }
    }
}