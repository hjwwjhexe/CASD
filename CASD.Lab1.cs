double SizeOfVector(int[] vector, int sizeOfMatrix, int[][] matrix)
{
    int[] matrix1;
    matrix1 = new int[sizeOfMatrix];
    int summa = 0;
    for (int i = 0; i < sizeOfMatrix; i++)
    {
        summa = 0;
        for (int j = 0; j < sizeOfMatrix; j++)
        {
            summa += vector[j] * matrix[j][i];
        }
        matrix1[i] = summa;
    }
    summa = 0;
    for (int i = 0; i < sizeOfMatrix; i++)
    {
        summa += matrix1[i] * vector[i];
    }
    return Math.Sqrt(summa);
}
int MatrixSymmety(int sizeOfMatrix, int[][] matrix)
{
    for (int i = 0; i < sizeOfMatrix; i++)
    {
        for (int j = 0; j < sizeOfMatrix; j++)
        {
            if (matrix[i][j] != matrix[j][i])
            {
                return 0;
            }
        }
    }
    return 1;
}
string txt = "TDoc.txt";
string? a;
int sizeOfMatrix = 0;
int[] vector = new int[0];
int[][] matrix = new int[0][];
try
{
    StreamReader str = new StreamReader(txt);
    sizeOfMatrix = Convert.ToInt32(str.ReadLine());
    vector = new int[sizeOfMatrix];
    matrix = new int[sizeOfMatrix][];
    for (int i = 0; i < sizeOfMatrix; ++i)
    {
        a = str.ReadLine();
        matrix[i] = a.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    }
    a = str.ReadLine();
    vector = a.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    str.Close();
}
catch (Exception Message)
{
    Console.WriteLine("Ошибка: " + Message.Message);
}
if (MatrixSymmety(sizeOfMatrix, matrix) == 1)
{
    Console.WriteLine("Матрица симметрична.");
}
if (MatrixSymmety(sizeOfMatrix, matrix) == 1)
{
    Console.WriteLine("Ответ: ");
    Console.WriteLine(SizeOfVector(vector, sizeOfMatrix, matrix));
}
else
{
    Console.WriteLine("Матрица не симметрична, ответа нет.");
}