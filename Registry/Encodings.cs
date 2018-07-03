using System.Text;

namespace Registry
{
    public static class Encodings
    {
        public static Encoding Encoding1252 { get; } = CodePagesEncodingProvider.Instance.GetEncoding(1252);
    }
}
