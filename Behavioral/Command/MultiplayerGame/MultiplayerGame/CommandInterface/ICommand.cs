namespace MultiplayerGame.CommandInterface
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
