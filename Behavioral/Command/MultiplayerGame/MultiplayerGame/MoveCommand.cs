namespace MultiplayerGame
{
    public class MoveCommand : ICommand
    {
        private Avatar _avatar;
        private int _moveX;
        private int _moveY;

        public MoveCommand(Avatar avatar, int moveX, int moveY)
        {
            _avatar = avatar;
            _moveX = moveX;
            _moveY = moveY;
        }
        public void Execute()
        {
            _avatar.Move(_moveX, _moveY);
        }

        public void Undo()
        {
            _avatar.Move(-_moveX, -_moveY);
        }
    }
}
