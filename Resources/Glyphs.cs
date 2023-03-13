using System.Linq;
using System.Reflection;

namespace SitelenPonaKeyboard.Resources
{
    public static class Glyphs
    {
        public static readonly Glyph a = new Glyph("a","󱤀");
        public static readonly Glyph akesi = new Glyph("akesi","󱤁");
        public static readonly Glyph ala = new Glyph("ala","󱤂");
        public static readonly Glyph alasa = new Glyph("alasa","󱤃");
        public static readonly Glyph ale = new Glyph("ale","󱤄");
        public static readonly Glyph anpa = new Glyph("anpa","󱤅");
        public static readonly Glyph ante = new Glyph("ante","󱤆");
        public static readonly Glyph anu = new Glyph("anu","󱤇");
        public static readonly Glyph awen = new Glyph("awen","󱤈");
        public static readonly Glyph e = new Glyph("e","󱤉");
        public static readonly Glyph en = new Glyph("en","󱤊");
        public static readonly Glyph esun = new Glyph("esun","󱤋");
        public static readonly Glyph ijo = new Glyph("ijo","󱤌");
        public static readonly Glyph ike = new Glyph("ike","󱤍");
        public static readonly Glyph ilo = new Glyph("ilo","󱤎");
        public static readonly Glyph insa = new Glyph("insa","󱤏");
        public static readonly Glyph jaki = new Glyph("jaki","󱤐");
        public static readonly Glyph jan = new Glyph("jan","󱤑");
        public static readonly Glyph jelo = new Glyph("jelo","󱤒");
        public static readonly Glyph jo = new Glyph("jo","󱤓");
        public static readonly Glyph kala = new Glyph("kala","󱤔");
        public static readonly Glyph kalama = new Glyph("kalama","󱤕");
        public static readonly Glyph kama = new Glyph("kama","󱤖");
        public static readonly Glyph kasi = new Glyph("kasi","󱤗");
        public static readonly Glyph ken = new Glyph("ken","󱤘");
        public static readonly Glyph kepeken = new Glyph("kepeken","󱤙");
        public static readonly Glyph kili = new Glyph("kili","󱤚");
        public static readonly Glyph kiwen = new Glyph("kiwen","󱤛");
        public static readonly Glyph ko = new Glyph("ko","󱤜");
        public static readonly Glyph kon = new Glyph("kon","󱤝");
        public static readonly Glyph kule = new Glyph("kule","󱤞");
        public static readonly Glyph kulupu = new Glyph("kulupu","󱤟");
        public static readonly Glyph kute = new Glyph("kute","󱤠");
        public static readonly Glyph la = new Glyph("la","󱤡");
        public static readonly Glyph lape = new Glyph("lape","󱤢");
        public static readonly Glyph laso = new Glyph("laso","󱤣");
        public static readonly Glyph lawa = new Glyph("lawa","󱤤");
        public static readonly Glyph len = new Glyph("len","󱤥");
        public static readonly Glyph lete = new Glyph("lete","󱤦");
        public static readonly Glyph li = new Glyph("li","󱤧");
        public static readonly Glyph lili = new Glyph("lili","󱤨");
        public static readonly Glyph linja = new Glyph("linja","󱤩");
        public static readonly Glyph lipu = new Glyph("lipu","󱤪");
        public static readonly Glyph loje = new Glyph("loje","󱤫");
        public static readonly Glyph lon = new Glyph("lon","󱤬");
        public static readonly Glyph luka = new Glyph("luka","󱤭");
        public static readonly Glyph lukin = new Glyph("lukin","󱤮");
        public static readonly Glyph lupa = new Glyph("lupa","󱤯");
        public static readonly Glyph ma = new Glyph("ma","󱤰");
        public static readonly Glyph mama = new Glyph("mama","󱤱");
        public static readonly Glyph mani = new Glyph("mani","󱤲");
        public static readonly Glyph meli = new Glyph("meli","󱤳");
        public static readonly Glyph mi = new Glyph("mi","󱤴");
        public static readonly Glyph mije = new Glyph("mije","󱤵");
        public static readonly Glyph moku = new Glyph("moku","󱤶");
        public static readonly Glyph moli = new Glyph("moli","󱤷");
        public static readonly Glyph monsi = new Glyph("monsi","󱤸");
        public static readonly Glyph mu = new Glyph("mu","󱤹");
        public static readonly Glyph mun = new Glyph("mun","󱤺");
        public static readonly Glyph musi = new Glyph("musi","󱤻");
        public static readonly Glyph mute = new Glyph("mute","󱤼");
        public static readonly Glyph nanpa = new Glyph("nanpa","󱤽");
        public static readonly Glyph nasa = new Glyph("nasa","󱤾");
        public static readonly Glyph nasin = new Glyph("nasin","󱤿");
        public static readonly Glyph nena = new Glyph("nena","󱥀");
        public static readonly Glyph ni = new Glyph("ni","󱥁");
        public static readonly Glyph nimi = new Glyph("nimi","󱥂");
        public static readonly Glyph noka = new Glyph("noka","󱥃");
        public static readonly Glyph o = new Glyph("o","󱥄");
        public static readonly Glyph olin = new Glyph("olin","󱥅");
        public static readonly Glyph ona = new Glyph("ona","󱥆");
        public static readonly Glyph open = new Glyph("open","󱥇");
        public static readonly Glyph pakala = new Glyph("pakala","󱥈");
        public static readonly Glyph pali = new Glyph("pali","󱥉");
        public static readonly Glyph palisa = new Glyph("palisa","󱥊");
        public static readonly Glyph pan = new Glyph("pan","󱥋");
        public static readonly Glyph pana = new Glyph("pana","󱥌");
        public static readonly Glyph pi = new Glyph("pi","󱥍");
        public static readonly Glyph pilin = new Glyph("pilin","󱥎");
        public static readonly Glyph pimeja = new Glyph("pimeja","󱥏");
        public static readonly Glyph pini = new Glyph("pini","󱥐");
        public static readonly Glyph pipi = new Glyph("pipi","󱥑");
        public static readonly Glyph poka = new Glyph("poka","󱥒");
        public static readonly Glyph poki = new Glyph("poki","󱥓");
        public static readonly Glyph pona = new Glyph("pona","󱥔");
        public static readonly Glyph pu = new Glyph("pu","󱥕");
        public static readonly Glyph sama = new Glyph("sama","󱥖");
        public static readonly Glyph seli = new Glyph("seli","󱥗");
        public static readonly Glyph selo = new Glyph("selo","󱥘");
        public static readonly Glyph seme = new Glyph("seme","󱥙");
        public static readonly Glyph sewi = new Glyph("sewi","󱥚");
        public static readonly Glyph sijelo = new Glyph("sijelo","󱥛");
        public static readonly Glyph sike = new Glyph("sike","󱥜");
        public static readonly Glyph sin = new Glyph("sin","󱥝");
        public static readonly Glyph sina = new Glyph("sina","󱥞");
        public static readonly Glyph sinpin = new Glyph("sinpin","󱥟");
        public static readonly Glyph sitelen = new Glyph("sitelen","󱥠");
        public static readonly Glyph sona = new Glyph("sona","󱥡");
        public static readonly Glyph soweli = new Glyph("soweli","󱥢");
        public static readonly Glyph suli = new Glyph("suli","󱥣");
        public static readonly Glyph suno = new Glyph("suno","󱥤");
        public static readonly Glyph supa = new Glyph("supa","󱥥");
        public static readonly Glyph suwi = new Glyph("suwi","󱥦");
        public static readonly Glyph tan = new Glyph("tan","󱥧");
        public static readonly Glyph taso = new Glyph("taso","󱥨");
        public static readonly Glyph tawa = new Glyph("tawa","󱥩");
        public static readonly Glyph telo = new Glyph("telo","󱥪");
        public static readonly Glyph tenpo = new Glyph("tenpo","󱥫");
        public static readonly Glyph toki = new Glyph("toki","󱥬");
        public static readonly Glyph tomo = new Glyph("tomo","󱥭");
        public static readonly Glyph tu = new Glyph("tu","󱥮");
        public static readonly Glyph unpa = new Glyph("unpa","󱥯");
        public static readonly Glyph uta = new Glyph("uta","󱥰");
        public static readonly Glyph utala = new Glyph("utala","󱥱");
        public static readonly Glyph walo = new Glyph("walo","󱥲");
        public static readonly Glyph wan = new Glyph("wan","󱥳");
        public static readonly Glyph waso = new Glyph("waso","󱥴");
        public static readonly Glyph wawa = new Glyph("wawa","󱥵");
        public static readonly Glyph weka = new Glyph("weka","󱥶");
        public static readonly Glyph wile = new Glyph("wile","󱥷");
        public static readonly Glyph namako = new Glyph("namako","󱥸");
        public static readonly Glyph kin = new Glyph("kin","󱥹");
        public static readonly Glyph oko = new Glyph("oko","󱥺");
        public static readonly Glyph kipisi = new Glyph("kipisi","󱥻");
        public static readonly Glyph leko = new Glyph("leko","󱥼");
        public static readonly Glyph monsuta = new Glyph("monsuta","󱥽");
        public static readonly Glyph tonsi = new Glyph("tonsi","󱥾");
        public static readonly Glyph jasima = new Glyph("jasima","󱥿");
        public static readonly Glyph kijetesantakalu = new Glyph("kijetesantakalu","󱦀");
        public static readonly Glyph soko = new Glyph("soko","󱦁");
        public static readonly Glyph meso = new Glyph("meso","󱦂");
        public static readonly Glyph epiku = new Glyph("epiku","󱦃");
        public static readonly Glyph kokosila = new Glyph("kokosila","󱦄");
        public static readonly Glyph lanpan = new Glyph("lanpan","󱦅");
        public static readonly Glyph n = new Glyph("n","󱦆");
        public static readonly Glyph misikeke = new Glyph("misikeke","󱦇");
        public static readonly Glyph ku = new Glyph("ku","󱦈");

        public static readonly Glyph exclamation = new Glyph("exclamation","!");
        public static readonly Glyph question = new Glyph("question","?");
        public static readonly Glyph period = new Glyph("period",".");
        public static readonly Glyph comma = new Glyph("comma",",");
        public static readonly Glyph colon = new Glyph("comma",":");
        public static readonly Glyph semicolon = new Glyph("semicolon",";");

        public static bool TryParse(string value, out Glyph result)
        {
            var propertyInfo = typeof(Glyphs).GetFields().SingleOrDefault(p => p.Name == value);
            if (propertyInfo == null)
            {
                result = null;
                return false;
            }
            else
            {
                result = propertyInfo.GetValue(null) as Glyph;
                return true;
            }
        }
    }
}