namespace APPPInCSharp_ExtensionObjectPattern
{
    public class PiecePart : Part
    {
        public PiecePart(string partNumber, string description, double cost)
        {
            this.partNumber = partNumber;
            this.description = description;
            this.cost = cost;
            AddExtension("CSV", new CsvPiecePartExtension(this));
            AddExtension("XML", new XmlPiecePartExtension(this));
        }

        private string partNumber;
        private string description;
        private double cost;

        public override string Description => description;

        public override string PartNumber => partNumber;

        public double Cost => cost;
    }
}