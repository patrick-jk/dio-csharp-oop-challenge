namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        public string Model { get; }
        public string Imei { get; }
        public int Memory { get; }

        protected Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        public void Call()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApp(string nomeApp);
    }
}