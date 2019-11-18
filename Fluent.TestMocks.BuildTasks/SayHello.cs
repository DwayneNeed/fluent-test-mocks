using Microsoft.Build.Framework;

namespace Fluent.TestMocks.BuildTasks
{
    public class SayHello : Microsoft.Build.Utilities.Task
    {
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Aloha");
            return true;
        }
    }
}