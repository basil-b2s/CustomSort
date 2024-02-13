using CustomSort;
//using Sort;

class Program
{
    public List<Student> students;
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>
        {
            new Student { Id = 100, Name = "Ram", Age = 15, Score = 99 },
            new Student { Id = 121, Name = "Arjun", Age = 19, Score = 89.8 },
            new Student { Id = 101, Name = "Rahul", Age = 15, Score = 99.9 },
            new Student { Id = 102, Name = "Riya", Age = 16, Score = 78.5 }
        };


        Sort.BubbleSort(students, (x, y) => x.Name.CompareTo(y.Name));

        Console.WriteLine("Sorted based on name");
        PrintData(students);

        Sort.BubbleSort(students, (x, y) => x.Age.CompareTo(y.Age));

        Console.WriteLine("Sorted based on Age");
        
        PrintData(students);

        Sort.BubbleSort(students, (x, y) => Comparer<double>.Default.Compare(x.Score, y.Score));

        Console.WriteLine("Sorted based on Score");

        PrintData(students);
    }

    static void PrintData(List<Student> students)
    {
        foreach (Student student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}");
        }
    }
}