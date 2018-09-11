using System;

namespace Adapter {
    class Program {
        static void Main (string[] args) {
            ITV sony = new TV ();
            IRemote control = new Remote ();
            control.TurnOnTV (sony);

            SmartTV samsung = new SmartTV ();
            ISmartRemote controller = new SmartRemote ();
            samsung.TurnOn ();
            samsung.PlayNetflix ();
            samsung.PlayYoutube();

            if (samsung.Status == true & samsung.netflix == true) {
                Console.WriteLine ("Se está reproduciendo Netflix.");
            } else {
                samsung.TurnOff ();
                if (samsung.Status == false){
                    Console.WriteLine("La televisión está apagada.");
                }
            }

            GermanTV german = new GermanTV ();
            german.Ausschalten (); //Apagado
            if (german.Status == "eingeschaltet") {
                Console.WriteLine ("The GermanTV is on.");
            } else {
                Console.WriteLine ("The GermanTV is off.");
            }
        }
    }
}