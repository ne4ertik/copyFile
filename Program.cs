namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalnyFile1 = @"C:\Users\lazur\OneDrive\Документы\код.txt";
            string originalnyFile2 = @"C:\Users\lazur\OneDrive\Документы\ABC.txt";
            string copyFile = @"C:\My works for college"; 
            bool a = true; //перезапись

            try
            {
                File.Copy(originalnyFile1, copyFile, a);
                Console.WriteLine("Файл успешно скопирован.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
            }

            try
            {
                File.Copy(originalnyFile2, copyFile, a);
                Console.WriteLine("Файл успешно скопирован.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
            }
        }
    }
}
