namespace Lesson_11;

class GoodPupil : Pupil
{
    string _name;
    public GoodPupil(string name)
    {
        _name = name;
    }
    public override void Study() { Console.WriteLine($"Хороший ученик {_name} хорошо учится."); }
    public override void Read() { Console.WriteLine($"Хороший ученик {_name} хорошо читает."); }
    public override void Write() { Console.WriteLine($"Хороший ученик {_name} хорошо пишет."); }
    public override void Relax() { Console.WriteLine($"Хороший ученик {_name} хорошо расслабляется."); }
}