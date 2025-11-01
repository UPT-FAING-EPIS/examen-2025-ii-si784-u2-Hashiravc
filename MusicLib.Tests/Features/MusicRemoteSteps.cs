using TechTalk.SpecFlow;
using MusicLib;
using NUnit.Framework;

namespace MusicLib.Tests
{
    [Binding]
    public class MusicRemoteSteps
    {
        private MusicPlayer _player = null!;
        private MusicRemote _remote = null!;
        private string _result = null!;

        [Given("a music player")]
        public void GivenAMusicPlayer()
        {
            _player = new MusicPlayer();
        }

        [Given("a music remote")]
        public void GivenAMusicRemote()
        {
            _remote = new MusicRemote();
        }

        [When("I set the command to play")]
        public void WhenISetTheCommandToPlay()
        {
            _remote.SetCommand(new PlayCommand(_player));
        }

        [When("I set the command to pause")]
        public void WhenISetTheCommandToPause()
        {
            _remote.SetCommand(new PauseCommand(_player));
        }

        [When("I set the command to skip")]
        public void WhenISetTheCommandToSkip()
        {
            _remote.SetCommand(new SkipCommand(_player));
        }

        [When("I press the remote button")]
        public void WhenIPressTheRemoteButton()
        {
            _result = _remote.PressButton();
        }

        [Then(@"the output should be ""(.*)""")]
public void ThenTheOutputShouldBe(string expected)
{
    NUnit.Framework.Assert.AreEqual(expected, _result);
}
    }
}
