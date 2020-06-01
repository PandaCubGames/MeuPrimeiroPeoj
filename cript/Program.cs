using System;



namespace cript
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            string decodificado = "";
            
            Program classe = new Program();
            Console.WriteLine("Escreva sua mensagem");
            palavra = Console.ReadLine().ToLower();

            for(int i = 0; i<palavra.Length; i++)
            {
                int ASCII = (int)palavra[i];
                if (ASCII < 120 && ASCII > 96)
                {

                    ASCII += 3;
                    decodificado += char.ConvertFromUtf32(ASCII);
                } else if (ASCII < 97)
                {
                    decodificado += char.ConvertFromUtf32(ASCII);
                } else if(ASCII == 120){
                    ASCII = 97;
                    decodificado += char.ConvertFromUtf32(ASCII);
                }
                else if(ASCII == 121){
                    ASCII = 98;
                    decodificado += char.ConvertFromUtf32(ASCII);
                }
                else if(ASCII == 122)
                {
                    ASCII = 99;
                    decodificado += char.ConvertFromUtf32(ASCII);
                }
                    
            }
            if(palavra == null)
            {
                Console.WriteLine("ArgumentNullException");
            }
            Console.WriteLine(decodificado);

        }

        public  string Crypt(string mensage)
        {
 
            return ("hello");
        }

        public string DeCrypt(string mensage)
        {
            return ("hello");

        }
    }
}
