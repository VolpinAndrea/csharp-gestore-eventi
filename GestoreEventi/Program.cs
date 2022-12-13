// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using GestoreEventi.CustomExeption;

try
{
    //   Evento nuovo = new Evento("Danza", "23/12/2022", 30);
    //   Console.WriteLine(nuovo.ToString());

    Evento eventoUno = CreaEvento();

    Console.WriteLine("Quanti posti vuoi prenotare?");
    int prenota = int.Parse(Console.ReadLine());
    eventoUno.PrenotaPosti(prenota);

    Console.WriteLine(eventoUno.ToString());
    Console.WriteLine(eventoUno.StampaInfo());

    while (true)
    {
        Console.WriteLine("Vuoi disdire dei posti? (si-no)");
        string controllo = Console.ReadLine().ToUpper();
        if (controllo == "SI")
        {
            Console.WriteLine("Quanti posti vuoi disdire?");
            int x = int.Parse(Console.ReadLine());
            eventoUno.DisdiciPosti(x);
            Console.WriteLine(eventoUno.StampaInfo());
        }
        else if(controllo == "NO")
        {
            Console.WriteLine("Grazie!\nArrivederci");
            break;

        }
        else
        {
            Console.WriteLine("Hai inserito una risposta non valida\nRiprova!");
        }

    }



}
catch (DataPassata e1)
{
    Console.WriteLine(e1.Message);
   // Console.WriteLine("La data inserita è già passata");
}
catch (ErrorePosti e2)
{
    Console.WriteLine(e2.Message);

}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}

static Evento CreaEvento()
{
    Console.WriteLine("Inserisci il titolo dell'evento");
    string titolo = Console.ReadLine();

    Console.WriteLine("Inserisci la data dell'evento (dd/mm/yyyy)");
    string data = Console.ReadLine();

    Console.WriteLine("Inserisci la capienza totale dell'evento");
    int capienzaMax = int.Parse(Console.ReadLine());

    return new Evento(titolo, data, capienzaMax);

}







