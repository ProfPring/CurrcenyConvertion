using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alert.test
{
    [TestClass]
    public class AlertTest
    {
        [TestMethod]
        public void ShowMessageTest()
        {
            //Varibles 
            string expected = "hello";

            //Act
            string acutal = WpfApp1.App1.Alert.ShowMessage(expected);

            //assert
            Assert.AreEqual(expected, acutal);
        }
    }
}
