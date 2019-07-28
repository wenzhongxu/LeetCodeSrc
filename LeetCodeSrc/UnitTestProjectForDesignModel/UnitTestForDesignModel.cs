using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignModel;

namespace UnitTestProjectForDesignModel
{
    [TestClass]
    public class UnitTestForDesignModel
    {
        /// <summary>
        /// 建造者模式单元测试
        /// </summary>
        [TestMethod]
        public void TestMethodForBuilderModel()
        {
            BuilderModelMain builderModelMain = new BuilderModelMain();
            builderModelMain.BuilderMain();
        }


        /// <summary>
        /// 原型模式单元测试
        /// </summary>
        [TestMethod]
        public void TestMethodForPrototypePattern()
        {
            PrototypeMain.PrototypePatternMain();
        }
    }
}
