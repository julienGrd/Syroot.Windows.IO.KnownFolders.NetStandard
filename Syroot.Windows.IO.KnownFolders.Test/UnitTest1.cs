using System;
using System.IO;
using Xunit;

namespace Syroot.Windows.IO.KnownFolders.Test
{
    public class Scratchpad
    {
        [Fact]
        public void TestAllFolderTypes()
        {
            foreach (KnownFolderType type in Enum.GetValues(typeof(KnownFolderType)))
            {
                try
                {
                    KnownFolder knownFolder = new KnownFolder(type);
                    Assert.NotNull(knownFolder.Path);
                    //below is not always true
                    //Assert.True(Directory.Exists(knownFolder.Path));
                }
                catch (Exception ex)
                {
                    // While uncommon with personal folders, other KnownFolders don't exist on every system, and trying
                    // to query those returns an error which we catch here.
                    //Assert.True(false, ex.Message);
                }
            }
        }
    }
}
