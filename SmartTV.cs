namespace Adapter {
    class SmartTV : ISmartTV {

        public bool Status {get; private set;}
        public bool netflix = false;
        public bool youtube = false;


        public void PlayNetflix () {

            if (this.Status) {
                this.netflix = true;
                this.youtube = false;
           }

        }

        public void PlayYoutube () {
            if (this.Status) {
                this.netflix = false;
                this.youtube = true;
            }
        }
        public void TurnOn () {
            this.Status = true;
        }

        public void TurnOff () {
            this.Status = false;
        }
    }

}