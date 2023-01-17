using Selenium.WebDriver.Basics.Lection.DriverConfiguration;

namespace Selenium.WebDriver.Basics.Lection.Utilities;

public class Configurator
{
    // TODO Find a way how to read appsettings.json out
    public static readonly Browser Browser = Enum.Parse<Browser>("chrome", true);
}