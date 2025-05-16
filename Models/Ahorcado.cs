using System.Runtime.CompilerServices;

public static class Ahorcado
{
    public static string Palabra { get; private set; }
    public static List<char> LetrasArriesgadas { get; private set; }
    public static List<char> LetrasPalabra { get; private set; }
    public static string PalabraArriesgada { get; private set; }
    public static char LetraArriesgada { get; private set; }
    public static List<char> ListaAhorcado { get; private set; }
    static Ahorcado()
    {
        ReiniciarJuego();
    }

    public static void ReiniciarJuego()
    {
        Palabra = RandomPalabra();
        PalabraArriesgada = "";
        LetrasPalabra = new List<char>();
        LetrasArriesgadas = new List<char>();
        ListaAhorcado = new List<char>();

        foreach (char letra in Palabra)
        {
            LetrasPalabra.Add(letra);
            ListaAhorcado.Add('_');
        }
    }
    public static string RandomPalabra() //no lo hice yo, no termino de entender el random
    {
        var palabras = PalabrasRandom();
        Random rand = new Random();
        int indice = rand.Next(palabras.Count);
        return palabras[indice];
    }
    public static List<string> PalabrasRandom()
    {   
        return new List<string>
        {
        "programacion",
        "ahorcado",
        "computadora",
        "teclado",
        "pantalla",
        "algoritmo",
        "variable",
        "codigo",
        "software",
        "debug"
        };
    }

    // lista letras
    public static List<char> ListaLetras()
    {
        return LetrasPalabra;
    }
    // hacer la palabra apta ahorcado
    public static List<char> ListaNuevaAhorcado()
    {
        return ListaAhorcado;
    }
    // para ver que letras arriesgo y si coincide con alguna de las letras de la palabra
    public static List<char> ArriesgarLetra(char LetraUsuario)
    {
        LetrasPalabra = ListaLetras();
        if (ListaAhorcado == null || ListaAhorcado.Count != Palabra.Length)
        {
            ReiniciarJuego();
        }
        for (int i = 0; i < Palabra.Length; i++)
        {
            if (LetraUsuario == Palabra[i])
            {
                ListaAhorcado[i] = LetraUsuario;
            }
            if (!LetrasArriesgadas.Contains(LetraUsuario))
            {
                LetrasArriesgadas.Add(LetraUsuario);
            }
        }
        return ListaAhorcado;
    }
    public static bool ArriesgarPalabra(string Arriesgada)
    {
        bool ganaste = false;
        if (Arriesgada == Palabra)
        {
            ganaste = true;
        }
        return ganaste;
    }
    public static List<char> DevolverArriesgadas()
    {
        return LetrasArriesgadas;
    }
    public static bool ComprobarGanar()
    {
        int charPalabra = 0;
        int letrasIguales = 0;
        bool ganaste = false;
        foreach (char letra in ListaAhorcado)
        {
            if (letra == Palabra[charPalabra])
            {
                letrasIguales++;
            }
            charPalabra++;
        }
        if (letrasIguales == Palabra.Length)
        {
            ganaste = true;
        }
        return ganaste;
    }
}