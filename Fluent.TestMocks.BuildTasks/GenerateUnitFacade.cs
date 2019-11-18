using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent.TestMocks.BuildTasks
{
    public class GenerateUnitFacade : Microsoft.Build.Utilities.Task
    {
        public ITaskItem[] UnitFacades { get; set; }

        public override bool Execute()
        {
            foreach (var unitFacade in UnitFacades)
            {
                Log.LogMessage(MessageImportance.High, $"UnitFacade {unitFacade.ItemSpec}");
            }
            return true;
        }
    }
}
