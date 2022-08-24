using SinglyLinkedListWithSolve_PuzzleMethods;

var list = new LinkedList();

list.Print();
list.InsertNodeAtLast(1);
list.InsertNodeAtLast(2);
list.InsertNodeAtLast(3);
list.InsertNodeAtLast(4);
list.InsertNodeAtLast(5);
list.InsertNodeAtLast(6);
list.InsertNodeAtLast(7);
list.InsertNodeAtLast(8);
list.InsertNodeAtLast(9);

list.Print();


Console.WriteLine("Puzzle Method");
list.PrintPuzzleMethod();

Console.WriteLine("Solve Method");
list.PrintSolveMethod();

