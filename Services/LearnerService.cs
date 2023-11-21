using Microsoft.VisualBasic;
using NullObject.Entities;

namespace NullObject.Services
{
    public class LearnerService
    {
        private LearnerRepo _repo = new LearnerRepo();
        public ILearner GetCurrentLearner()
        {
            int learnerId = 14;
            var learner = _repo.GetLearner(learnerId);
            if (learner == null)
            {
                return new NullLearner();
            }
            return learner;
        }

        class LearnerRepo
        {

            readonly IList<Learner> _learners = new List<Learner> {
                new Learner(1, "John Doe", 3),
                new Learner(2, "Jane Doe", 5),
                new Learner(3, "John Smith", 2),
                new Learner(4, "Jane Smith", 4)
            };

            internal ILearner GetLearner(int learnerId)
            {
                bool learnerExists = _learners.Any(l => l.Id == learnerId);
                if (learnerExists)
                {
                    return _learners.First(l => l.Id == learnerId);
                }
                return null;
            }
        }
    }
}