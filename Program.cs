namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalnyFile = @"C:\Users\lazur\OneDrive\Документы\код.txt"; 
            string copyFile = @"C:\My works for college"; 
            bool a = true; //перезапись

            try
            {
                File.Copy(originalnyFile, copyFile, a);
                Console.WriteLine("Файл успешно скопирован.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
            }
            
        }
    }
}
