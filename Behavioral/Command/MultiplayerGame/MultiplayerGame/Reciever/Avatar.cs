namespace MultiplayerGame.Reciever
{
    //Reciever
    public class Avatar(int shieldCount, int weponStrikeCount)
    {
        public int ShieldCount { get; private set; } = shieldCount;
        public int WeponStrikeCount { get; private set; } = weponStrikeCount;


        public void Move(int moveX, int moveY)
        {
            Console.WriteLine($"Move {moveX} in X axes and  {moveY} in Y axes");
        }

        public void Attack()
        {
            if (WeponStrikeCount == 0)
            {
                Console.WriteLine("Unable to attack");
                return;
            }

            WeponStrikeCount--;

            Console.WriteLine($"Attach");
        }
        public void Defend()
        {
            if (ShieldCount == 0)
            {
                Console.WriteLine("Unable to defend");
                return;
            }

            ShieldCount--;
            Console.WriteLine($"Defend");
        }

        public void AddShield()
        {
            ShieldCount++;
        }

        public void AddWeponStrike()
        {
            WeponStrikeCount++;
        }
    }
}
