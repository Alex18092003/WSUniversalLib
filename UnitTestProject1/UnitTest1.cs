using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //классическая проверка правильного подсчета
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculation()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int expected = 552; // верный результат
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, result);
        }
        // проверка не правильного подсчета
        [TestMethod]
        public void GetQuantityForProduct_NoCorrectCalculation()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int expected = 550;//не верный результат
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreNotEqual(expected, result);
        }
        // проверка на то, что метод возвращает тип данных int
        [TestMethod]
        public void GetQuantityForProduct_CorrectType()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsInstanceOfType(result, typeof(int));
        }
        // проверка на то, что метод не возвращает тип данных float
        [TestMethod]
        public void GetQuantityForProduct_NoCorrectType()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(result, typeof(float));
        }
        // проверка на то что результат это положительное число при правильных данных
        [TestMethod]
        public void GetQuantityForProduct_CorrectResultPositive()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(result >= 0);
        }
        // проверка на то что результат это не отрицательное число при правильных данных
        [TestMethod]
        public void GetQuantityForProduct_CorrectResultNegative()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(result < 0);
        }
        // проверка на то что результат это не ноль при правильных данных
        [TestMethod]
        public void GetQuantityForProduct_ResultNotNull()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(result);
        }
        // проверка на то что при вводе корректных значений, результат не выдает -1
        [TestMethod]
        public void GetQuantityForProduct_CorrectResultNotWrong()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(result == -1);
        }
        // проверка на то что при вводе некорректных значений, результат выдает -1
        [TestMethod]
        public void GetQuantityForProduct_ResultWrong()
        {
            int productType = 1;
            int materialType = 1;
            int count = -5;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(result == -1);
        }
        // проверка на то, что метод не возвращает тип данных char
        [TestMethod]
        public void GetQuantityForProduct_NoCorrectType2()
        {
            int productType = 1;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(result, typeof(char));
        }

        //  проверка того, что результат не выходит за пределы int
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculationTypeMaxAndMinInt()
        {
            int productType = 3;
            int materialType = 2;
            int count = 999999999;
            float width = 9999999999999999999;
            float length = 9999999999999999999;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(result < -2147483648 && result > 2147483647);
        }

        //  проверка того, что результат не выходит за пределы int
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculationTypeMaxValue()
        {
            int productType = 3;
            int materialType = 2;
            int count = 999999999;
            float width = 9999999999999999999;
            float length = 9999999999999999999;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(result > -2147483648 && result < 2147483647);
        }
        //  проверка на несуществующий тип материала
        [TestMethod]
        public void GetQuantityForProduct_NoCorrectCalculationMaterialType()
        {
            int productType = 1;
            int materialType = 10;
            int count = 20;
            float width = 5;
            float length = 5;
            int expected = -1;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, result);
        }
        //  проверка на несуществующий тип продукта
        [TestMethod]
        public void GetQuantityForProduct_NoCorrectCalculationProductType()
        {
            int productType = 55;
            int materialType = 1;
            int count = 20;
            float width = 5;
            float length = 5;
            int expected = -1;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, result);
        }

        //  проверка того, что при переменных = 0, результат будет корректным
        [TestMethod]
        public void GetQuantityForProduct_CorrectCalculationSmallestNumbers()
        {
            int productType = 1;
            int materialType = 2;
            int count = 0;
            float width = 0;
            float length = 0;
            int expected = 0;
            int result = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, result);
        }


    }
}
