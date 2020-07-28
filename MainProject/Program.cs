using MainProject.ArrayExamples;
using MainProject.ArrayLeetCodeProblems;
using MainProject.StringLeetCodeProblems;
using System;
using System.Collections;
using System.Reflection;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {


            /*// Call Print array program
            //PrintArray printArrayObj = new PrintArray();
            //printArrayObj.PrintArrayElements();

            //call printreverse array
            PrintReverseArray reverobj = new PrintReverseArray();
            reverobj.ReverseArray();

            //sumofarray
            SumArray sumobj = new SumArray();
            sumobj.SumOfArray();

            //one to another array
            OnetoanotherArray otoaobj = new OnetoanotherArray();
            otoaobj.OtoT();

            //dictionary
            Dict dicObj = new Dict();
            dicObj.Dic();

            //merging the array
            MergingArray mergeObj = new MergingArray();
            mergeObj.MergeArray();

            //spiral form
            int[][] array = new int[4][];
            
            // for rows
            for(int i =0;i<4;i++)
            {
                array[i] = new int[4];
                // for columns
                for (int j=0;j<4;j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            SpiralForm spiralObj = new SpiralForm();
            spiralObj.SpiralPrint(array);

            //contigiussubarray
            int[] a = { -2,-3,4,-1,-2,1,5};
            ContiguosSubArray csObj = new ContiguosSubArray();
            Console.WriteLine(csObj.ContigousSubArray(a));

            //kth smallest number
            int[] array = { 7, 10, 4, 3, 20, 15 };

           int k = 3;
            KthSmallestnumber kObj = new KthSmallestnumber();
         var result =   kObj.KthSmallest(array, k);
            Console.WriteLine(result);

            //missing element
            int[] array =  { 1, 2, 3, 5 };

            MissingNumbers mObj = new MissingNumbers();
           var sum=  mObj.Missing(array,4);
            Console.WriteLine(sum); 

            //leader
            Leaders lObj = new Leaders();
            int[] array = { 16, 17, 4, 3, 5, 2 };
            int n = array.Length;
            lObj.Leader(array, n);

            //foreachint array
            ForEachArray array = new ForEachArray();
            array.Employee();

            //foreach in sring array
            ForEachArray arr = new ForEachArray();
            arr.Employee();


            UniqueElementInArray dicti = new UniqueElementInArray();
            dicti.Unique();

            //candies
            Candies candy = new Candies();
            candy.KidsCandies();

            //small numbers
            int[] nums = new int[5] { 8,1,2,2,3};
            SmallNumbers sObj = new SmallNumbers();
            sObj.Small(nums);

            //encodinglist
            int[] nums = new int[] { 1, 2, 3, 4 };
            EncodingList eObj = new EncodingList();
            eObj.Encoding(nums);


            //eventdigits in an array
            int[] nums = new int[] {12,345,2,6,7896 };
            DigitEvenorNot eObj = new DigitEvenorNot();
            eObj.Even(nums);

            //busystudents
            int[] startTime = new int[] { 1,2,3};
            int[] endTime = new int[] { 3,2,7};
            int queryTime = 4;
            StudentsHW obJ = new StudentsHW();
            obJ.BusyStudent(startTime,endTime,queryTime);

            //string replace

            string address = "1.1.1.1";
            Replace rObj = new Replace();
            rObj.Replc(address);

            //creating queue using stack
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine(q.Dequeue() +" ");
            Console.WriteLine(q.Dequeue() + " ");
            Console.WriteLine(q.Dequeue());

            //next greatest elemet
            int[] array = new int[] { 4,5,2,25};
            NextGreatestElement nObj = new NextGreatestElement();
            nObj.Greatest(array);


            //incrementmatrix
            int n = 2;
            int m = 3;
            
            int[][] indices = new int[2][];
            indices[0] = new int[2];
            indices[1] = new int[2];

            indices[0][0] = 0;
            indices[0][1] = 1;
            indices[1][0] = 1;
            indices[1][1] = 1;


            IncrementMatrix obj = new IncrementMatrix();
            obj.Odd(n,m,indices);

            //random 
            int n = 5;
            UniqueElem uniqueObj = new UniqueElem();
            uniqueObj.SumZero(n);

            //sort array by its parity
            int[] array = new int[4] {3,1,2,4 };
            EvenOdd eObj = new EvenOdd();
            eObj.SortArrayByParity(array);

            //roman to integer
            string str = "III";
            RomantoInteger rObj = new RomantoInteger();
            // rObj.Roman(r);
            rObj.RomantoDec(str);

            //string to integer
            string str = "-1345";
            StringtoInt Obj = new StringtoInt();
            Obj.StringtoIn(str);

            //index
            string s1 = new string("sweater");
            string s2 = new string("eat");
            IndexofStr iObj = new IndexofStr();
            iObj.Index(s1,s2);

            //squares of an array
            int[] array = new int[] { -4, -1, 0, 3, 10 };
            Squares Obj = new Squares();
            Obj.Square(array);

            //sortbyparity2
            int[] array = new int[4] { 4,2,5,7};
            SortParity2 sObj = new SortParity2();
            sObj.Parity(array);

            //Luckynumber
            int[][] matrix = new int[3][];
            matrix[0] = new int[3];
            matrix[1] = new int[3];
            matrix[2] = new int[3];

            matrix[0][0] = 3;
            matrix[0][1] = 7;
            matrix[0][2] = 8;
            matrix[1][0] = 9;
            matrix[1][1] = 11;
            matrix[1][2] = 13;
            matrix[2][0] = 15;
            matrix[2][1] = 16;
            matrix[2][2] = 17;

            LuckyNumb lObj = new LuckyNumb();
            lObj.Lucky(matrix);

            //reverse a string
            char[] s = new char[] { 'h', 'e','l','l','o'} ; 
            

            Reverse rObj = new Reverse();
            rObj.ReverseString(s);

            //remove vowels
            string s = new string("leetcode is a community for coders");

            RemoveVowels rObj = new RemoveVowels();
            rObj.Vowels(s);

            //max2arrays
            int[] nums = new int[4] { 3,4,5,2};
            Max2Arrays mObj = new Max2Arrays();
            mObj.MaxProduct(nums);

            //Flipping an Image
            int[][] matrix = new int[3][];
            matrix[0] = new int[3];
            matrix[1] = new int[3];
            matrix[2] = new int[3];


            matrix[0][0] = 1;
            matrix[0][1] = 1;
            matrix[0][2] = 0;
            matrix[1][0] = 1;
            matrix[1][1] = 0;
            matrix[1][2] = 1;
            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 0;

            FlippingImage fObj = new FlippingImage();
            fObj.FlipAndInvertImage(matrix);

            //running sums
            int[] nums = { 1,2,3,4};
            RunningSum rObj = new RunningSum();
            rObj.Running(nums);

            //palindrome

            string s = "A man, a plan, a canal: Panama";
            s.ToLower();

            Palindrome pObj = new Palindrome();
            pObj.Pal(s);

            //shuffle an array
            int[] nums = { 1,1,2,2};
            int n = 2;
            Shuffle sObj = new Shuffle();
            sObj.Shuff(nums, n);

            //arthmetic progression
            int[] arr = { 3,5,1};
           
            Arthmetic_progression aObj = new Arthmetic_progression();
            aObj.CanMakeArthmeticProgression(arr);

            //tolowercase
            string str = "Hello";
            ToLowerCaseUsingASCII tObj = new ToLowerCaseUsingASCII();
            tObj.ToLowerV(str);

            //salary
            int[] salar = { 4000,3000,1000,2000};
            MinMax mObj = new MinMax();
            mObj.Salary(salar);*/

            //reverse a number
            int x = -123;
            ReverseNum rObj = new ReverseNum();
            rObj.Num(x);



















        }
    }
}
