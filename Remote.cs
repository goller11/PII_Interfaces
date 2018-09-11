namespace Adapter {
    class Remote : IRemote {
        public void TurnOnTV (ITV tv) {
            tv.TurnOn ();
        }

        public void TurnOffTV (ITV tv) {
            tv.TurnOff ();
        }
    }

}