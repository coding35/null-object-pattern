
// based on Pluralsight course "Design Patterns in C# Behavioral - Null Object"
// https://app.pluralsight.com/library/courses/csharp-design-patterns-null-object/table-of-contents

using NullObject.Services;
using NullObject.View;

namespace NullObject {
    class Program {
        static void Main(string[] args) {
            LearnerService learnerService = new LearnerService();
            ILearner learner = learnerService.GetCurrentLearner();

            LearnerView view = new LearnerView(learner);
            view.RenderView();
        }
    }
}