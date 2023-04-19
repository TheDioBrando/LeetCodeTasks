namespace LeetCodeTasks.Easy
{
    public class SolutionIsIsomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var sToInt = ConvertCharactersToIntInOrder(s);
            var tToInt = ConvertCharactersToIntInOrder(t);
            for (var i = 0; i < sToInt.Length; i++)
            {
                if (sToInt[i] != tToInt[i])
                    return false;
            }
            return true;
        }

        private int[] ConvertCharactersToIntInOrder(string str)
        {
            int characterInt = 0;
            var strToInt = new int[str.Length];
            var visitedCharacters = new Dictionary<char, int>();

            for (var i = 0; i < str.Length; i++)
            {
                if (!visitedCharacters.ContainsKey(str[i]))
                {
                    visitedCharacters.Add(str[i], characterInt);
                    strToInt[i] = characterInt;
                    characterInt++;
                }
                else
                    strToInt[i] = visitedCharacters[str[i]];
            }

            return strToInt;
        }
    }
}
