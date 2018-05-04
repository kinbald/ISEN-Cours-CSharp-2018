using System;

namespace Isen.Cs.Library.Lessons
{
    public class C_Arrays
    {
        public static void StaticRunner()
        {
            var c = new C_Arrays();
//            c.RunValuesAndRefs();

            c.RunArrays();
        }

        private void RunArrays()
        {
            // Tableaux primitifs de 1 dimension
            // initialisation
            int[] arrayOfIntegers = new int[3];
            // Affectation
            arrayOfIntegers[0] = 22;
            arrayOfIntegers[1] = 23;
            arrayOfIntegers[2] = 24;
            Console.Write("[\t");
            foreach (var integer in arrayOfIntegers) Console.Write($"{integer}\t");
            Console.WriteLine("]");
            // Syntaxe littérale
            string[] literalArray = new string[] {"Bonjour", "tout", "le", "monde"};
            Console.Write("[\t");
            foreach (var s in literalArray)
            {
                Console.Write($"{s}\t");
            }
            Console.WriteLine("]");
            
            // Tableaux à 2 dimensions
            var array2D = new string[,]
            {
                {"A1", "B1", "C1"},
                {"A2", "B2", "C2"},
                {"A3", "B3", "C3"},
                {"A4", "B4", "C4"}
            };


            for (var xIndex = 0; xIndex < array2D.GetLength(0); xIndex++)
            {
                Console.Write("[\t");
                for (var yIndex = 0; yIndex < array2D.GetLength(1); yIndex++)
                {
                    Console.Write($"{array2D[xIndex,yIndex]}\t");
                }
                Console.WriteLine("]");
            }
            
            // Tableaux imbriques
            string[][] nestedArrays = new string[][]
            {
                new string[] {"A1","B1", "C1"},
                new string[] {"A2", "B2"}
            };
            for (var xIndex = 0; xIndex < nestedArrays.Length; xIndex++)
            {
                Console.Write("[\t");
                for (var yIndex = 0; yIndex < nestedArrays[xIndex].Length; yIndex++)
                {
                    Console.Write($"{nestedArrays[xIndex][yIndex]}\t");
                }
                Console.WriteLine("]");
            }
        }

        #region RunValuesAndRefs

        private void RunValuesAndRefs()
        {
            // Types Valeurs (ValueTypes) et Types référence
            int four = 4;
            Console.WriteLine($"{nameof(four)}={four} (expected : 4)");
            AddOneByValue(four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 4)");
            four = AddOneAsPureMethod(four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 5)");
            AddOneByRef(ref four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 6)");
            TryParseInt("42", out int parsed);
            Console.WriteLine($"{nameof(parsed)}={parsed} (expected : 42)");

            // String : passage par valeur ou ref ? réponse : par valeur
            // / ! \ string est un type référence, mais passé par valeur
            var lowerString = "hello";
            Console.WriteLine($"{nameof(lowerString)}={lowerString} (expected : hello)");
            UpperCaseMyString(lowerString);
            Console.WriteLine($"{nameof(lowerString)}={lowerString} (expected : hello)");
            UpperCaseMyStringByRef(ref lowerString);
            Console.WriteLine($"{nameof(lowerString)}={lowerString} (expected : HELLO)");
        }

        public void UpperCaseMyString(string input)
        {
            input = input.ToUpper();
        }

        public void UpperCaseMyStringByRef(ref string input)
        {
            input = input.ToUpper();
        }

        // Passage par copie. a ne ressort jamais de la méthode et n'est pas modifiée
        // en dehors du scope de la méthode
        public void AddOneByValue(int a)
        {
            a++;
        }

        // C#6 : Expression body
        public int AddOneAsPureMethod(int a)
        {
            return ++a;
        }

        // Passage par référence : out
        public void AddOneByRef(ref int a)
        {
            a++;
        }

        // Parser vers result, qui n'est pas init
        // Donc c'est du out et pas du ref
        public bool TryParseInt(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                result = int.MinValue;
                return false;
            }
        }

        #endregion
    }
}