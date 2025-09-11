namespace MultiplayerGame.Commands
{
    public class AttackCommand : ICommand
    {
        private Avatar _avatar;

        public AttackCommand(Avatar avatar)
        {
            _avatar = avatar;
        }
        public void Execute()
        {
            _avatar.Attack();
        }

        public void Undo()
        {
            _avatar.AddWeponStrike();
        }
    }
}
