//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TesteRecursaoT1
//{
//    public static class Buscar
//    {
//        public static string Executar(Node n)
//        {
//             String aux="";

//             try
//             {
//                 if (n.Info == null)
//                     return "";
//             }

//             catch
//             {

//                 return "";
//             }

//            if (n.Info!=null && n.Prior==null && n.Next==null)
//                return (n.Info).ToString();


    
//            else
//            {
                
               
//                aux = n.Info.ToString();


//                try
//                {
//                    n.Next.Next.Next = null;
//                }
//                catch(Exception)
//                {

//                }


//                try
//                {
                 
//                    aux = aux + (Executar(n.Next.Next.Prior));
//                    n.Next.Next.Prior = null;
//                }
//                catch (Exception)
//                {

//                }

                

//                aux=aux+(Executar(n.Next.Next));
//                n.Next.Next = null;



//                aux = aux + (Executar(n.Next.Prior));
//                n.Next.Prior = null;


//                aux = aux + (Executar(n.Prior.Next));
//                n.Prior.Next = null;


//                aux = aux + (Executar(n.Prior.Prior));
//                n.Prior.Prior = null;

//                //Teste 1 e 2
//                aux = aux + (Executar(n.Prior));
//                aux = aux + (Executar(n.Next));


            
    

             
      
            
            
//            } 
        
            
//            char letra;
//            String nova = "";
//            int s;
//            for (letra = 'A'; letra <= 'Z'; letra++)
//            {
//                for (s = 0; s < aux.Length; s++)
//                {
//                    if (aux[s] == letra)
//                        nova = nova + aux[s];
//                }
//            }


//            return nova;
//        }

//        public static String Netos(Node netos)
//        {

//            if (netos.Info != null && netos.Next == null && netos.Prior == null)
//                return netos.Info.ToString();

//            else
//                return "";
//        }

      
//    }
//}







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRecursaoT1
{
    public static class Buscar
    {
        public static string Executar(Node n){
        //{
            string palavra = string.Empty;
            List<string> word = new List<string>();

            n.marca=true;

            if (n.Info != null)
                word.Add(n.Info.ToString());


            if (n.Prior != null && !n.Prior.marca)
                word.Add(Executar(n.Prior));


            if (n.Next != null && !n.Next.marca)
                word.Add(Executar(n.Next));

            

         
           // palavra.OrderBy(x => x);

           // palavra.Reverse();

            word.Sort();


            foreach (string c in word)
                palavra += c;

            return palavra;

          // return null;


        }
    }
}


