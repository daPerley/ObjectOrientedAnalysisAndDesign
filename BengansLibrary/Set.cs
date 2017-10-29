namespace BengansBowlinghallLibrary
{
    public class Set
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int GamePartyId { get; set; }
        public int[] Frames { get; set; } = new int[10] { 2017, 2017, 2017, 2017, 2017, 2017, 2017, 2017, 2017, 2017 };

        // Strike = 10 + next two balls
        // Spare = x+x=10 + next ball
        //public static Set FrameCalculator(Set set, int firstBall, int secondBall, int bonusBall)
        //{
        //    foreach (var frame in set.Frames)
        //    {
        //        if (frame == 2017)
        //        {
        //            set.Frames[frame - 1] = firstBall + secondBall;

        //            if (frame != 1 && set.Frames[frame - 2] == 10)
        //            {
        //                // only work for strikes, need to get it 
        //                // see the diffrence between strikes and spares
        //                set.Frames[frame - 2] += set.Frames[frame - 1];
        //            }
        //        }
        //    }

        //    return set;
        //}
    }
}
