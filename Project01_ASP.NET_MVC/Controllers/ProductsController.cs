using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;
namespace Books.Controllers
{
    public class ProductsController : Controller
    {
        List<productModel> products = new List<productModel>()
        {
            new productModel {Id=1,Title="أشياء ممكنة جدا",Description=" عبارة عن رسائل تحفيزية وإيجابية وعبارات إيحائية مختصرة تكون كصديق لك يحاول دعمك ",Price=29,Image="https://bookccino.com/image/cache/3c43dc1e2e165345257ebfd4bcc3aaae-500x500.jpg"},
            new productModel {Id=2,Title="أنا قبل كل شيء",Description="قصة فتاة فقدت بصرها. وبعد ٩ سنوات من العيش في الظلام، يعود لها البصر ولكن.... (لم تُخبر أحد) ",Price=57.50f,Image="https://bookccino.com/image/cache/fdfdd220a3502418e446401023c9aa48-500x500.jpg"},
            new productModel {Id=3,Title="حين بلغ القلب عتيا",Description="خواطر ونصوص متنوعة",Price=35,Image="https://bookccino.com/image/cache/70a470d6121d8f4734f9d8f8017ab5f5-500x500.jpg"},
            new productModel {Id=4,Title="هارون أخي",Description="هذا الكتاب يستعرض: — تعريف الانطوائية وما صحة أنها مرض يجب علاجه و سيتحدث أيضًا عن أبرز المشاكل التي واجهت الانطوائي . و ما جدوى التفكير والعمل الجماعي؟ وهل نحن نطبقه بشكل سليم أم لا؟ وماذا علينا أن نفعل لنجعله أكثر اتساقًا مع جميع الشخصيات الانطوائية والاجتماعية؟",Price=52,Image="https://bookccino.com/image/cache/0f7d9e7693f0916da12b02ad4aab3849-500x500.png"},
            new productModel {Id=5,Title="لن نصنع الفلك",Description="انزلقنا إلى الدوائر الخاطئة في الأوقات الصحيحة، ثم عدونا إلى الدوائر الصحيحة في الأوقات الضائعة، لم نكن يومًا إلا غرباء أو متأخرين، تعوزنا الحماسة، أو تنقصنا المعركة، تفوتنا لحظات الذروة، لخوف مرضي من الزيف، أو لنقص وراثي في المشهدية، أحببنا من كان ينبغي أن نحبهم، وقت أن كنا من لا يجب أن نكون، ثم أحببنا من لا يجب أن نحبهم، وقت أن أصبحنا أنفسنا، تتفلت منا الدنيا دائمًا على لحظات قليلة، أو هكذا نخدع أنفسنا، ونرجو، في كل مرة، بعض الدقائق الإضافية، فما زلنا نملك أملًا لا نعرف ماذا نفعل به.",Price=25.88f,Image="https://bookccino.com/image/cache/918516ad0c422c3a71c25494a9569cf6-500x500.jpg"},
            new productModel {Id=6,Title="بك الملاذ",Description="قد تظن أنك مُظلِم ولكن سرعان ما يتلاشى ظنك ويضيئك الله .قد تظن أنك وحيد ولكن يحتويك الله فتشعر كأن العالم كله ملكُك وتشعر بالاكتفاء .قد تظن أن حياتك تعيسة كئيبة وعندما عشتها لله أصبحت مختلفة تماماً بل جميلة.قد تظن وتظن و تظن ولكن تتكسر ظنونك أمام قدرة الله وعظمته فتُغنيك وتنجيك وتشعر بالاكتفاء التام",Price=74.75f,Image="https://bookccino.com/image/cache/7a8426e80c49ace9aed6dade49383273-210x240.jpg"},
            new productModel {Id=7,Title="جرعة أمل",Description=" قال أحد العلماء: \"إذا تكلمت بكلمة فاعتبرها قبل أن تتكلم بها، فإنك مالكها ما لم تخرجها من فِــيك، فإذا أخرجتها ملكتها فتصير أسيراً لها\".",Price=40.25f,Image="https://bookccino.com/image/cache/1c4f46ff4858154031bbc2acb4afb37a-210x240.jpg"},
            new productModel {Id=8,Title="عزيزتي السعادة",Description="قد تكون كلمة أو سطر أو كتاب هي بداية نموك العقلي وتحرير مشاعرك السلبية ..السعادة في أسطر تحملها غيوم التفاؤل كي ترحل بك إلى عالم مليء بالإيجابية .....",Price=51.57f,Image="https://bookccino.com/image/cache/4de71b7b0a832ab78ffca10f69e0cfa1-500x500.jpg"},
            new productModel {Id=9,Title="لا اسم له",Description="هذا كتاب لكنه ليس الكتاب الحقيقي، اسمك هو اسمك لكن أسماء الأشياء غير حقيقية، الكتاب يحوي كل الكتب، ويكتب أضعافها ولا ينضب، في الأصل أنت بلا اسم، الكتاب الحقيقي ما تعيشه، ذاتك سطر حي، والذات الأولى كاتب الكتاب الحقيقي، باب كل الأشياء. ",Price=57.50f,Image="https://bookccino.com/image/cache/436dfbd2f2074fb7a7aa7da3591cfb9a-500x500.jpeg"},
            new productModel {Id=10,Title="ميلاد كلمات",Description="خواطر نثرية تجسد الكثير من المواقف و المشاعر التي تختلج في أفئدتنا جميعاً ",Price=40.25f,Image="https://bookccino.com/image/cache/9df652c53cc8065acd0df5c2a3679302-500x500.jpg"},
            new productModel {Id=11,Title="نبأ يقين",Description="نظرتنا لأنفسنا هي التي تحدد قيمتنا في الحياة! فرق كبير بين من لا يرى من وظيفته إلا الأجر الذي يجنيه وبين من يرى الاثر الذي يتركه! كل عمل مهما كان بسيطا يترك اثر في هذا العالم، تحتاج فقط ان تنظر الى هذا الاثر!",Price=50,Image="https://bookccino.com/image/cache/8fd99c1739015dcf3c9a05938e12716b-210x240.jpeg"},
            new productModel {Id=12,Title="حديث الصباح",Description="الكتاب عبارة عن مقالات متنوعة ، يخاطب الكاتب فيها عقلك تارة  ومشاعرك تارةً أخرى",Price=51.75f,Image="https://bookccino.com/image/cache/10a620a4ec4bce8dbd7dd38420a849e1-500x500.jpg"}
        };
        public IActionResult Index()
        {
            ViewData["products"] = products;
            return View();
        }
        public IActionResult Details(int? id=1)
        {
            productModel product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return Content("Not found");
    }
            else
            {
                ViewData["products"] = product;
                return View("Details");
            }
        }
    }
}
