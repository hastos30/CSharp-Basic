namespace Lesson_11;

class BadPupil : Pupil
{
    string _name;
    public BadPupil(string name)
    {
       _name = name;
    }
    public override void Study() { Console.WriteLine($"Плохой ученик {_name} плохо учится."); }
    public override void Read() { Console.WriteLine($"Плохой ученик {_name} плохо читает."); }
    public override void Write() { Console.WriteLine($"Плохой ученик {_name} плохо пишет."); }
    public override void Relax() { Console.WriteLine($"Плохой ученик {_name} плохо расслабляется."); }
}