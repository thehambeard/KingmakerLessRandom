## KingmakerLessRandom
# vesion 0.1.0 beta

Kingmaker Less Random does just what it says on the tin, calms down the randomness somewhat. Here is how it works, each die in the game has it's own what we will call a bucket. There is a number for each side of the die in the bucket. D20's will have 20 numbers in the bucket numbered 1-20 for example, the bucket is shaken to mix them up. Each time the game needs a number it reaches in the bucket drawing out a random number. Now for our d20 example, if the computer drew a 7, 7 would be the die roll, and there is no longer a 7 in the bucket. You now have 19 numbers, and guaranteed that you will not get another 7 until the bucket is refilled. Once all the numbers have been used, the bucket refills with the original amount. Every 20 GAME(both you and enemies) rolls you will ALWAYS have 1 of each side of the die come up eliminating combos of something like 1,2,1,2,5,6. Again, this is a generic pool of dice that is used for all rolls, so one side of a fight COULD get more or less of the higher numbers than the other. That's just how randomness works. There are no changes to save game data and is completely safe from ruining saves and can be installed or uninstalled at anytime during a play trough.

* Initial beta release (bugs could happen)
* Tested with Bag of Tricks with no issues found (note: Rolling w/ advantage or disadvantage crashes game. Bag of Tricks bug)


# Todo
* Add options for separate buckets for player and enemies
* Add options for changing the individual amount of dice (such as 2 20s and 2 1s per bucket) to give a different distribution curve
* Add options for enabling/disabling buckets (such as only have a d20 bucket, the rest are normal random rolls)
