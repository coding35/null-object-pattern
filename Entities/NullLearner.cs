namespace NullObject.Entities
{
    // Null Object Pattern - a way to avoid null checks
    public class NullLearner : ILearner
    {
        public int Id => -1;
        public string UserName => "Guest";
        public int CoursesCompleted => 0;
    }
}