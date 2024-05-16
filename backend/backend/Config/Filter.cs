using Microsoft.Extensions.Options;
namespace backend.Config;
{
    public class Filter<T>
    {
        public Filter()
        {
        }

        // T tipe data generic, bisa apa aja
        public static T filter(List<T> data, string key, int value)
        {
            try
            {
                if (data == null || data.Count == 0)
                {
                  throw new Exception("No data found");
                }

                if (string.IsNullOrEmpty(key))
                {
                    throw new Exception("Key cannot be null or empty.");
                }

            
                foreach (T item in data)
                {
                    if (Convert.ToInt16(item.GetType().GetProperty(key).GetValue(item)) == value)
                    {
                        return item;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return default(T);
        }
    


    }
}
