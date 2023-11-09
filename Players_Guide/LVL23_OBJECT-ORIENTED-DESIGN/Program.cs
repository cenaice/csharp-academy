// LEVEL 23: OBJECT-ORIENTED DESIGN

/* SPEEDRUN
 * Object-Oriented design is figuring out which objects should exist in your program, which classes they
   belong to, what responsibilities each should have, and how they should work together.

 * The design starts with identifying the requirements of what you are building.
 
 * Noun extraction helps get the design process started by identifying concepts and jobs to do in the requirements.
 
 * CRC cards are a tool to think through a design with physical cards for each object, containing their
   class, responsibilites, and collaborators.

 * Object Oriented design is hard, but you don't have to figure out the entire program all at once, nor do
   you have to get it right the first time.
*/





public class Asteroid
{
    public float PositionX { get; private set; }
    public float PositionY { get; private set; }
    public float VelocityX { get; private set; }
    public float VelocityY { get; private set; }
    
    public Asteroid(float positionX, float positionY, float velocityX, float velocityY)
    {
        PositionX = positionX;
        PositionY = positionY;
        VelocityX = velocityX;
        VelocityY = velocityY;
    }

    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}

public class AsteroidsGame
{
    private Asteroid[] _asteroids;

    public AsteroidsGame()
    {
        _asteroids = new Asteroid[5];
        _asteroids[0] = new Asteroid(100, 200, -4, -2);
        _asteroids[1] = new Asteroid(-50, 100, -1, +3);
        _asteroids[2] = new Asteroid(0, 0, 2, 1);
        _asteroids[3] = new Asteroid(400, -100, -3, -1);
        _asteroids[4] = new Asteroid(200, -300, 0, 3);
    }

    public void Run()
    {
        while (true)
        {
            foreach(Asteroid asteroid in _asteroids)
            {
                asteroid.Update();
            }
        }
    }
        
}
