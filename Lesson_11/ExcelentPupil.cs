namespace Lesson_11;

class ExcelentPupil : Pupil
{
    string _name;
    public ExcelentPupil(string name)
    {
        _name = name;
    }
    public override void Study() { Console.WriteLine($"Отличник {_name} учится на отлично."); }
    public override void Read() { Console.WriteLine($"Отличник {_name} читает отлично."); }
    public override void Write() { Console.WriteLine($"Отличник {_name} пишет отлично."); }
    public override void Relax() { Console.WriteLine($"Отличник {_name} отлично расслабляется."); }
}