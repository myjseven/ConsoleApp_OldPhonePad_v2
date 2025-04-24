using ConsoleApp_OldPhonePad_v2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_OldPhonePad_v2.Classes
{
    public class HelperClass : IHelperClass
    {
        public HelperClass()
        {
        }

        public String OldPhonePad(string input)
        {
            var numberKeyMap = new Dictionary<int, string[]>
            {
                { 1, new[] { "&", "'", "C" } },
                { 2, new[] { "A", "B", "C" } },
                { 3, new[] { "D", "E", "F" } },
                { 4, new[] { "G", "H", "I" } },
                { 5, new[] { "J", "K", "L" } },
                { 6, new[] { "M", "N", "O" } },
                { 7, new[] { "P", "Q", "R", "S" } },
                { 8, new[] { "T", "U", "V" } },
                { 9, new[] { "W", "X", "Y", "Z" } }
            };

            char? currentKey = null;
            int countKey = 0;
            List<string> pressedKey = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                char keyInput = input[i];

                if (keyInput == ' ' ||
                    string.IsNullOrWhiteSpace(keyInput.ToString()) ||
                    keyInput == '#' ||
                    keyInput == '*')
                {
                    if (keyInput == '*')
                    {
                        currentKey = null;
                        countKey = 0;
                    }

                    if (int.TryParse(currentKey.ToString(), out _))
                    {
                        AddCharFromMappings(numberKeyMap, int.Parse(currentKey.ToString()), countKey, pressedKey);
                    }

                    currentKey = null;
                    countKey = 0;
                    continue;
                }

                if (keyInput == currentKey)
                {
                    countKey++;
                    if (currentKey == '7' || currentKey == '9')
                    {
                        if (countKey > 4) countKey = 1;
                    }
                    else
                    {
                        if (countKey > 3) countKey = 1;
                    }
                }
                else
                {
                    if (currentKey != null && int.TryParse(currentKey.ToString(), out _))
                    {
                        AddCharFromMappings(numberKeyMap, int.Parse(currentKey.ToString()), countKey, pressedKey);
                    }
                    currentKey = keyInput;
                    countKey = 1;
                }
            }

            return string.Join("", pressedKey.ToArray());
        }

        private void AddCharFromMappings(Dictionary<int, string[]> map, int key, int counter, List<string> pressed)
        {
            if (map.TryGetValue(key, out var values) && counter >= 1 && counter <= values.Length)
            {
                pressed.Add(values[counter - 1]);
            }
        }

    }
}
