namespace Adapter {
    class SmartRemote : ISmartRemote, IRemote {

        public bool status {get;}

        public bool Status {
            get { return this.status; }
        }

        public void StartNetflix (ISmartTV smartTV) {
            smartTV.PlayNetflix ();
        }

        public void StartYouTube (ISmartTV smartTV) {
            smartTV.PlayYoutube ();
        }

        public void TurnOnTV (ITV tv) {
            tv.TurnOn ();
        }

        public void TurnOffTV (ITV tv) {
            tv.TurnOff ();
        }
    }

}