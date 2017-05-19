using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using task_4;
using System.IO;

namespace Task_4
{
    [TestFixture]

    class Tests
    {

        [Test]
        public void KeinIndexKleinerNull()
        {
            var x = new Pyramide("Hans", -1);
            Assert.True(x.Index > 0);
            var y = new ErdGrab("Hans", -1);
            Assert.True(y.Index > 0);
            var z = new UrnenGrab("Hans", -1);
            Assert.True(z.Index > 0);
        }

        [Test]
        public void NoName()
        {
            var x = new ErdGrab("", 1);
            var y = new Pyramide("", 1);
            var z = new UrnenGrab("", 1);
            Assert.True(x.Name != "");
            Assert.False(y.Name == "");
            Assert.AreNotEqual(z.Name, "");
        }

        [Test]
        public void CanCreatePyramide()
        {
            var x = new Pyramide("Ramses", 1);
            Assert.IsTrue(x.Name == "Ramses");
            Assert.IsTrue(x.Index == 1);
            Assert.IsTrue(x.Typ == "Pyramide");
        }

        [Test]
        public void CanCreateErdgrab()
        {
            var x = new ErdGrab("Ramses", 1);
            Assert.IsTrue(x.Name == "Ramses");
            Assert.IsTrue(x.Index == 1);
            Assert.IsTrue(x.Typ == "Erdgrab");
        }

        [Test]
        ///Console Out Test!!!
        public void SklavenKommen()
        {
            var x = new Pyramide("Ramses", 1);
            using (StreamWriter writer = new StreamWriter(Path.GetTempPath() + "\\test.txt"))
            {
                Console.SetOut(writer);
                x.MachInschrift();
            }
            string result = File.ReadAllText(Path.GetTempPath() + "\\test.txt");
            Assert.IsTrue(result.StartsWith("Sklaven"));
        }
        [Test]
        public void ArraySortByIndexPossible()
        {
            Pyramide a = new Pyramide("Echnaton", 8);
            Pyramide b = new Pyramide("Ramses", 2);
            Pyramide c = new Pyramide("TutEnchAmun", 1);
            IGrab[] array = new IGrab[] { a, b,c };
            Array.Sort(array, delegate (IGrab x, IGrab y) {
                return x.Index.CompareTo(y.Index);
            });
            Assert.IsTrue(array[0].Index == 1);
        }

        [Test]
        public void CatchPyramideWithoutParameter()
        {
            Assert.Catch(() => { var x = new Pyramide(); });
            
        }

        [Test]
        public void CatchErdgrabWithoutParameter()
        {
            Assert.Catch(() => { var x = new ErdGrab(); });

        }
        [Test]
        public void CanCreateUrnengrab()
        {
            var x = new UrnenGrab("Ramses", 1);
            Assert.IsTrue(x.Name == "Ramses");
            Assert.IsTrue(x.Index == 1);
            Assert.IsTrue(x.Typ == "Urnengrab");
        }
    }
}
