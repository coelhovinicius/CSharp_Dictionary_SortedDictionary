/* DICTIONARY E SORTEDDICTIONARY - Mapa de pares Chave/Valor (tambem chamado de Map, em outras linguagens de programacao).
 * 
 *  - Dictionary<TKey, TValue> (propriedades similares ao HashSet):
 *      > Armazenamento em Tabela Hash;
 *      > Nao admite repeticoes do objeto chave;
 *      > Elementos indexados pelo objeto chave (nao possuem posicao na memoria);
 *      > Acesso, insercao e remocao de elementos de maneira extremamente rapida - O(1);
 *      > Armazenamento dos elementos de forma NAO ordenada;
 *      > Usado em Cookies, Local Storage (ex.: HTML5) e qualquer modelo chave-valor. 
 *      
 *  - SortedDictionary (propriedades similares ao SortedSet):
 *      > Armazenamento em Arvore;
 *      > Rapido: insercao, remocao e busca O(log(n));
 *      > Armazenamento dos elementos de forma ordenada, conforme implementacao IComparer<T>.
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;

namespace Aula213_Dictionary_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementacao de Cookies
            // Dicionario com Chave tipo String e Valor tipo String
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "coelhovinicius"; // "cookies" na chave string "user" recebe o valor "vinicius"
            cookies["email"] = "coelhovinicius@yahoo.com.br";
            cookies["phone"] = "981982433";
            cookies["phone"] = "994359534"; // Sobrescreve o valor atribuido a "phone" na linha acima

            Console.WriteLine(cookies["user"]); // Imprime o valor de "cookies" na chave "user"
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]); // Imprime o ultimo valor atribuido a "cookies" na chave "phone"

            cookies.Remove("email"); // Remove o valor da chave "email" em "cookies" (da erro se tentar exibir o valor)

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Email key does not exist");
            }

            Console.WriteLine("Size: " + cookies.Count); // Faz a contagem das chaves de "cookies"

            Console.WriteLine("ALL COOKIES:");
            foreach (/*KeyValuePair<string, string>*/ var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value); // ".Key" acessa a chave e ".Value" acessa o valor
            }
        }
    }
}
