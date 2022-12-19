namespace ChristmasLights
{
    public class GridLights
    {
        private int tallGrid;
        private bool[] gridLightsValue;
        private List<List<Light>> gridLights;
        public GridLights()
        {
            this.tallGrid = new Variables().TALL_GRID;
            this.gridLightsValue = Enumerable.Repeat(false, tallGrid * tallGrid).ToArray();
            this.gridLights = InitializeGridLights();
            
        }

        public bool[] GetLightsValue()
        {
            return this.gridLightsValue;  
        }

        public void TurnOffLights(int[] beginCoordinates, int[] endCoordinates)
        {
            ChangeLights("TurnOff", beginCoordinates,endCoordinates);
        }

        public void TurnOnLights(int[] beginCoordinates, int[] endCoordinates) {
            ChangeLights("TurnOn", beginCoordinates,endCoordinates);
        }

        public void ToggleLights(int[] beginCoordinates, int[] endCoordinates)
        {
            ChangeLights("Toggle", beginCoordinates,endCoordinates);
        }

        private void ChangeLights(string action, int[] beginCoordinates, int[] endCoordinates) {
            for (int index = beginCoordinates[0]; index <= endCoordinates[0]; index++) {
                for (int index_2 = beginCoordinates[1]; index_2 <= endCoordinates[1]; index_2++) {
                    ChangeLight(action, index, index_2);
                }
            }
        }

        private void ChangeLight(string action, int x, int y) {
            switch (action) {
                case "TurnOn": 
                    LightTurnOn(x, y);
                    break;
                case "TurnOff":
                    LightTurnOff(x, y);
                    break;
                case "Toggle":
                    LightToggle(x, y);
                    break;
                default:
                    
                    break;          
            }
        }

        private void LightToggle(int x, int y)
        {
            gridLights[x][y].toggle();
            gridLightsValue[y + x * (tallGrid)] = !gridLightsValue[y + x * (tallGrid)]; ;
        }

        private void LightTurnOff(int x, int y)
        {
            gridLights[x][y].turnOff();
            gridLightsValue[y + x * (tallGrid)] = false;
        }

        private void LightTurnOn(int x, int y ){
            gridLights[x][y].turnOn();
            gridLightsValue[y + x * (tallGrid)] = true;
        }
        private List<List<Light>> InitializeGridLights(){
            List<List<Light>> grid = new List<List<Light>>(tallGrid);

            for (int index = 0; index < tallGrid; index++) {

                List<Light> tmp = new List<Light>(tallGrid);
                for (int index_2 = 0; index_2 < tallGrid; index_2++) {
                    tmp.Add(new Light());
                }
                grid.Add(tmp);
            }

            return grid;
        }
    }
}