 class Car
{
    public string model;
    private int CurrentSpeed;
    protected string Enginetype;

    public void Accelerate(int speed)
    {
        if (speed > 0)
        {
            CurrentSpeed = speed;
            Console.WriteLine($"Разгон до 100 {CurrentSpeed} км/ч");
        }
    }
    private void CheckEngine() { Console.WriteLine("Проверка двигателя..."); }

    protected void SetEngine(string type)
    {
        Enginetype = type;
    }
}