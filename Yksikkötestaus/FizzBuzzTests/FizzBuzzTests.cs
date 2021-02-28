using FizzBuzzHarjoitus;
using NUnit.Framework;

namespace FizzBuzzTests
{
    public class Tests
    {
        FizzBuzz _fizzBuzz = null;
        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void LuodaanFizzBuzzLuokka()
        {
            Assert.IsInstanceOf<FizzBuzz>(_fizzBuzz);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuYksi()
        {
            string vastaus = _fizzBuzz.Luku(1);

            Assert.AreEqual("1", vastaus);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuKuusi()
        {
            string vastaus = _fizzBuzz.Luku(6);

            Assert.AreEqual("Fizz", vastaus);
        }

        [Test]
        public void TulostaFizzJosLukuOnKolmellaJaollinen()
        {
            string vastaus = _fizzBuzz.Luku(3);
            
            Assert.AreEqual("Fizz", vastaus);
        }

        [Test]
        public void TulostaFizzJosLukuOnViidellaJaollinen()
        {
            string vastaus = _fizzBuzz.Luku(5);

            Assert.AreEqual("Buzz", vastaus);
        }

        [Test]
        public void TulostaFizzBuzzJosLukuOnKolmellaJaViidellaJaollinen()
        {
            string vastaus = _fizzBuzz.Luku(15);

            Assert.AreEqual("FizzBuzz", vastaus);
        }

    }
}