public class Abecedario
{
    private List<char> letras;

    public Abecedario()
    {
        letras = new List<char>();
    }

    // Llenar la lista con las 26 letras del abecedario (A-Z)
    public void Llenar()
    {
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            letras.Add(letra);
        }
    }

    // Eliminar letras que están en posiciones múltiplos de 3
    public void EliminarMultiplosDeTres()
    {
        // Crear nueva lista con solo las letras que NO están en posiciones múltiplos de 3
        List<char> filtradas = new List<char>();

        for (int i = 0; i < letras.Count; i++)
        {
            int posicion = i + 1; // Convertir a base 1
            if (posicion % 3 != 0)
            {
                filtradas.Add(letras[i]);
            }
        }

        letras = filtradas;
    }

    public void Mostrar()
    {
        Console.WriteLine("Abecedario sin letras en posiciones múltiplos de 3:");

        foreach (char letra in letras)
        {
            Console.Write(letra + " ");
        }

        Console.WriteLine();
    }
}

class ProgramaAbecedario
{
    static void Main()
    {
        Abecedario abecedario = new Abecedario();

        abecedario.Llenar();
        abecedario.EliminarMultiplosDeTres();
        abecedario.Mostrar();
    }
}
