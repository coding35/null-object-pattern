namespace NullObject.View
{
    public class LearnerView
    {
        private ILearner _learner;

        public LearnerView(ILearner learner)
        {
            // with null object pattern, we don't need to check for null here
           /*  if(learner == null)
            {
                throw new System.ArgumentNullException(nameof(learner));
            }

            if(learner.UserName == null)
            {
                throw new System.ArgumentNullException(nameof(learner.UserName));
            } */

            _learner = learner;
        }

        public void RenderView()
        {
            System.Console.WriteLine($"Learner: {_learner.UserName}");
            System.Console.WriteLine($"Courses Completed: {_learner.CoursesCompleted}");
        }
    }    
}