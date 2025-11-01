Feature: Music Remote Commands
  In order to control the music player
  As a user
  I want to press buttons to play, pause or skip songs

  Scenario: Play a song
    Given a music player
    And a music remote
    When I set the command to play
    And I press the remote button
    Then the output should be "Playing the song."

  Scenario: Pause a song
    Given a music player
    And a music remote
    When I set the command to pause
    And I press the remote button
    Then the output should be "Pausing the song."

  Scenario: Skip a song
    Given a music player
    And a music remote
    When I set the command to skip
    And I press the remote button
    Then the output should be "Skipping to the next song."
