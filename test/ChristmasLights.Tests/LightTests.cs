namespace ChristmasLights.Tests;

public class LightTests
{
    [Fact]
    public void ShouldReturnFalseWhenLightInitialize()
    {
        Light light = new Light();

        Boolean result = light.GetState();
        Assert.False(result);
    }
}