namespace Hand_in_w11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();
            var terminal = new Terminal(studentService);
            terminal.Menu();
        }
    }
}
