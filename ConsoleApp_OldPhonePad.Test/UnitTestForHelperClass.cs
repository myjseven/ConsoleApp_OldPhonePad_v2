using ConsoleApp_OldPhonePad_v2.Classes;
using ConsoleApp_OldPhonePad_v2.Interfaces;

namespace ConsoleApp_OldPhonePad.Test
{
    public class Tests
    {
        private readonly IHelperClass _helperClass = new HelperClass();

        [TestCase("33#", "E")]
        [TestCase("227*#", "B")]
        [TestCase("4433555 555666#", "HELLO")]
        [TestCase("“8 88777444666*664#", "TURING")]
        [TestCase("222 2 22#", "CAB")]
        [TestCase("77777777777777 7#", "QP")]
        [TestCase("7777 33 888 33 66#", "SEVEN")]
        public void OldPhonePad_ReturnsExpectedOutput(string input, string expected)
        {
            var result = _helperClass.OldPhonePad(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}