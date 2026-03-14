using UpAndDownCard;

namespace UpAndDown.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Deck_ShouldHave52Cards()
        {
            var deck = new Deck();

            Assert.Equal(52, deck.GetDeckLength());

        }
    }
}