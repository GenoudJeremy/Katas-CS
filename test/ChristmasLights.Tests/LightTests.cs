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

    [Fact]
    public void ShouldReturnTrueWhenLightIsTurnOn(){

        Light light = new Light();
        light.turnOn();

        Boolean result = light.GetState();
        Assert.True(result);
    }
    [Fact]
    public void ShouldReturnFalseWhenLightIsTurnOff(){

        Light light = new Light();
        light.turnOff();

        Boolean result = light.GetState();
        Assert.False(result);
    }

    [Fact]
    public void ShouldReturnFalseWhenLightOnIsToggle(){

        Light light = new Light();
        light.turnOn();
        light.toggle();

        Boolean result = light.GetState();
        Assert.False(result);
    }
    [Fact]
    public void ShouldReturnTrueWhenLightOffIsToggle(){

        Light light = new Light();
        light.toggle();

        Boolean result = light.GetState();
        Assert.True(result);
    }
}