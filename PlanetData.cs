public class PlanetData {
    public static Planet earth {get;set;} = new Planet() {
        Name = "Earth",
        AmountExplored = 1,
        xCoord = 0,
        yCoord = 0,
        zCoord = 0,
    };
    public static Planet xeebl {get;set;} = new Planet() {
        Name = "Xeebl",
        AmountExplored = 0,
        xCoord = 2,
        yCoord = 3,
        zCoord = -1,
    };
}