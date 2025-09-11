namespace MultiplayerGame
{
    public class DefendCommand : ICommand
    {
        private Avatar _avatar;

        public DefendCommand(Avatar avatar)
        {
            _avatar = avatar;
        }
        public void Execute()
        {
            _avatar.Defend();
        }

        public void Undo()
        {
            _avatar.AddShield();
        }
    }
}
