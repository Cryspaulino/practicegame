using Raylib_cs;

public class Ball : GameObject
{

    private int _radius;

    public Ball(int x, int y, Color.Red) : base()
    {
        
    }

    public override void Draw()
    {
        Raylib.DrawCircle(_x, _y, _radius, _color)

    }

    public override void ProcessActions()
    {
        _x += 5;
        _y += 5;
    }

}