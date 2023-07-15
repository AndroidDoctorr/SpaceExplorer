public class ProgramUI {
    private Planet _currentPlanet = PlanetData.earth;
    public float FuelLevel = 50.0f;
    public void Run() {
        // TODO: Put this inside a keepRunning loop, add a Quit Game option
        Console.Clear();
        Console.WriteLine($"You are on {_currentPlanet.Name}. What would you like to do?");
        Console.WriteLine($"1. Travel");
        Console.WriteLine($"2. Explore");
        Console.WriteLine($"3. Mine");

        Console.Write("Selection: ");
        string selection = Console.ReadLine();

        Planet planet = PlanetData.xeebl;

        Console.WriteLine($"{planet.Name} is {string.Format("{0:0.00}", GetDistance(planet))} lightyears away");

        // FuelLevel -= GetFuelCost(planet);
    }

    private double GetDistance(Planet planet) {
        double xSquared = Math.Pow(planet.xCoord - _currentPlanet.xCoord, 2);
        double ySquared = Math.Pow(planet.yCoord - _currentPlanet.yCoord, 2);
        double zSquared = Math.Pow(planet.zCoord - _currentPlanet.zCoord, 2);

        return Math.Sqrt(xSquared + ySquared + zSquared);
    }
    private double GetFuelCost(Planet planet) {
        double dist = GetDistance(planet);
        return 20 * dist;
    }
}