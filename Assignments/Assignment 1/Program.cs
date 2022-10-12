using System;
using System.Net.Http.Headers;

namespace SescriptiveStatics 
{
    class Program
    {
        private static int m_SIZE = 10;
        private static StudentData[] StudentData = new StudentData[m_SIZE] ;

        public static void LoadData()
        {
            TextDataHandler handler = new TextDataHandler("students_score.txt");
            
            for (int i = 0; i < m_SIZE; i++)
            {
                String str = handler.Read();
                //Console.WriteLine(str);
                StudentData student = new StudentData(str);
                StudentData[i] = student;
            }
        }
        public static float SummaryStatistics()
        {
            /* 
            1) Mean 79.16
            2) Range 41.67
            3) Minimum 55.32
            4) Maximum 96.99
            5) Count 10
            */
            float sum = 0.0f;
            float mx_num = -1.0f, min_num = 10000000.0f;
            for (int i = 0; i < m_SIZE; i++)
            {
                float score = StudentData[i].student_score;
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
            float mean = sum / m_SIZE;
            //float range = Math.Round(mx_num - min_num, 2);
            float range = mx_num - min_num;
            int idx = 0;
            Console.WriteLine(String.Format("{0}) Mean {1}", ++idx, mean));
            Console.WriteLine(String.Format("{0}) Range {1}", ++idx, range));
            Console.WriteLine(String.Format("{0}) Minimum {1}", ++idx, min_num));
            Console.WriteLine(String.Format("{0}) Maximum {1}", ++idx, mx_num));
            Console.WriteLine(String.Format("{0}) Count {1}", ++idx, m_SIZE));
            return mean;
        }
        public static void StandardDeviation(float mean)
        {
            float sum = 0;
            for (int i = 0; i < m_SIZE; i++)
            {
                float score = StudentData[i].student_score;
                sum += (score - mean)* (score - mean);
            }
            float sd =(float)Math.Sqrt(sum / m_SIZE);
            sd = (float)Math.Round(sd, 2);
            int idx = 5;
            Console.WriteLine(String.Format("{0}) StandardDeviation {1}", ++idx, sd));
        }
        static void Main(string[] args)
        {
            LoadData();
            float mean = SummaryStatistics();
            StandardDeviation(mean);

        }
    }
}