namespace P07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companyBook = new Dictionary<string, List<string>>();
            string input = null;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] newEntry = input
                    .Split(" -> ")
                    .ToArray();
                string companyName = newEntry[0];
                string employeeId = newEntry[1];

                if (!companyBook.ContainsKey(companyName))
                {
                    companyBook.Add(companyName, new List<string> { employeeId });
                }
                else if (!companyBook[companyName].Contains(employeeId))
                {
                    companyBook[companyName].Add(employeeId);
                }
            }
            foreach (var company in companyBook)
            {
                Console.WriteLine(company.Key);
                company.Value
                    .ForEach(employeeId => Console.WriteLine($"-- {employeeId}"));
            }
        }
    }
}