namespace P09.Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = null;
            int sumBestDna = int.MinValue;
            int[] bestDna = new int[0];
            int leftmostIndex = int.MaxValue;
            int highestLengthOfSequence = int.MinValue;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = input
                    .Split('!')
                    .Select(int.Parse)
                    .ToArray();
                int lengthOfSequence = 0;
                int sumOfDna = 0;
                for (int i = 0; i < dna.Length; i++)
                {
                    sumOfDna += dna[i];
                }
                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] == 1)
                    {
                        for (int j = 0; j < dna.Length; j++)
                        {
                            if (dna[j] == 1)
                            {
                                lengthOfSequence++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (lengthOfSequence > highestLengthOfSequence)
                    {
                        highestLengthOfSequence = lengthOfSequence;
                        lengthOfSequence = 0;
                        Array.Resize(ref bestDna, dna.Length);
                        bestDna = dna;
                        leftmostIndex = i;
                        sumBestDna = sumOfDna;
                    }
                    else if (lengthOfSequence == highestLengthOfSequence)
                    {
                        if (leftmostIndex > i)
                        {
                            lengthOfSequence = 0;
                            Array.Resize(ref bestDna, dna.Length);
                            bestDna = dna;
                            leftmostIndex = i;
                            sumBestDna = sumOfDna;
                        }
                        else if (leftmostIndex == i)
                        {
                            if (sumOfDna > sumBestDna)
                            {
                                lengthOfSequence = 0;
                                Array.Resize(ref bestDna, dna.Length);
                                bestDna = dna;
                                leftmostIndex = i;
                                sumBestDna = sumOfDna;
                            }
                        }    
                    }
                }
            }
        }
    }
}