// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using GestoreEventi.CustomExeption;
/*////////////////////////////////////////////////////////////
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

/////////////////////////////////////////////////////////*/
Evento uno = new ("acqua", "22/7/2023", 200);
Evento due = new ("terra", "25/7/2023", 500);

ProgrammaEventi globo = new("globo");

globo.AggiungiEvento(uno);
globo.AggiungiEvento(due);
globo.AggiungiEvento(new Evento("aria", "27/7/2023", 700));
globo.AggiungiEvento(new Evento("tempesta", "27/7/2023", 900));

globo.StampaTutto();
Console.WriteLine(globo.QuantiEventi());

StampaStatic(globo.EventiInData("27/7/2023"));


Console.WriteLine("Inserisci il nome dalla lista di eventi");
string titoloProgramma = Console.ReadLine();

ProgrammaEventi listaUtente = new(titoloProgramma);

Console.WriteLine("Inserisci quanti elementi vuoi inserire");
int max = int.Parse(Console.ReadLine());

int x = 0;
try
{
    while (x < max)
    {
        Evento evento = CreaEvento();
        listaUtente.AggiungiEvento(evento);
        x++;
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
Console.WriteLine("nella lista ci sono:" + listaUtente.QuantiEventi + " elementi");
Console.WriteLine("Ecco il programma");
listaUtente.StampaTutto();

Console.WriteLine("Inserisci la data per stampare gli eventi di quel giorno (dd/mm/yyyy)");
string data = Console.ReadLine();
StampaStatic(globo.EventiInData("27/7/2023"));





////////////////////////////////// METODI
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
static void StampaStatic(List<Evento> eventi)
{
    foreach (Evento elemento in eventi)
    {
        Console.WriteLine(elemento.ToString());
    }

}
//METODO MILESTON 2
static void DisdiciPosti(Evento evento)
{
    while (true)
    {
        Console.WriteLine("Vuoi disdire dei posti? (si-no)");
        string controllo = Console.ReadLine().ToUpper();
        if (controllo == "SI")
        {
            Console.WriteLine("Quanti posti vuoi disdire?");
            int x = int.Parse(Console.ReadLine());
            evento.DisdiciPosti(x);
            Console.WriteLine(evento.StampaInfo());
        }
        else if (controllo == "NO")
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




