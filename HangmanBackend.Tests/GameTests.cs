using System;
using HangmanBackend.Application;
using HangmanBackend.Domain;
using Xunit;

namespace HangmanBackend.Tests
{
    public class GameTests
    {
        public class TheGameIsStarted
        {
            [Fact]
            public void When_an_incorrect_letter_is_guessed()
            {
                // arrange
                var gameId = Guid.NewGuid();
                var game = new Game();
                game.Apply(new GameStarted("account-id", gameId.ToString(), "word", 0));

                int expectedTriesRemaining = game.TriesRemaining - 1;
                
                // act
                game.guessLetter(new GuessLetter(gameId, 'x'));
               
                // assert
                Assert.Equal(expectedTriesRemaining, game.TriesRemaining);
            }
        }
    }
}