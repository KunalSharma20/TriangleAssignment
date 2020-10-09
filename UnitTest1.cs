using NUnit.Framework;
using TriangleAssignment;

namespace TriangleSolverNUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Case1_xis7_yis7_zis7_Expects_EquilateralTriangleAsTrue()
        {
            string ExpectedOutput = "Equilateral Triangle";
            string ActualOutput = TriangleSolver.Analyze(7, 7, 7);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }

        [Test]
        public void Case2_xis8_yis7_zis8_Expects_IsocelesTriangleAsTrue()
        {
            string ExpectedOutput = "Isoceles Triangle";
            string ActualOutput = TriangleSolver.Analyze(8, 7, 8);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Case3_xis7_yis8_zis8_Expects_IsocelesTriangleAsTrue()
        {
            string ExpectedOutput = "Isoceles Triangle";
            string ActualOutput = TriangleSolver.Analyze(7, 8, 8);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Case4_xis8_yis8_zis7_Expects_IsocelesTriangleAsTrue()
        {
            string ExpectedOutput = "Isoceles Triangle";
            string ActualOutput = TriangleSolver.Analyze(8, 8, 7);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Case5_xis9_yis7_zis8_Expects_ScaleneTriangleAsTrue()
        {
            string ExpectedOutput = "Scalene Triangle";
            string ActualOutput = TriangleSolver.Analyze(9, 7, 8);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Case6_xis1_yis1_zis10_Expects_TriangleCannotFormAsTrue()
        {
            string ExpectedOutput = "Triangle cannot be formed with the inputs provided";
            string ActualOutput = TriangleSolver.Analyze(1, 1, 10);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Case7_xis0_yis0_zis0_Expects_TriangleCannotFormAsTrue()
        {
            string ExpectedOutput = "Triangle cannot be formed with the inputs provided";
            string ActualOutput = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Case8_xyzIsInNegative_Expects_TriangleCannotFormAsTrue()
        {
            string ExpectedOutput = "Triangle cannot be formed with the inputs provided";
            string ActualOutput = TriangleSolver.Analyze(-2, -4, -8);
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
    }
}