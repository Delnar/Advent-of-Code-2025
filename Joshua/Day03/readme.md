You need to create a greedy algorythm that does the following.

We need the twelve largest numbers from left to right.

So we'll work on the largest number and iterate through the digits up to length - 12.

Once we find the digit, remove everything prior to it (and itself).  Then search until length - 11.

Do that until you reach the last digit.
