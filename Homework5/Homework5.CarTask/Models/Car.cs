class Car
{
    public string Model { get; set; }
    public int Speed { get; set; }
    public Driver Driver { get; set; }

    public Car(string model, int speed)
    {
        Model = model;
        Speed = speed;
    }

    public int CalculateSpeed()
    {
        return Driver.Skill * Speed;
    }
}