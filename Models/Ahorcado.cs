public class Ahorcado {
    public string Palabra{get; private set;}
    public List<char> LetrasArriesgadas{get; private set;}
    public List<char> LetrasPalabra{get; private set;}
    public string PalabraArriesgada{get; private set;}
    public char LetraArriesgada{get; private set;}

    public Ahorcado() {
        Palabra = RandomPalabra();
        PalabraArriesgada = "";
        LetrasPalabra = new List<char> ();
        LetrasArriesgadas = new List<char> ();
    }
    public string RandomPalabra() {
        //generar random
        return "palabra";
    }
    // hacer la palabra apta ahorcado
    public List <char> HacerAhorcado() {
        int i = 0;
        foreach (Char letra in Palabra) {
            LetrasPalabra[i] = '_';
            i++;
        }
        return LetrasPalabra;
    }
    // para ver que letras arriesgo
    public void ArriesgarLetra(char LetraUsuario) {
        foreach (Char letra in Palabra) { 
            if (LetraUsuario == letra){
                LetrasPalabra[LetrasPalabra.IndexOf(LetraUsuario)] = LetraUsuario;
            }
            LetrasArriesgadas.Add(LetraUsuario);
        }
    }
    public bool ArriesgarPalabra(string Arriesgada) {
        bool ganaste = false;
        if (Arriesgada == Palabra) {
            ganaste = true;
        }
        return ganaste;
    }
}