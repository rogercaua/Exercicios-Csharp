/* ======================================================================
        DESAFIO 2: MONITORAMENTO DE SERVIDORES (LISTAS E LOOPS)
        ======================================================================
        
        REQUISITOS:
        1. Crie uma classe chamada 'Servidor' fora da classe Program.
        2. Adicione as propriedades públicas 'Hostname' (string), 'SistemaOperacional' (string) 
           e 'EstaOnline' (bool). Fique à vontade para usar encapsulamento se quiser praticar!
        3. Crie um construtor na classe 'Servidor' para receber e atribuir esses 3 valores.
        4. Aqui no método Main, crie uma Lista de servidores. 
           (Dica: List<Servidor> frota = new List<Servidor>();)
        5. Adicione pelo menos 3 servidores diferentes à lista (ex: um Red Hat, um Ubuntu, etc.). 
           Deixe pelo menos um deles offline (EstaOnline = false).
        6. Use um loop (foreach ou for) para percorrer a lista.
        7. Dentro do loop, use um 'if' para imprimir no console APENAS o Hostname 
           e o Sistema Operacional dos servidores que estão ONLINE.
        ======================================================================
*/
using System;
using System.Collections.Generic;

class Server
{
   public string HostName{get; set;}
   public string OperationalSystem{get; set;}

   public bool IsOnline{get; set;}

   public Server(string hostName, string operationalSystem, bool isOnline){
      HostName = hostName;
      OperationalSystem = operationalSystem;
      IsOnline = isOnline;
   }

}

class Program
{
   static void Main()
   {
      List<Server> servers = new List<Server>();

      servers.Add(new Server("joao", "Ubuntu", true));

      servers.Add(new Server("pedro", "redhat", true));

      servers.Add(new Server("kali", "Kali Linux", false));


      foreach (var i in servers)
      {
         if (i.IsOnline)
         {
            Console.WriteLine($"Hostname:{i.HostName} | OS:{i.OperationalSystem}");
         }
      }
   }
}