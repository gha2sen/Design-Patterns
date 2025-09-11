
var avatar = new Avatar(10, 5);
var gameRound = new GameRound();


gameRound.Execute(new MoveCommand(avatar, 10, 50));
gameRound.Execute(new DefendCommand(avatar));
gameRound.Execute(new AttackCommand(avatar));