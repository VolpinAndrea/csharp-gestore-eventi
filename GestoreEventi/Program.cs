// See https://aka.ms/new-console-template for more information
using GestoreEventi;
try
{
    Evento nuovo = new Evento("Danza", "3/12/2022", 30);
    Console.WriteLine(nuovo.ToString());

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("La data inserita è già passata");
}
