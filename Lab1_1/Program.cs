using Lab1_1;

// Exersize 2

Console.WriteLine("Eneter exersize number"); 
string num_ex = Console.ReadLine(); // Ввод номера задания

Exersizes object_for_program = new Exersizes();

switch (num_ex)
{
    case "1":
        object_for_program.exerszie_1();
        break;
    case "2":
        object_for_program.exersize_2();
        break;
    case "3":
        object_for_program.exersize_3();
        break;
    case "all":
        object_for_program.exerszie_1();
        object_for_program.exersize_2();
        object_for_program.exersize_3();
        break;
}
