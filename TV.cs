namespace Adapter {
    class TV : ITV {

       bool status = false;

        public bool Status{
            get { return this.status;}
        }

            public void TurnOn () {
                this.status = true;
            }

            public void TurnOff()
            {
                this.status = false;
            }
    }

}