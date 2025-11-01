// MusicLib.Tests/MusicTests.cs
using Xunit;
using MusicLib;

namespace MusicLib.Tests
{
    public class MusicCommandTests
    {
        [Fact]
        public void PlayCommand_ShouldReturn_PlayingMessage()
        {
            var player = new MusicPlayer();
            var command = new PlayCommand(player);

            var result = command.Execute();

            Assert.Equal("Playing the song.", result);
        }

        [Fact]
        public void PauseCommand_ShouldReturn_PausingMessage()
        {
            var player = new MusicPlayer();
            var command = new PauseCommand(player);

            var result = command.Execute();

            Assert.Equal("Pausing the song.", result);
        }

        [Fact]
        public void SkipCommand_ShouldReturn_SkippingMessage()
        {
            var player = new MusicPlayer();
            var command = new SkipCommand(player);

            var result = command.Execute();

            Assert.Equal("Skipping to the next song.", result);
        }

        [Fact]
        public void MusicRemote_PressButton_ExecutesCommand()
        {
            var player = new MusicPlayer();
            var playCmd = new PlayCommand(player);

            var remote = new MusicRemote();
            remote.SetCommand(playCmd);

            var result = remote.PressButton();

            Assert.Equal("Playing the song.", result);
        }
    }
}
