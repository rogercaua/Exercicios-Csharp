/*
            DESAFIO 1: CONTROLE DE ACESSO SIMPLES
            
            Modele um sistema básico de verificação de permissões.
            
            REQUISITOS:
            1. Crie uma classe chamada 'Usuario'.
            2. Adicione as propriedades 'Nome' (string) e 'NivelAcesso' (int) à classe.
            3. O 'NivelAcesso' deve variar de 1 (usuário comum) a 3 (administrador).
            4. Crie um método dentro da classe chamado 'VerificarPermissao(int nivelExigido)'.
               Este método deve retornar 'true' se o usuário tiver um nível igual ou 
               maior que o exigido, e 'false' caso contrário.
            5. Aqui no método Main, instancie pelo menos dois usuários com níveis diferentes.
            6. Imprima no console se eles têm permissão para acessar um recurso que 
               exige NÍVEL 2.
*/

using System;

class User
{
    private int _acessLevel;
    public string Name {get; set;}
    public int AcessLevel
    {
        get {return _acessLevel;}
        set
        {
            if (value < 1 || value > 3)
            {
                throw new ArgumentException("Acess Level must be 1 to 3");
            }
            _acessLevel = value;
        }
    }

    public User(int acessLevel, string name)
    {
        _acessLevel = acessLevel;
        Name = name;
    }
    
    public bool VerifyPermission(int requiredLevel)
    {
        if (_acessLevel < requiredLevel)
        {
            Console.WriteLine("Low Permission level: acess denied.");
            return false;
        }
        Console.WriteLine("High Permission level: Acess Permitted.");
        return true;
    }

}


class Program
{
    static void Main()
    {
        var u1 = new User(2, "joao");
        var u2 = new User(3, "endmin");

        u1.VerifyPermission(3);
        u2.VerifyPermission(3);
    }
}