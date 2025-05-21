using Microsoft.VisualStudio.TestTools.UnitTesting;
using GLS_CLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(9,100,9)]
        public void atlag_fogyTest(int elso,int masodik,int e)
        {
            Assert.AreEqual(e,Program.atlag_fogy(elso,masodik));
        }
    }
}