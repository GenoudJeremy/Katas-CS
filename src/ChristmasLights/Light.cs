namespace ChristmasLights
{
    public class Light
    {
        private bool isOn = false;

        public bool GetState()
        {
            return this.isOn;
        }

        public void toggle()
        {
            this.isOn = !this.isOn;
        }

        public void turnOff()
        {
            this.isOn = false;
        }

        public void turnOn()
        {
            this.isOn = true;
        }
    }
}