using System;

namespace BengansBowlinghallLibrary
{
    public class Set
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int GamePartyId { get; set; }
        public int[] Frames { get; set; } = new int[10];

        public static Set RandomSet(int gamePartyId, int setNumber)
        {
            var frames = new int[10];
            var strike = false;
            var secondStrike = false;
            var spare = false;

            foreach (var frame in frames)
            {
                Random rnd = new Random();
                var firstBall = rnd.Next(0, 11);
                var secondBall = rnd.Next(0, 11 - firstBall);

                if (strike)
                {
                    frames[frame - 2] += firstBall + secondBall;
                }
                else if (spare)
                {
                    frames[frame - 2] += firstBall;
                }

                if (secondStrike)
                {
                    frames[frame - 3] += firstBall + secondBall;

                    secondStrike = false;
                }

                if (firstBall + secondBall == 10)
                {
                    spare = true;
                }
                else
                {
                    spare = false;
                }

                frames[frame - 1] = firstBall + secondBall;

                if (firstBall == 10)
                {
                    if (strike)
                    {
                        secondStrike = true;
                    }

                    strike = true;
                } else
                {
                    strike = false;
                }
            }

            var set = new Set
            {
                SetNumber = setNumber,
                GamePartyId = gamePartyId,
                Frames = frames
            };

            return set;
        }
    }
}
