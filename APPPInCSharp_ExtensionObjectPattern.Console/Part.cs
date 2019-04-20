using System.Collections;

namespace APPPInCSharp_ExtensionObjectPattern
{
    public abstract class Part
    {
        public void AddExtension(string extensionType, PartExtension extension)
        {
            extensions[extensionType] = extension;
        }

        public abstract string PartNumber { get; }

        public abstract string Description { get; }

        private Hashtable extensions = new Hashtable();

        public PartExtension GetExtension(string extensionType)
        {
            PartExtension pe = extensions[extensionType] as PartExtension;
            if (pe == null)
            {
                pe = new BadPartExtension();
            }
            return pe;
        }
    }
}