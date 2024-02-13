
namespace compareTriplets
{
    public class CompareProvider
    {
        /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {

            List<int> result = new List<int>
        {
            Enumerable.Range(0, a.Count).Sum(i => (a[i] > b[i]) ? 1 : 0),
            Enumerable.Range(0, a.Count).Sum(i => (a[i] < b[i]) ? 1 : 0)
        };

            return result;
        }

    }
}