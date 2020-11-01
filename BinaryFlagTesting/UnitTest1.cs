using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.BinaryFlag;

namespace BinaryFlagTesting
{
    [TestClass]
    public class UnitTest1
    {
        MultipleBinaryFlag binaryFlag1 = new MultipleBinaryFlag(10);
        MultipleBinaryFlag binaryFlag1_f = new MultipleBinaryFlag(10, false);
        MultipleBinaryFlag binaryFlag2 = new MultipleBinaryFlag(33);
        MultipleBinaryFlag binaryFlag2_f = new MultipleBinaryFlag(33, false);
        MultipleBinaryFlag binaryFlag3 = new MultipleBinaryFlag(65);
        MultipleBinaryFlag binaryFlag3_f = new MultipleBinaryFlag(65, false);

        [TestMethod]
        public void TestConstructor_2_32()
        {
            Assert.IsNotNull(binaryFlag1);
            Assert.IsTrue(binaryFlag1.GetFlag());
        }

        [TestMethod]
        public void TestConstructor_33_64()
        {
            Assert.IsNotNull(binaryFlag2);
            Assert.IsTrue(binaryFlag1.GetFlag());
        }

        [TestMethod]
        public void TestConstructor_65()
        {
            Assert.IsNotNull(binaryFlag3);
            Assert.IsTrue(binaryFlag1.GetFlag());
        }

        [TestMethod]
        public void TestConstructor_2_32_false()
        {
            Assert.IsNotNull(binaryFlag1_f);
            Assert.IsFalse(binaryFlag1_f.GetFlag());
        }

        [TestMethod]
        public void TestConstructor_33_64_false()
        {
            Assert.IsNotNull(binaryFlag2_f);
            Assert.IsFalse(binaryFlag2_f.GetFlag());
        }

        [TestMethod]
        public void TestConstructor_65_false()
        {
            Assert.IsNotNull(binaryFlag3_f);
            Assert.IsFalse(binaryFlag3_f.GetFlag());
        }

        [TestMethod]
        public void TestConstructorExceptionTooSmall()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                new MultipleBinaryFlag(1);
            });
        }

        [TestMethod]
        public void TestConstructorExceptionTooBig()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                new MultipleBinaryFlag(17179868705);
            });
        }

        [TestMethod]
        public void TestGetFlag_2_32()
        {
            Assert.IsTrue(binaryFlag1.GetFlag());
            Assert.IsFalse(binaryFlag1_f.GetFlag());
        }

        [TestMethod]
        public void TestGetFlag_33_64()
        {
            Assert.IsTrue(binaryFlag2.GetFlag());
            Assert.IsFalse(binaryFlag2_f.GetFlag());
        }

        [TestMethod]
        public void TestGetFlag_65()
        {
            Assert.IsTrue(binaryFlag3.GetFlag());
            Assert.IsFalse(binaryFlag3_f.GetFlag());
        }

        [TestMethod]
        public void TestSetFlag_true()
        {
            binaryFlag1.SetFlag(1);
            Assert.IsTrue(binaryFlag1.GetFlag());
        }

        [TestMethod]
        public void TestSetFlag_2_32()
        {
            binaryFlag1_f.SetFlag(1);
            Assert.IsFalse(binaryFlag1_f.GetFlag());
            for (ulong i = 0; i < 10; i++) {
                binaryFlag1_f.SetFlag(i);
            }
            Assert.IsTrue(binaryFlag1_f.GetFlag());
        }

        [TestMethod]
        public void TestSetFlag_33_64()
        {
            binaryFlag2_f.SetFlag(1);
            Assert.IsFalse(binaryFlag2_f.GetFlag());
            for (ulong i = 0; i < 33; i++)
            {
                binaryFlag2_f.SetFlag(i);
            }
            Assert.IsTrue(binaryFlag2_f.GetFlag());
        }

        [TestMethod]
        public void TestSetFlag_65()
        {
            binaryFlag3_f.SetFlag(1);
            Assert.IsFalse(binaryFlag3_f.GetFlag());
            for (ulong i = 0; i < 65; i++)
            {
                binaryFlag3_f.SetFlag(i);
            }
            Assert.IsTrue(binaryFlag3_f.GetFlag());
        }

        [TestMethod]
        public void TestSetFlagException_2_32()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                binaryFlag1_f.SetFlag(10);
            });
        }

        [TestMethod]
        public void TestSetFlagException_33_64()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                binaryFlag2_f.SetFlag(33);
            });
        }

        [TestMethod]
        public void TestSetFlagException_65()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                binaryFlag3_f.SetFlag(65);
            });
        }

        [TestMethod]
        public void TestResetFlag_2_32()
        {
            binaryFlag1.ResetFlag(1);
            Assert.IsFalse(binaryFlag1.GetFlag());
        }

        [TestMethod]
        public void TestResetFlag_33_64()
        {
            binaryFlag2.ResetFlag(1);
            Assert.IsFalse(binaryFlag2.GetFlag());
        }

        [TestMethod]
        public void TestResetFlag_65()
        {
            binaryFlag3.ResetFlag(1);
            Assert.IsFalse(binaryFlag3.GetFlag());
        }

        [TestMethod]
        public void TestResetFlag_65_false()
        {
            binaryFlag1_f.ResetFlag(1);
            Assert.IsFalse(binaryFlag1_f.GetFlag());
        }

        [TestMethod]
        public void TestResetFlagException_2_32()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                binaryFlag1.ResetFlag(10);
            });
        }

        [TestMethod]
        public void TestResetFlagException_33_64()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                binaryFlag2.ResetFlag(33);
            });
        }

        [TestMethod]
        public void TestResetFlagException_65()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                binaryFlag3.ResetFlag(65);
            });
        }
    }
}
