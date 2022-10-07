using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks.Platform
{
    internal class PlatformSpecificSuccessfulBuildTask : TestTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            if ((testJobData.PlayerBuildOptions.options & BuildOptions.AutoRunPlayer) != 0)
            {
                testJobData.PlatformSpecificSetup.PostSuccessfulBuildAction();
            }

            yield return null;
        }
    }
}
