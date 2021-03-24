namespace Nifti.NET
{
    public struct Color
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;

        private Color(byte r, byte g, byte b, byte a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public static Color FromArgb(byte a, byte r, byte g, byte b)
        {
            return new Color(r, g, b, a);
        }

        public static Color FromRgb(byte r, byte g, byte b)
        {
            return new Color(r, g, b, 255);
        }
    }
}