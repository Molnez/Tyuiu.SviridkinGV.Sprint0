<<<<<<< HEAD
﻿using Tyuiu.SviridkinGV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SviridkinGV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
=======
﻿using Tyuiu.SviridkinGV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SviridkinGV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
>>>>>>> 7774568a3204ff16232df439b1fb7836561d1255
