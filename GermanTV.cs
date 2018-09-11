namespace Adapter
{
    class GermanTV
    {
        string status = "eingeschaltet";
        public void Ausschalten() 
        {
            this.status = "ausgeschaltet"; 
        }
        public void  Einschalten() 
        {
            this.status = "eingeschaltet"; 
        }
        public string Status
        {
            get {return this.status;}
        }
    }
}