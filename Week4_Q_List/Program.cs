namespace Week4_Q_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancie une liste de chaînes de caractères
            List<string> listChar = new List<string>();

            // Insères-y trois chaînes de caractères
            listChar.Add("bonjour");
            listChar.Add("à");
            listChar.Add("tous");
            listChar.ForEach(x => Console.WriteLine(x));

            // Supprime la première avec RemoveAt([index])
            listChar.RemoveAt(0);
            // Supprime la troisième avec Remove([valeur])
            listChar.RemoveAt(1);
            // Modifie la deuxième en utilisant son indice.
            listChar[0] = "Bye !";
            listChar.ForEach(x => Console.WriteLine(x));

        }
    }
}
