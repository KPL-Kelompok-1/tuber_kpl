using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_KPL.Validation
{
    internal class ForumValidation
    {
        public static String ValidateForum(string asalDesa, string name, string pertanyaan)
        {
            var forms = new Dictionary<string, string>
            {
                {"name", name},
                {"asalDesa", asalDesa}, 
                {"pertanyaan", pertanyaan}
            };

            if (forms.ContainsValue(""))
            {
                return "Tidak boleh ada field yang kosong!";
            }

            foreach (var form in forms)
            {
               if (string.IsNullOrEmpty(form.Value))
                {
                    return form.Key + " tidak boleh kosong!";
                }

               if (form.Key != "pertanyaan" && form.Value.Length < 5)
                {
                    return form.Key + "minimal 5 karakter!";
                }

               if (form.Key == "asalDesa"  && form.Value.Length > 50)
                {
                      return form.Key + " maksimal 50 karakter!";
                }

               if (!string.IsNullOrEmpty(form.Value) && form.Key == "pertanyaan" && form.Value.Length < 10)
                {
                    return form.Key + " minimal 10 karakter!";
                }

               if (!string.IsNullOrEmpty(form.Value) && form.Key == "pertanyaan" && form.Value.Length > 1000)
                {
                      return form.Key + " maksimal 1000 karakter!";
                 }
            }
            return "true";
        }
    }
}
