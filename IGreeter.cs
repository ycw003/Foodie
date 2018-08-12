using Microsoft.Extensions.Configuration;

namespace Foodie
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    // A Greeter class that implements IGreeter interface
    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration; // save all configuration source into a field
        }

        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"]; // retrieve the value from the key "Greeting"
        }
    }
}
