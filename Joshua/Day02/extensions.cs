namespace Day02;
static public class Day02Extensions
{
    extension(string s)
    {
        public List<string> SplitCSV()
        {
            return [.. s.Split(',')];
        }

        public List<string> SplitDash()
        {
            return [.. s.Split('-')];
        }

        public (string, string) SplitStringInHalf()
        {
            var strLength = s.Length;
            if (strLength <= 1) { return (s, ""); }
            int fLength = strLength / 2;
            return (s.Substring(0, fLength), s.Substring(fLength));
        }

        public int ToInt()
        {
            return int.Parse(s);
        }
        public Int64 ToInt64()
        {
            return Int64.Parse(s);
        }

    }

    extension(List<string> lst)
    {
    }
}
