using System.Text;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mittExempel();
            //marcusExempel();
        }

        static void mittExempel()
        {
            //1.Skapa två Dictionaries utanför din main metod men inne i klassen, en för arbeten och en för utbildningar.
            //2.Mata in dina tidigare jobb
            //3.Mata in dina tidigare utbildningar
            //4.Skriv ut listorna

            Dictionary<string, string> arbeten = new();
            arbeten.Add("2015-17", "Marina");
            arbeten.Add("2017-19", "Liseberg");
            arbeten.Add("2019-21", "Volvo");
            arbeten.Add("2021-22", "Mild");

            Dictionary<string, string> utbildningar = new ();
            utbildningar.Add("2015-17", "Skola");
            utbildningar.Add("2017-19", "Kurs");
            utbildningar.Add("2019-21", "Högskola");
            utbildningar.Add("2021-22", "LIA");

            foreach (var wtf in arbeten)
            {
                Console.WriteLine(wtf.Key + " " + wtf.Value);
            }

            Console.WriteLine();
            foreach (var wtf in utbildningar)
            {
                Console.WriteLine(wtf.Key + " " + wtf.Value);
            }
        }

        static void marcusExempel()
        {
            Dictionary<string, string> arbeten = new();
            arbeten.Add("2015-17", "Marina");
            arbeten.Add("2017-19", "Liseberg");
            arbeten.Add("2019-21", "Volvo");
            arbeten.Add("2021-22", "Mild");

            Dictionary<string, string> utbildningar = new();
            utbildningar.Add("2015-17", "Skola");
            utbildningar.Add("2017-19", "Kurs");
            utbildningar.Add("2019-21", "Högskola");
            utbildningar.Add("2021-22", "LIA");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Min CV");
            foreach (var employment in arbeten)
            {
                sb.AppendLine(employment.Key + " - " + employment.Value);
            }

            sb.AppendLine();
            sb.AppendLine("Utbildningar");
            foreach (var student in utbildningar)
            {
                sb.AppendLine(student.Key + " - " + student.Value);
            }

            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documents, "MinCV.txt");

            File.WriteAllText(filename, sb.ToString());
            Console.WriteLine(sb.ToString());
        }



    }
}