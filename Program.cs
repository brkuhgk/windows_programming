using System.Security.Cryptography.X509Certificates;

int m_SIZE = 10;
StudentData[] students = new StudentData[m_SIZE];

void LoadData()
{
    TextDataHandler handler = new TextDataHandler("students_score.txt");
    string str = handler.read();
    string[] strArr = str.Split(" ");
    int j = 0;
    for(int i = 0; i <m_SIZE; i++)
    {
        string new_string = (strArr[j] +" "+ strArr[j + 1]).ToString();
        StudentData studentCard = new StudentData(new_string);
        j += 2;
        students[i] = studentCard;
    }

    handler.close();


}

double SummaryStatistics()
{
    /* 
    1) Mean 79.16
    2) Range 41.67
    3) Minimum 55.32
    4) Maximum 96.99
    5) Count 10
    */
    double sum = 0;
    double mx_num = -1.0, min_num = 10000000.0;


    for (int i = 0; i < m_SIZE; i++)
    {
        double score = students[i].student_score;
        sum += score;
        if (score > mx_num)
        {
            mx_num = score;
        }
        if (score < min_num)
        {
            min_num = score;
        }
    }
    double mean = sum / m_SIZE;
    double range = Math.Round(mx_num - min_num,2);
    int idx = 0;
    Console.WriteLine(String.Format("{0}) Mean {1}", ++idx, mean));
    Console.WriteLine(String.Format("{0}) Range {1}", ++idx, range));
    Console.WriteLine(String.Format("{0}) Minimum {1}", ++idx, min_num));
    Console.WriteLine(String.Format("{0}) Maximum {1}", ++idx, mx_num));
    Console.WriteLine(String.Format("{0}) Count {1}", ++idx, m_SIZE));

    return mean;
}


void StandardDeviation(double mean)
{
    double sum = 0;
    for(int i = 0; i < m_SIZE; i++)
    {
        double score = students[i].student_score;
        sum += Math.Pow(score-mean,2);

    }
    double sd = Math.Round(Math.Sqrt(sum / m_SIZE),2);
    int idx = 5;
    Console.WriteLine(String.Format("{0}) StandardDeviation {1}", ++idx, sd));

}

LoadData();
double mean = SummaryStatistics();
StandardDeviation(mean);













/*
 * Articles used
 https://www.c-sharpcorner.com/article/working-with-c-sharp-streamreader/

 */