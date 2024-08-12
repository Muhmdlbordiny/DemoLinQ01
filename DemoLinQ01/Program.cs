using Day_01_G03;

namespace DemoLinQ01
{
    internal class Program
    {
        static dynamic print(dynamic x)
        {
            return x;
        }
        static void Main(string[] args)
        {
            #region [var - dynamic]
            //C# Keyword :Implicitly typed local varible[var - dynamic]

            ///var 
            ///var Data01 = "Ahmed"; //Comiler will detect datatype  of local varible Based on Initial value , At Compilation Type
            ///Must be Initialzed
            /// cant initailized local varible with null 
            /// cant Change  Datatype of the local varible  After initalixation
            /// cant use var as a parameter or Return type
            //var x = 12;
            //var x;//invaild
            //var x = null;// Invaild

            ///dynamic 
            ///ClR will detect  datatype of local varible based on last value , at Runtime
            ///Non Need to be Initialized 
            ///can initialzied local varible with null
            ///can Change datatype of local varible After Initalization
            ///can use dynamic as a parameter or Return Type
            ///Be careful when using dynamic keyword


            dynamic Data02 = "Ahmed"; //Like var in Js
            Data02 = 5;
            Data02 = 'A';
            Data02 = 2.59;
            Console.WriteLine(Data02.GetType().Name);
            dynamic x;
            //Console.WriteLine(x);
            //dynamic y = null; 
            #endregion
            #region Extention Method
            //  int Numbers = 12345; //54321
            //  //var Result = IntExtention.Reverse(Numbers);
            //  //Console.WriteLine(Result);
            //int Result =  Numbers.Reverse();
            //  Console.WriteLine(Result);
            //  var M = 1.2 % 10;
            //  Console.WriteLine(M);
            #endregion
            #region Anonymous Type
            //Employee Emp01 = new Employee() { Id =100 , Name = "Ahmed", Salary = 6000};
            //Console.WriteLine(Emp01);
            //var Emp02 = new { Id = 100, Name = "Ahmed", Salary = 6000.500 }; // anonymous type
            //var Emp03 = new { Id = 100, Name = "Ahmed", Salary = 6000.500 }; // anonymous type

            //Emp02.Id = 5;//Invaild  -- immutable datatype  - can`t change value After Creation
            //var Emp03 = Emp02 with { Id =50};
            // Console.WriteLine(Emp03);
            // Console.WriteLine(Emp02.GetType().Name);//<>f__AnonymousType0`3
            // Console.WriteLine(Emp03.GetType().Name);//<>f__AnonymousType0`3
            //the same anonymous long as
            // The property Naming [Case sensitive]
            //The property order 

            //if (Emp02.Equals(Emp03))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else { Console.WriteLine("Not equals"); }
            #endregion
            #region LinQ overview
            //LinQ -- Language integrated Query
            //  : +40 Extention Methods (LinQ Operator) using Againsit Any Data [Data in sequence], Reradless Data store
            //  :13 Category
            //  :LinQ Operator  Exist class "Enumerable"

            //Sequence : object from class implement interface "IEnumerable"

            //local sequence :  L20,L2XMl
            // remote seuqnce: L2EfC

            // input sequence : --> LinQ OPerator  --> OutputSequence 
            // input sequence : --> LinQ OPerator  --> one value 
            // List<int>Numbers = new List<int>() { 1,2,3,4,5,6};
            //var Result =  Enumerable.Where(Numbers,N=>N%2==0);
            //var Result =  Numbers.Where(N => N % 2 == 0);
            //Numbers.Any();
            // var Result = Enumerable.Range(0, 10);
            //
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion
            #region Linq Syntax 

            //Linq Syntax 
            //1.Fluent Syntax
            //use LinQ Method 
            //1.1 Linq operator as a class member method -- throught class "Enumerable"
            //1.2  Linq operator as a Extention Method Through The Sequence [Recommanded]
            ///2.Query Syntax[Query Expression] Like Sql query
            ///start with from 
            ///end with select or group by
            //List<int> ints = new List<int>() { 9,5,3,4,8,7,6,2};
            //var result = from N in ints 
            //             where N % 2 ==0
            //             select N;
            //foreach (int i in result)
            //    Console.WriteLine(i); 
            #endregion
            #region Excution Linq
            // LinQ Execution Ways 
            //1.Differed execution ways  :10 Category 
            //2.immidiate execution way  :3 category[Elements operator - castingOperator - aggregate OPrators]

            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var Result = Nums.Where(x => x%2==0); // where is Differed 
            //Nums.AddRange(new int[] {10,20,30});
            //foreach (var item in Result) // here 
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var Result = Nums.Where(x => x % 2 == 0).ToList(); // where is Immidate 
            //Nums.AddRange(new int[] { 10, 20, 30 });
            //foreach (var item in Result) // here 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 
            Console.WriteLine(ListGenerator.ProductsList[0]);
            #endregion






        }
    }
}
