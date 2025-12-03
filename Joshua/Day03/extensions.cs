namespace Day03;
static public class Day03Extensions
{
    extension(string s)
    {
        public List<int?> GetDigitList()
		{
            var result = new List<int?>();
            foreach (char c in s)
            {
                if (char.IsDigit(c)) {
                    result.Add((int)(c - '0'));
                } else {
                    result.Add(null);
                }
            }
            return result;
		}

        public List<string> SplitIntoChunks(int chunkSize)
        {
            if (chunkSize <= 0) throw new ArgumentOutOfRangeException(nameof(chunkSize));
            var result = new List<string>();
            for (int i = 0; i < s.Length; i += chunkSize)
            {
                int len = Math.Min(chunkSize, s.Length - i);
                result.Add(s.Substring(i, len));
            }
            return result;
        }        
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

    extension(int n)
	{
        public List<int> GetFactors()
        {
            var result = new List<int>();
            if (n == 0)            {
                // All integers divide 0; return empty or 0-specific set.
                // Here, return [0] to signal input special-case.
                result.Add(0);
                return result;
            }
            var absN = Math.Abs(n);
            var small = new List<int>();
            var large = new List<int>();
            for (int i = 1; i * i <= absN; i++)
            {
                if (absN % i == 0) {
                    small.Add(i);
                    int other = absN / i;
                    if (other != i) large.Add(other);
                }
            }
            small.Sort();
            large.Sort();
            result.AddRange(small);
            result.AddRange(large);
            return result;
        }		
	}

    extension(List<string> lst)
    {
    }
}
