namespace Lesson_11;

class ClassRoom
{
    Pupil[] pupils; 
    public ClassRoom(Pupil[] pupils) => this.pupils = pupils;

    public void Study()
    {
        foreach (Pupil pupil in pupils) 
        { 
            pupil.Study(); 
        }
    }
    public void Read()
    {
        foreach(Pupil pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void Write()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach(Pupil pupil in pupils)
        {
            pupil.Relax();
        }
    }
}
