using System.Text;

namespace APPPInCSharp_ExtensionObjectPattern
{
    public class CsvAssemblyExtension : CsvPartExtension
    {
        public CsvAssemblyExtension(Assembly assembly)
        {
            this.assembly = assembly;
        }

        private Assembly assembly;

        public string CsvText
        {
            get
            {
                StringBuilder sb = new StringBuilder("Assembly,");
                sb.Append(assembly.PartNumber);
                sb.Append(",");
                sb.Append(assembly.Description);

                foreach (var part in assembly.Parts)
                {
                    CsvPartExtension cpe = part.GetExtension("CSV") as CsvPartExtension;
                    sb.Append(",{");
                    sb.Append(cpe.CsvText);
                    sb.Append("}");
                }

                return sb.ToString();
            }
        }
    }
}