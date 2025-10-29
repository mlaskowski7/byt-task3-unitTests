using BYT.Task3UnitTests;

namespace BYT.Task3UnitTests.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly Sphere _sphere = new Sphere(5);
        private readonly Cylinder _cylinder = new Cylinder(5, 5);
        private readonly Rectangle _rectangle = new Rectangle(5, 5);
        private readonly Cube _cube = new Cube(5);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(_sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(_sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }
        
        [Test]
        public void CylinderCalculateArea_ValidInput_CorrectResult()
        {
            const double expectedResult = 314.159;
            
            var result = _cylinder.CalculateArea();
            
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [Test]
        public void CylinderCalculateVolume_ValidInput_CorrectResult()
        {
            const double expectedResult = 392.699;
            
            var result = _cylinder.CalculateVolume();
            
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001));
        }

        [Test]
        public void RectangleCalculateArea_ValidInput_CorrectResult()
        {
            const double expectedResult = 25;
            
            var result = _rectangle.CalculateArea();
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void RectangleCalculateVolume_ValidInput_Zero()
        {
            var result = _rectangle.CalculateVolume();
            
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void CubeCalculateArea_ValidInput_CorrectResult()
        {
            const double expectedResult = 150;
            
            var result = _cube.CalculateArea();
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void CubeCalculateVolume_ValidInput_Zero()
        {
            const double expectedResult = 125;
            var result = _cube.CalculateVolume();
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}