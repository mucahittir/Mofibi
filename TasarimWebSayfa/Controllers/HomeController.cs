using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasarimWebSayfa.Models;

namespace TasarimWebSayfa.Controllers
{
    public class HomeController : Controller
    {
        List<string> marka = new List<string>
        {
            "Vertu", "Apple", "Sony Ericsson", "Tag Heuer", "Asus", "Reeder", "Aselsan", "Honor", "Lenovo", "Haier","ZTE","Sony", "Alcatel", "Turkcell", "Vodafone", "LG","BlackBerry", "Yota", "Philips", "BenQ,Siemens", "Nokia", "Xiaomi", "Blackview","Palm", "Samsung", "Quatro", "General Mobile", "Huawei","EvoBT", "Oppo", "Xgody", "Vestel", "Casper", "LeTV LeEco", "TP-Link", "Microsoft",
                "Essential Phone", "Infinix", "Sharp", "Kaan", "OnePlus", "Meizu", "Realme",
                "Elephone", "Vivo", "HTC", "Motorola", "Avea Türk Telekom", "TCL", "Google"
        };

        List<string> model = new List<string>
        {
            "Discovery","Classic Q20","9360 Curve","SL55","Q5","Galaxy A21s"
            ,"Xperia Z5 Compact","Galaxy J7 Prime 2","Xperia SP","C55","10"
            ,"Nubia Z20","Axon 10 Pro","Galaxy A51","Xperia 1","Galaxy A7 (2017)"
            ,"Z6 Pro","Xperia P","5140i","SX1","Key2 LE","Galaxy S5 G900","P20 Lite"
            ,"RS6","P30 Lite","808 PureView","Galaxy A7 A700","5X (GR5)","Priv"
            ,"Blade V7 Lite","Xperia X Compact","A55","Reno3","Galaxy S10e","C35"
            ,"S25","M35","X15","Y6 (2018)","Reno2 Z","Blade L","ZenFone 5","Reno4"
            ,"BV8000 Pro","Venus Z10","Galaxy Note 10","VIA A1","Galaxy A71"
            ,"Galaxy A30s","ROG Phone 3 ZS661KS","Galaxy A30","Galaxy J1 J100"
            ,"ZenFone 2","Galaxy M30s","Galaxy S8+ G955","Galaxy A20","Xperia XZ3"
            ,"Galaxy C5 Pro","Nubia Z17 mini","Galaxy A5 (2017)"
            ,"Galaxy S6 Active G890","Zenfone Max Pro (M1) ZB601KL","C25"
            ,"Galaxy A3 (2016)","Galaxy S4 i9500","Galaxy J7 Duo","Galaxy E5 E500"
            ,"Galaxy A01","ROG Phone II ZS660KL","6A (Pro)","Galaxy Note 3 Neo N750"
            ,"X900 Le Max","S8530 Wave 2","Galaxy J1 Mini Prime","Galaxy J4 Core"
            ,"Galaxy A6s","MaxiPro 5","Galaxy On7","Zenfone 3 Zoom ZE553KL","P70"
            ,"Smart 4 Power","ZenFone 2 Laser","ZenFone Max ZC550KL","Neffos Y5L"
            ,"Lumia 540","PH-1","Hot 8","Neffos X1","Zenfone 3 ZE552KL","Smart 6"
            ,"Zenfone 5 ZE620KL","ZenFone 4","P12","Galaxy A70","Galaxy M21"
            ,"Galaxy M30","M200","S60","Galaxy A6+ (2018)","Vibe S1","MC60","Aquos S2"
            ,"Redmi Note 5 Pro","ROG Phone 3 Strix","Xperia M","Zenfone 5z ZS620KL"
            ,"K5 Pro","ZenFone 6","N2","Signature","Lumia 535","7290","Xperia Miro"
            ,"Xperia Z4","Zenfone Live ZB501KL","Zenfone 3 Max ZC520TL","P10000 Pro"
            ,"Galaxy Note 5 Duos","Neffos C5 Max","S5 Pro","A319","1650","8 Pro"
            ,"Xperia Z3 Plus","Zenfone 4 Max ZC554KL","Xperia T2 Ultra"
            ,"P9983 Porsche Design","CF110","SXG75","Z5","A5000","Ayxta"
            ,"Lumia 640 XL","Galaxy S i9000","Blade X9","Smart 4 Mini","Blade V"
            ,"9780 Bold","Neffos C5","Galaxy Core i8260","4C","Xperia M2 Aqua"
            ,"Galaxy A20e","Galaxy J3 (2018)","A369i","16 Xs"
            ,"Zenfone 3 Laser ZC551KL","Nubia X","A9 2020","Reno","Galaxy Nexus i9250"
            ,"Galaxy C7","RX17 Neo","Reno3 Pro","A5 (2020)","AX7","Neffos X1 Max"
            ,"Xperia 10","iPhone 11 Pro Max","Reno4 Lite","A52","Reno4 Pro"
            ,"Lumia 550","A72","A91","A5S","Reno Z","N1","Reno2","Find X2","A31"
            ,"RX17 Pro","Note 7","M1453","Zenfone Go T500","C11","3000"
            ,"ZenFone 2 Deluxe","Galaxy J Max","A12","X8","iPhone 11","7 Pro","Zero 8"
            ,"Galaxy S7 Edge G935","A6000 Plus","6210","A1","Redmi 8A"
            ,"Galaxy J7 (2017)","Galaxy Note 8 N950","Venus E5","2730 Classic","N91"
            ,"Galaxy J5 (2017)","Galaxy A80","6i","Galaxy Note 10+","Galaxy S20 FE"
            ,"Galaxy A11","Galaxy A7 (2016)","Galaxy Note 20 Ultra"
            ,"Galaxy Note Fan Edition","Galaxy S20+","Galaxy A10","Galaxy S10 Plus"
            ,"Galaxy J7 Core","Galaxy A50","Galaxy A8 Duos","SH888","Galaxy Note 20"
            ,"Galaxy A20s","S5620 Monte","Galaxy Note 8 Duos","Galaxy J2 J200"
            ,"Mate 10 Lite","Galaxy C7 Pro","Galaxy Trend Plus S7580"
            ,"Galaxy Z Fold 2","VIA A3","E65","Galaxy A7 (2018)","VIA A4","6","SL45"
            ,"6310i","Galaxy J7 Pro","Galaxy J6","3610","Galaxy S7 G930","VIA E3"
            ,"Galaxy M20","515","Galaxy Grand Prime G532","Galaxy A8+ (2018)"
            ,"Lumia 625","Galaxy A9 (2018)","Galaxy Grand Neo Plus i9060","Galaxy J4+"
            ,"Galaxy J5 J500","Galaxy Win i8552","VIA S","Galaxy M11","VIA M1"
            ,"Galaxy A8 (2015)","VIA A3 Plus","7T Pro","9","Galaxy S6 G920"
            ,"Galaxy A3 (2017)","3315","K10 (2017)","Galaxy M51","Galaxy J1 Ace"
            ,"Galaxy S3 Mini i8190","VIA M2","6030","Galaxy Grand Prime G530"
            ,"G4 Stylus H540","6.1","Galaxy J5 Pro","Galaxy S10 Lite","112","Nex S"
            ,"Y7 (2018)","VIA G1 Plus","iPhone 6S Plus","N95","Galaxy J2 (2017)"
            ,"iPhone XR","Galaxy Trend S7560","iPhone 6S","P30 Pro","9860 Torch"
            ,"R600","8910i","iPhone 4","Explorer","K8 K350N","Mate 20 Lite"
            ,"Venus Z20","P40 Lite","Y5 (2019)","5i","Z530i","U Play","iPhone 8 Plus"
            ,"VIA A2","7T","CD930","VIA G3","VIA X20","iPhone 11 Pro","VIA M4"
            ,"iPhone XS Max","P Smart (2019)","P20 Pro","GM 5 Plus","P30"
            ,"P9 Lite (2017)","iPhone 12","2760","Q6","Mate 10 Pro","Galaxy J7 Prime"
            ,"Y7 (2019)","6101","Galaxy C5","Le S3","VIA G4","3310 (2017)"
            ,"Galaxy A8 (2016)","One M8","P9 Lite","P Smart","Y6 (2019)","G4 H815"
            ,"7210","Asha 300","7270","W900i","Y9 Prime (2019)","W910i"
            ,"7610 Supernova","iPhone 12 Pro Max","C6-01","iPhone 12 Pro","E61"
            ,"Galaxy S8 G950","Venus V3 5580","E71","VIA M3","Lumia 520"
            ,"Venus V3 5570","U11","Galaxy E7 E700","Redmi Note 8 Pro"
            ,"4G Android One","GM 9 Go","Desire 320","8850","GM 5 Plus D"
            ,"Galaxy J7 (2016)","Desire Eye","One M7","Venus V3 5070","Desire 820G+"
            ,"Galaxy S9+ G965","P8","Mate 9","One A9","Moto G5S Plus","Mate 10"
            ,"GM 8 Go","V20","P40 Lite E","6T","F11 Pro","8T","Zenfone 4 Max ZC520KL"
            ,"M10","GM 8","P40","GR5 2017","Galaxy S6 edge+ G928","Galaxy Note N7000"
            ,"Galaxy S20 Ultra","Galaxy J2 (2018)","ZUK Z2","Y7 Pro (2018)"
            ,"Galaxy A31","Galaxy M31","Galaxy A5 A500","Y6s (2019)","GM 20 Pro"
            ,"K8 (2017)","Desire 616","Galaxy Note 9 N960","Galaxy J4 J400","Q60"
            ,"Galaxy J6+","GM 6","G6 H870","Galaxy J2 (2016)","Venus 5.0","Ascend P6"
            ,"Mi A3","Mi 9","M6T","GM 10","Galaxy S10","5110","Redmi Note 7"
            ,"Galaxy A10s","L Fino D290","5T","GM 9 Pro","Galaxy S20"
            ,"Galaxy Note 3 N9000","P9 Lite Mini","Galaxy J7 Max","P40 Pro","TT175"
            ,"4G Android One Dual","6060","Galaxy Note 3 N9000Q","3","P Smart Pro"
            ,"P20","Galaxy A6 (2018)","5.1","Nova 5T","Lumia 820","Galaxy C9 Pro"
            ,"Mate 30 Pro","Desire 816G dual sim","Galaxy Note10 Lite","10 Plus","K61"
            ,"Galaxy S3 Mini Value Edition i8200","Galaxy J2 Prime","Galaxy A3 (2015)"
            ,"Y6p","VIA P3","P10 Plus","G5 H850","Pixel","Mi 9 SE","Nord"
            ,"Galaxy A5 (2016)","P Smart S","Galaxy J7 J700","VIA V9","Ascend Mate 7"
            ,"P8 Lite","G Pro 2 D837","Venus V5","Galaxy J3 (2016)","Galaxy J8 J810"
            ,"K40S","Asha 501","Xperia U","9300","Galaxy M40","inTouch 4","701","8890"
            ,"9720","E52","C2","C3","Galaxy Grand i9082","GM 5","Discovery Air"
            ,"P10 Lite","GM 20","VIA F2","GM 6 D","VIA E1","Nova","Pixel 4 XL"
            ,"Galaxy A9 (2016)","Y5 Lite","G4c H525n","G4 Beat","Realme C3i","Find X"
            ,"G7 ThinQ G710","Discovery 2 Mini","Ascend G7","Y7 Prime (2019)","A73"
            ,"Q Stylus Plus","Mate 20 X","Stylus 3 K10 Pro","ZenFone Zoom ZX551ML"
            ,"V30 Plus","Zenfone 3 Ultra ZU680KL","P8 Max","Y6 Pro","Mate S"
            ,"G2 Mini D610"
        };

        List<string> isletimSistemi = new List<string>
        {
            "Android","Native (Diğer)","iOS","Symbian OS","BlackBerry OS","Bada","WebOS","Microsoft Windows"
        };
        List<string> renk = new List<string>
        {
            "Siyah","Gri","Beyaz","Kahverengi","Mavi","Gümüş","Turuncu","Altın"
            ,"Lacivert","Pembe","Bej","Kırmızı","Sarı","Bordo","Mor","Yeşil","Bakır"
            ,"Belirtilmemiş"
        };
        List<string> garantiDurumu = new List<string>
        {
            "Belirtilmemiş","Garantisi Yok","İthalatçı Garantili","Distribütör Garantili"
        };
        List<float> dahiliHafiza = new List<float>
        {
            32,16,64,256,8,128,0.5f,0.1f,4,6,1000,0.4f,12
        };
        List<float> ekranBoyutu = new List<float>
        {
            5.5f,3.5f,1.9f,4.7f,3.7f,2.4f,5.8f,3.0f,
            1.4f,6.3f,5.6f,4.0f,5.0f,5.7f,5.2f,6.0f,
            4.5f,6.2f,2.0f,2.8f,4.6f,1.8f,5.3f,2.6f,
            6.9f,1.7f,6.5f,5.1f,1.6f,5.9f,1.5f,6.4f,
            6.1f,3.2f,2.9f,2.5f,4.8f,3.1f,2.7f,2.2f,
            3.4f,6.7f,4.3f,3.6f,6.8f,2.1f,2.3f,4.1f,
            8.0f,4.2f,3.8f,7.6f
        };
        List<float> ram = new List<float>
        {
            3,4,0,2,0.5f,1,6,1.5f,8,0.016f,0.032f, 0.256f, 0.768f,0.064f,0.128f,
            10,12,16
        };

        List<float> arkaKam = new List<float>
        {
            13,0,12,8,5,16,4,23,1,
            2,21,18,48,20,40,19,9,3,
            10,7,24,41,6,25,64,
            32,50,108,52,
        };
        List<float> onKam = new List<float>
        {
            8,0,7,25,5,13,16,2,24,12,
            10,1,3,32,4,
            20,40,48,
        };

        [HttpGet]
        public ActionResult Index()
        {
           
            ViewBag.Marka = marka;
            ViewBag.Model = model;
            ViewBag.IsletimSistemi = isletimSistemi;
            ViewBag.Renk = renk;
            ViewBag.GarantiDurumu = garantiDurumu;
            ViewBag.DahiliHafiza = dahiliHafiza;
            ViewBag.EkranBoyutu = ekranBoyutu;
            ViewBag.Ram = ram;
            ViewBag.ArkaKamera = arkaKam;
            ViewBag.OnKamera = onKam;

            return View();
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Fiyat(Telefon tf)
        {
            try
            {
                Requester r = new Requester();
                string fiyat = "";

                var postdata = new
                {
                    tf.marka,
                    tf.model,
                    tf.os,
                    tf.dahiliHaf,
                    tf.ram,
                    tf.arkKam,
                    tf.garanti,
                    tf.renk,
                    tf.ekranBoyutu,
                    tf.onKam,
                    tf.mlModel
                };

                try
                {

                    var ahah = await r.POSTAsync("predict", JsonConvert.SerializeObject(postdata)); 
                    var eheh = ahah.Content;            
                    var ohoh = eheh.ReadAsStringAsync().Result;
                    JObject ihih = (JObject)JsonConvert.DeserializeObject(ohoh);
                    fiyat = ihih["fiyat"].ToString();
                    if (ihih.ContainsKey("error"))
                    {
                        ViewBag.Hata = "Bir hata meydana geldi.";
                    }

                    fiyat = Math.Round(float.Parse(fiyat)).ToString();
                    ViewBag.Fiyat = fiyat;
                }
                catch (Exception ex)
                {
                    fiyat = ex.Message;
                    ViewBag.Message = fiyat;
                    return View();
                }


            }
            catch { }

            return View();
        }

        [HttpGet]
        public ActionResult BasitIndex()
        {
            ViewBag.Marka = marka;
            ViewBag.Model = model;
            ViewBag.GarantiDurumu = garantiDurumu;
            ViewBag.Renk = renk;
            ViewBag.DahiliHafiza = dahiliHafiza;
            return View();
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> BasitFiyat(Telefon tf)
        {
            try
            {
                Requester r = new Requester();
                string fiyat = "";

                var postdata = new
                {
                    tf.marka,
                    tf.model,
                    tf.dahiliHaf,
                    tf.garanti,
                    tf.renk,
                    tf.mlModel
                };

                try
                {
                    var ahah = await r.POSTAsync("predictSimple", JsonConvert.SerializeObject(postdata));
                    var eheh = ahah.Content;
                    var ohoh = eheh.ReadAsStringAsync().Result;
                    JObject ihih = (JObject)JsonConvert.DeserializeObject(ohoh);
                    fiyat = ihih["fiyat"].ToString();
                    if (ihih.ContainsKey("error"))
                    {
                        ViewBag.Hata = "Bir hata meydana geldi.";
                    }

                    fiyat = Math.Round(float.Parse(fiyat)).ToString();
                    ViewBag.Fiyat = fiyat;
                }
                catch (Exception ex)
                {
                    fiyat = ex.Message;
                    ViewBag.Message = fiyat;
                    return RedirectToAction("Index");
                }


            }
            catch { }

            return View();
        }
    }
}