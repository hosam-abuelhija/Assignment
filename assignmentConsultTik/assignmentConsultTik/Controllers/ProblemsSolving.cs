using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentConsultTik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProblemsSolving : ControllerBase
    {

        [HttpPost("reverse-array")]
        public IActionResult ReverseArray([FromBody] int[] arr)
        {
            for (int left = 0, right = arr.Length - 1; left < right; left++, right--)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            //Array.Reverse(arr); Additional
            return Ok(arr);
        }

        [HttpPost("copy-array")]
        public IActionResult CopyArray([FromBody] int[] arr)
        {
            int[] newArr = new int[arr.Length];
            //Array.Copy(arr, newArr, arr.Length); Additional

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return Ok(newArr);
        }

        [HttpPost("count-frequency")]
        public IActionResult CountFrequency([FromBody] int[] arr)
        {
            //var frequency = arr.GroupBy(a => a).ToDictionary(g => g.Key, g => g.Count()); Additional
            //return Ok(frequency); Additional
            int N = arr.Length;
            int[] freq = new int[N];
            int count;

            for (int i = 0; i < N; i++)
            {
                freq[i] = -1;
            }

            for (int i = 0; i < N; i++)
            {
                count = 1;
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                }
                if (freq[i] != 0)
                {
                    freq[i] = count;
                }
            }

            var result = new List<(int Number, int Frequency)>();
            for (int i = 0; i < N; i++)
            {
                if (freq[i] != 0)
                {
                    result.Add((arr[i], freq[i]));
                }
            }

            return Ok(result);
        }



    }
}
