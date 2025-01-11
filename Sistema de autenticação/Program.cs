using System;
using System.Collections.Generic;

public class SistemaAutenticacao
{
    // Lista de usuários e senhas fictícias para demonstração.
    private static Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        { "usuario1", "senha1" },
        { "usuario2", "senha2" },
        { "usuario3", "senha3" }
    };

    public static bool Autenticar(string usuario, string senha)
    {
        // Verifica se o usuário existe e se a senha está correta.
        if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
        {
            return true;
        }
        return false;
    }

    public static void Main(string[] args)
    {
        // Solicita as credenciais do usuário.
        Console.WriteLine("Digite o nome de usuário:");
        string usuario = Console.ReadLine();

        Console.WriteLine("Digite a senha:");
        string senha = Console.ReadLine();

        // Verifica se as credenciais estão corretas.
        if (Autenticar(usuario, senha))
        {
            Console.WriteLine("Autenticação bem-sucedida!");
        }
        else
        {
            Console.WriteLine("Nome de usuário ou senha incorretos.");
        }
    }
}
