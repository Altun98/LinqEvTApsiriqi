namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseRepository<Employee> rep = new BaseRepository<Employee>();
            //tesadufi olaraq 3000 sexsin ef ile elave edilmesi 
            //List<Employee> empList = new List<Employee>();
            //for (int i = 0; i < 3000; i++)
            //{
            //    Employee emp1 = new Employee()
            //    {
            //        FirstName = FakeData.NameData.GetFirstName(),
            //        LastName = FakeData.NameData.GetSurname(),
            //        Age = FakeData.NumberData.GetNumber(18, 65)
            //    };
            //    rep.Add(emp1);
            //}


            //var result = rep.GetAllByID(987);
            //Console.WriteLine($"{result.ID} {result.FirstName} {result.LastName} {result.Age}");
            //Console.WriteLine("=============================================");
            //result.FirstName = "ATL";
            //result.LastName = "ACADEMY";
            //result.Age = 123;
            //rep.Update(result);

            //var result1= rep.GetAllByID(234);
            //Console.WriteLine($"{result1.ID} {result1.FirstName} {result1.LastName} {result1.Age}");

            //rep.Delete(rep.GetAllByID(12));
            //Console.WriteLine("secilmis sexs silindi");



            #region LINQ

            //var _count = (from emp in rep.GetAll()
            //              select emp).Count();
            //Console.WriteLine("sayi:{0}",_count);

            //var _sum = (from emp in rep.GetAll()

            //            select emp.Age).Sum();
            //Console.WriteLine($"yaslarinin cemi: {_sum}");

            //var _min = (from emp in rep.GetAll()
            //            select emp.Age).Min();
            //Console.WriteLine($"Minimum yaz: {_min}");
            //var _max = (from emp in rep.GetAll()
            //            select emp.Age).Max();
            //Console.WriteLine($"Maxsimum yas: {_max}");
            //var _avg = (from emp in rep.GetAll()
            //            select emp.Age).Average();
            //Console.WriteLine($"Ortalama yas: {_avg}");

            //var _disting = (from emp in rep.GetAll()
            //                select new
            //                {
            //                    emp.FirstName,

            //                    emp.LastName,
            //                    emp.Age
            //                }).Distinct();
            //foreach (var item in _disting)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
            //}
            //Console.WriteLine("**************************************************************************************************");
            //Console.WriteLine($"tekrarsiz deyerlerin sayi:{_disting.Count()}");

            //var _between = (from emp in rep.GetAll()
            //                where emp.FirstName.StartsWith("A")
            //                select emp).ToList().Count;
            //Console.WriteLine($"A ile baslayan adlarin sayi:{_between}");
            //var _between1 = (from emp in rep.GetAll()
            //                where emp.FirstName.EndsWith("a")
            //                select emp).ToList().Count;
            //Console.WriteLine($"a ile biten adlarin sayi:{_between1}");
            //var _between2 = (from emp in rep.GetAll()
            //                where emp.FirstName.Contains("w")
            //                select emp).ToList().Count;
            //Console.WriteLine($" adinin daxilinde w olan sexlerin sayi:{_between2}");
           
            #endregion


        }
    }
}
