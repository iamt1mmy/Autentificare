namespace Autentificare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "iamtimmy";
            string parola = "lamultiani2024";
            bool ok_username = false;
            bool ok_parola = false;

            while(ok_username == false && ok_parola == false
                || ok_username == true && ok_parola == false
                || ok_username == false && ok_parola == true)
            {
                Console.WriteLine("Introduceti username");
                string username_t = Console.ReadLine();
                ok_username = string.Equals(username, username_t);
                Console.WriteLine("Introduceti parola");
                string parola_t = Console.ReadLine();
                ok_parola = string.Equals(parola, parola_t);
                if (ok_username == true && ok_parola == true)
                {
                    Console.WriteLine("Bine ai venit, " + username);
                }
                else
                {
                    Console.WriteLine("Username sau parola incorecta, mai incearca!");
                }
            }
        }
    }
}