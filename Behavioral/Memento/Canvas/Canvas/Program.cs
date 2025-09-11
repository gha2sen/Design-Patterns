var canvas = new CanvasSpace();
var history = new CanvasHistory();

var id= Guid.NewGuid();

history.Save(canvas.AddShape(new Circle(id, (0, 0), "red")));
Console.WriteLine(canvas.Draw());

history.Save(canvas.ChangeColor(id, "blue"));
Console.WriteLine(canvas.Draw());

canvas.MoveShape(id, -5, 5);
Console.WriteLine(canvas.Draw());

history.Undo();

canvas.Restore(history.Undo());
Console.WriteLine($"undo twice: {canvas.Draw()}");






