using MultiplayerGame.CommandInterface;

namespace MultiplayerGame.Invoker
{
    //invoker
    public class GameRound
    {
        private Stack<ICommand> _history = [];
        private Stack<ICommand> _unDoneCommands = [];

        public void Execute(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.Count == 0) return;

            var undoneCommnad = _history.Pop();

            undoneCommnad.Undo();

            _unDoneCommands.Push(undoneCommnad);
        }

        public void Redo()
        {
            if (_unDoneCommands.Count == 0) return;

            var undoneCommnad = _unDoneCommands.Pop();

            undoneCommnad.Execute();

            _history.Push(undoneCommnad);
        }

        public void Replay()
        {
            ReplayUntil(_unDoneCommands.Count);
        }

        public void ReplayUntil(int position)
        {
            for (int i = 0; i < _history.Count; i++)
            {
                Undo();
            }
            for (int i = 0; i < position; i++)
            {
                Redo();
            }
        }

        public void ReplayFromPostionWithCommands(int position, List<ICommand> commands)
        {

            ReplayUntil(position);
            commands.ForEach(c => _history.Push(c));
            _unDoneCommands.Clear();
        }


    }
}
