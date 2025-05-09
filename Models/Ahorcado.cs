public class Ahorcado {
    public string Palabra{get; private set;}
    public List<char> LetrasArriesgadas{get; private set;}
    public List<char> LetrasPalabra{get; private set;}
    public string PalabraArriesgada{get; private set;}

    public Ahorcado(string palabra, List<char> letraArriesgada, string palabraArriesgada) {
        Palabra = palabra;
        LetrasArriesgadas = letraArriesgada;
        PalabraArriesgada = palabraArriesgada;
    }
    public void PalabraElegida() {
        int i = 0;
        foreach (Char letra in Palabra) {
            LetrasPalabra[i] = letra;
            i++;
        }
    }
    public char ArriesgarLetra(char LetraArriesgada) {
        int i = 0;
        foreach (Char letra in LetrasPalabra) {
            if (LetraArriesgada == letra){
                LetrasPalabra[i] = LetraArriesgada;
            }
            i++;
        }
    }
}