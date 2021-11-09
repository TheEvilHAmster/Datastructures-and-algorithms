namespace Datastructures_and_algorithms
{
    
    public class BinarySearchInt
    {
        private int[] searchArr;

        BinarySearchInt(int[] arr)
        {
            searchArr = arr;
        }

        public static bool SearchNum(int numberToSearch, int[] searchArr)
        {
            int min = 0;
            int max = searchArr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (numberToSearch == searchArr[mid])
                {
                    return true;
                }
                else if(numberToSearch < searchArr[mid])
                {
                    max = mid;
                }
                else if (numberToSearch > searchArr[mid])
                {
                    min = mid;
                }
                
            }
            
            return false;
        }
    }
}