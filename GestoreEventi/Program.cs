// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using GestoreEventi.CustomExeption;

try
{
    Evento nuovo = new Evento("Danza", "23/12/2022", 30);
    Console.WriteLine(nuovo.ToString());

    nuovo.PrenotaPosti(23);
    Console.WriteLine(nuovo.ToString());

    nuovo.DisdiciPosti(13);
    Console.WriteLine(nuovo.ToString());

    nuovo.DisdiciPosti(13);
    Console.WriteLine(nuovo.ToString());



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

