using CodeKata2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KataISBN2
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Valid10Dg()
        {
            ValiISBN obj = new ValiISBN();
            string isbn = "9514125471";
            bool result = obj.ValiISB(isbn);

            Assert.IsTrue(result);
        }
        [Fact]
        public void inValid10Dg()
        {
            ValiISBN obj = new ValiISBN();
            string isbn = "9514125471";
            bool result = obj.ValiISB(isbn);

            Assert.IsFalse(result);
        }

        [Fact]
        public void Valid13Dg()
        {
            ValiISBN obj = new ValiISBN();
            string isbn = "1547845478451";
            bool result = obj.ValiISB(isbn);

            Assert.IsTrue(result);

        }
        [Fact]
        public void inValid13Dg()
        {
            ValiISBN obj = new ValiISBN();
            string isbn = "1547844478451";
            bool result = obj.ValiISB(isbn);

            Assert.IsTrue(result);
        }
    }
}
