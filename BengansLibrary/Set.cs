using System;
using System.Linq;

namespace BengansBowlinghallLibrary
{
    public class Set
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int GamePartyId { get; set; }
        public int[] Frames { get; set; } = new int[10];

        public static Set RandomSet(int setId, int gamePartyId, int setNumber)
        {
            var frames = new int[10];
            var strike = false;
            var secondStrike = false;
            var spare = false;

            for (int i = 0; i < frames.Count(); i++)
            {
                Random rnd = new Random();
                var firstBall = rnd.Next(0, 11);

                if (gamePartyId == 1 || gamePartyId == 3) // Makes sure player one get higher scores than player two in game 1
                    firstBall = rnd.Next(9, 11);
                else if (gamePartyId == 2 || gamePartyId == 4)
                    firstBall = rnd.Next(0, 3);

                var secondBall = rnd.Next(0, 11 - firstBall);

                if (strike)
                    frames[i - 1] += firstBall + secondBall;
                else if (spare)
                    frames[i - 1] += firstBall;

                if (secondStrike)
                {
                    frames[i - 2] += firstBall + secondBall;

                    secondStrike = false;
                }

                if (firstBall + secondBall == 10)
                    spare = true;
                else
                    spare = false;

                frames[i] = firstBall + secondBall;

                if (firstBall == 10)
                {
                    if (strike)
                        secondStrike = true;

                    strike = true;
                }
                else
                {
                    strike = false;
                }

                if (i == 9 && (strike || spare))
                {
                    var extraBallOne = rnd.Next(0, 11);
                    var extraBallTwo = 0;

                    if (extraBallOne != 10)
                        extraBallTwo = rnd.Next(0, 11 - extraBallOne);
                    else
                        extraBallTwo = rnd.Next(0, 11);

                    frames[i] += extraBallOne + extraBallTwo;


                }
            }

            var set = new Set
            {
                Id = setId,
                SetNumber = setNumber,
                GamePartyId = gamePartyId,
                Frames = frames
            };

            return set;
        }
    }
}
