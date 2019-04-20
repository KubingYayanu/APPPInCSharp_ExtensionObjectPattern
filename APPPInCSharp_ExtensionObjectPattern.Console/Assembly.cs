using System.Collections.Generic;

namespace APPPInCSharp_ExtensionObjectPattern
{
    public class Assembly : Part
    {
        private IList<Part> parts = new List<Part>();
        private string partNumber;
        private string description;

        public Assembly(string partNumber, string description)
        {
            this.partNumber = partNumber;
            this.description = description;
            AddExtension("CSV", new CsvAssemblyExtension(this));
            AddExtension("XML", new XmlAssemblyExtension(this));
        }

        public Assembly()
        {
        }

        public override string Description => description;

        public override string PartNumber => partNumber;

        public IList<Part> Parts => parts;

        public void Add(Part part)
        {
            parts.Add(part);
        }
    }
}