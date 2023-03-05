using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using TurkishTransformer.Factory;
using static System.Net.Mime.MediaTypeNames;
using static TurkishTransformer.Controllers.TransformerController;

namespace TurkishTransformer.Controllers
{
    public class TransformerController : Controller
    {
        [HttpPost("ConvertWordsToNumbers")]
        public IActionResult Post([FromBody] UserTextModel userTextModel)
        {
            var transformer = TransformerFactory.Create(TransformerFactory.NameOfInstance.TurkishTransformer) as TurkishTransformer;
            var output = transformer.Translate(userTextModel.UserText);
            return Ok(new { Output = output });
        }

        // Girdi modeli
        public class UserTextModel
        {
            public string UserText { get; set; }
        }

        // Çıktı modeli
        public class OutputModel
        {
            public string Output { get; set; }
        }
    }
}
