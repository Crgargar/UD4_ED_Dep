using System;
class ArrayExample
{
    static void Main()
    {
        //define un array de caracteres llamados letters
        //se reserva memoria para los 10 elementos de tipo char
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = ""; //cadena vacia de name
        int[] a = new int[10];
        // blucle for que va mostrando las letras cada vez que da la vuelta.
        for (int i = 0; i < letters.Length; i++) //cuando entre aqui se suma uno a lo que ya tenemos
        {
            name += letters[i]; //punto de interrupcion
            a[i] = i + 1; //incrementa en uno
            SendMessage(name, a[i]); //es la variable name mas la letra que se le a incluido
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        //muestra por pantalla la palabra hello con la continuacion de la letra que va cogiendo en cada vuelta que da
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
