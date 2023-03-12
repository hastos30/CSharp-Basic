namespace Lesson_11;

class Program
{
    static void Main(string[] args)
    {
        Pupil Viktor = new ExcelentPupil("Viktor");
        Pupil Jenia = new GoodPupil("Jenia");
        Pupil Max = new BadPupil("Max");
        Pupil Alina = new GoodPupil("Alina");

        ClassRoom classRoom = new ClassRoom(new Pupil[] { Viktor, Jenia, Max, Alina });

        classRoom.Study();
        Console.WriteLine();

        classRoom.Read();
        Console.WriteLine();

        classRoom.Write();
        Console.WriteLine();

        classRoom.Relax();
        Console.WriteLine();
    }
}