namespace ChristmasLights.Tests
{
    public class GridLightsTests
    {

        Variables config = new Variables();
        [Fact]
        public void ShouldReturnGridLightsOffWhenInitializeGrid()
        {
            GridLights grid = new GridLights();

            bool[] expected = GenerateArrayFromBidemenssionalList();
            Assert.Equal(expected, grid.GetLightsValue());
            Assert.Equal(
                GetCountItemWithValueTrue(expected), 
                GetCountItemWithValueTrue(grid.GetLightsValue())
            );
        }

        [Fact]
        public void ShouldReturnGridLightsOnWhenLightsAreOn(){
            GridLights grid = new GridLights();
            grid.TurnOnLights(new int[] {0,0}, new int[] {config.TALL_GRID - 1, config.TALL_GRID - 1});
            
            bool[] expected = GenerateArrayFromBidemenssionalList();
            expected = expected.Select(i => true).ToArray();

            Assert.Equal(expected, grid.GetLightsValue());
            Assert.Equal(
                GetCountItemWithValueTrue(expected), 
                GetCountItemWithValueTrue(grid.GetLightsValue())
            );
        }
        [Fact]
        public void ShouldReturnFirstLightsLineGridOnWhenLightsOnFirstLineAreTurnOn(){
            GridLights grid = new GridLights();
            grid.TurnOnLights(new int[] {0,0}, new int[] {0, config.TALL_GRID - 1});
            
            bool[] expected = GenerateArrayFromBidemenssionalList();
            for ( int index = 0; index < config.TALL_GRID; index++) {
                expected[index] = true;
            }

            Assert.Equal(expected, grid.GetLightsValue());
            Assert.Equal(
                GetCountItemWithValueTrue(expected), 
                GetCountItemWithValueTrue(grid.GetLightsValue())
            );
        }
        [Fact]
        public void ShouldReturnGridLightsOnExecptFirstLineWhenLightsAreOnThenFirstLineOff(){
            GridLights grid = new GridLights();
            grid.TurnOnLights(new int[] {0,0}, new int[] {config.TALL_GRID - 1, config.TALL_GRID - 1});
            grid.TurnOffLights(new int[] {0,0}, new int[] {0, config.TALL_GRID - 1});
            bool[] expected = GenerateArrayFromBidemenssionalList();
            expected = expected.Select(i => true).ToArray();

            for ( int index = 0; index < config.TALL_GRID; index++) {
                expected[index] = false;
            }
            Assert.Equal(expected, grid.GetLightsValue());
            Assert.Equal(
                GetCountItemWithValueTrue(expected), 
                GetCountItemWithValueTrue(grid.GetLightsValue())
            );
        }

        [Fact]
        public void ShouldReturnGridLightsOffExecptFirstLineWhenLightsAreOnThenFirstLineOffThenGridToggle(){
            GridLights grid = new GridLights();
            grid.TurnOnLights(new int[] {0,0}, new int[] {config.TALL_GRID - 1, config.TALL_GRID - 1});
            grid.TurnOffLights(new int[] {0,0}, new int[] {0, config.TALL_GRID - 1});
            grid.ToggleLights(new int[] {0,0}, new int[] {config.TALL_GRID - 1, config.TALL_GRID - 1});
            bool[] expected = GenerateArrayFromBidemenssionalList();

            for ( int index = 0; index < config.TALL_GRID; index++) {
                expected[index] = true;
            }
            
            Assert.Equal(expected, grid.GetLightsValue());
            Assert.Equal(
                GetCountItemWithValueTrue(expected), 
                GetCountItemWithValueTrue(grid.GetLightsValue())
            );
        }
        
        private bool[] GenerateArrayFromBidemenssionalList() {
            bool[] expected = Enumerable.Repeat(false, config.TALL_GRID * config.TALL_GRID).ToArray();
            return expected;
        }
        private int GetCountItemWithValueTrue(bool[] items) {
            return items
                    .Where(i => i)
                    .ToArray()
                    .Length;
        }
    }
}