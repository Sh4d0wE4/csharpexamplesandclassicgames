using System;
using System.Data;

namespace kimmilyonerolmakister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Kim Milyoner Olmak İster?");
            Console.WriteLine("Programming By Sh4d0wE4");
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();
            string secim;
            Console.Write("1- Başlangıç: 5 Soruluk Deneyim\n2- Zor: 80 Soruluk Labirent\nSeçiminizi Yapın\n: ");
            secim = Console.ReadLine();
            

            if (secim == "1")
            {
                Console.Clear();
                KimMilyonerOlmakİster();
            }
            if (secim == "2")
            {
                Console.Clear();
                KimMilyonerOlmakİsterV1();
            }
        }
        private static void KimMilyonerOlmakİster()
        {
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Kim Milyoner Olmak İster");
            Console.WriteLine("Programming By Sh4d0wE4");
            Console.WriteLine("___________________________________________________________");

            string input;
            Console.Write("1- Oyuna Başla\n2- Çıkış\n: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Console.WriteLine("1.Soru: Python'un Kurucusu Kimdir?\nA- Guido Van Rossum\nB- Galileo Galile\nC- Nicholas Copernicus\nD- Albert Einstein");
                string cevap1;
                Console.Write("Cevabınız: ");
                cevap1 = Console.ReadLine();

                if (cevap1 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("2.Soru: Dünyanın Aslında Yuvarlak Olduğunun İddiasını Ortaya Atan İlk Gökbilimci Kimdir?\nA- Galileo Galile\nB- Isaac Newton\nC- Rıchard Nixon\nD- Nicholas Copernicus");
                string cevap2;
                Console.Write("Cevabınız: ");
                cevap2 = Console.ReadLine();

                if (cevap2 == "D")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("3.Soru: 1071 Yılında Gerçekleşen Ve Sonrasında Artık Anadolu Kapılarının Türklere Sonsuza Kadar Açıldığı Savaş Aşağıdakilerden Hangisidir?\nA- Büyük İnönü Savaşı\nB- Malazgirt Zaferi\nC- Kurtuluş Savaşı\nD- 2.Dünya Savaşı");
                string cevap3;
                Console.Write("Cevabınız: ");
                cevap3 = Console.ReadLine();

                if (cevap3 == "B")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("4.Soru: 'Şaban Oğlu Şaban', 'Hababam Sınıfı', 'Süt Kardeşler' filmlerinin yönetmeni aşağıdakilerden hangisidir?\nA- Zeki Demirkübüz\nB- Ertem Eğilmez\nC- Kartal Tibet\nD- Osman F. Seden");
                string cevap4;
                Console.Write("Cevabınız: ");
                cevap4 = Console.ReadLine();

                if (cevap4 == "B")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("5.Soru: Aşağıdaki İnanışlardan Hangisi 'İnekleri Kutsal Sayma' Maddesi Arasında Olan İnanıştır?\nA- Ateizm\nB- Putperestlik\nC- Hinduizm\nD- Kapitalizm");
                string cevap5;
                Console.Write("Cevabınız: ");
                cevap5 = Console.ReadLine();

                if (cevap5 == "C")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine();

                Console.WriteLine("Yarışmamız Sona Ermiştir. Oynadığınız İçin Teşekkür Ederiz...\nProgrammer: Sh4d0wE4");

                Console.ReadLine();
                Console.WriteLine("Oyundan Çıkmak İçin ENTER Tuşuna Basmanız Yeterlidir.");
                Console.ReadKey();
            }

            if (input == "2")
            {
                Console.WriteLine("Çıkmak İstediğinize Emin Misiniz ?");
                string asilcevap;
                Console.Write("Cevabınız: ");
                asilcevap = Console.ReadLine();

                if (asilcevap == "Evet")
                {
                    Console.WriteLine("Oyundan Çıkmak İçin ENTER Tuşuna Basmanız Yeterlidir");
                    Console.ReadKey();
                }
                if (asilcevap == "Hayır")
                {
                    Console.WriteLine("Oyun Yeniden Başlatılacak...");
                    Console.ReadKey();

                    Console.Clear();
                    KimMilyonerOlmakİster();
                }
            }
        }
        private static void KimMilyonerOlmakİsterV1()
        {
            Console.Clear();

            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Kim Milyoner Olmak İster V1.1");
            Console.WriteLine("Programming By Sh4d0wE4");
            Console.WriteLine("___________________________________________________________");

            string secim;
            Console.Write("1- Oyunu Başlat\n2- Çıkış\nSeçiminizi Yapın\n: ");
            secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Clear();

                Console.WriteLine("NOT: Bu Oyunumuzda, Önceki Oyunumuza Nazaran, Dört Ayrı Kategoriden: Matematik, Fen, Edebiyat, Sosyal Bilgiler\nDerslerinden 5 Ayrı Soru Sorulacaktır. Bol Şanslar");
                Console.WriteLine("Devam Etmek İçin ENTER Tuşuna Basın");

                Console.ReadKey();
                Console.Clear();

                //Edebiyat Kategorisi
                Console.WriteLine("Edebiyat Soruları");
                Console.WriteLine();

                Console.WriteLine("1.Soru: Hikaye Türüne Ait Edebi Metinlerin Ortak Özelliği Aşağıdakilerden Hangisidir?\nA- Konuların Yaşanmış Veya Yaşanabilecek Olaylardan Olması\nB- Dörtlük Halinde Yazılması\nC- Beytten Oluşması\nD- Bütün Metinlerin 1.Tekil Şahısın Ağzından Anlatması");
                string edbcevap1;
                Console.Write("Cevabınız: ");
                edbcevap1 = Console.ReadLine();

                if (edbcevap1 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("2.Soru: İstiklal Marşı'nın Dizesi Nasıl Bir Boyuta Oluşmuştur?\nA- Dörtlükten Oluşması\nB- Beytten Oluşması\nC- Estetik Yapıda Olması\nD- Açıklayıcı Olması");
                string edbcevap2;
                Console.Write("Cevabınız: ");
                edbcevap2 = Console.ReadLine();

                if (edbcevap2 == "B")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");
                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("3.Soru: Aşağıdaki Şıklardan Hangisinde Yazım Yanlışı Yapılmamıştır?\nA- Aydede\nB- Yanlız\nC- Nerde\nD- Bağzı");
                string edbcevap3;
                Console.Write("Cevabınız: ");
                edbcevap3 = Console.ReadLine();

                if (edbcevap3 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("4.Soru: Şiir Edebi Türlerinde, Aşağıdaki Şıklardan Hangisinde Ortak Bir Yön Vardır?\nA- Mahzun Bir Hali Bulunması\nB- Bakış Açılarının Aynı Olması\nC- Yalın Bir Dille Yazılması\nD- Olmuş Veya Olabilecek Olayların Konu Alınması");
                string edbcevap4;
                Console.Write("Cevabınız: ");
                edbcevap4 = Console.ReadLine();

                if (edbcevap4 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("5.Soru: Hikaye İle Fabl Edebi Türlerinin Arasındaki Temel Fark Aşağıdakilerden Hangisidir?\nA- Genel Olarak İlahi Ve Kahraman Bakış Açılarına Sahip Olması || Kısa Ve Ders Verici Nitelikte Olması\nB- Yaşanmış Veya Yaşanabilecek Konulara Yer Vermesi || Genel Olarak Metnin Başı 'Evvel Zaman İçinde Kalbur Saman İçinde' Şeklinde Başlaması\nC- Kendine Has Bir Dili Olması || Gerçek Hayattan Örnekleri Olması\nD- Popülerliği Fazla Olan Hayatları Örnek Olması || Aksiyonu Ve Korkuyu Baz Alması");
                string edbcevap5;
                Console.Write("Cevabınız: ");
                edbcevap5 = Console.ReadLine();

                if (edbcevap5 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.ReadLine();
                Console.WriteLine("Cevap Anahtarı: A, B, A, A, A");
                Console.WriteLine("Edebiyat Problemleriniz Bitti... Matematik Problemlerine Geçmek İçin ENTER'a Basın");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Matematik Problemleri");
                Console.WriteLine();

                Console.WriteLine("1.Soru: Bir Sayının 5 Katının 2 Eksiği 13'tür. O Sayıyı Bulun.");
                int matcevap1;
                Console.Write("Cevabınız: ");
                matcevap1 = Convert.ToInt32(Console.ReadLine());

                if (matcevap1 == 3)
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("2.Soru: 2X + 2 = 10\nYukarıdaki Basit Denklemin Cevabını Bulun");
                int matcevap2;
                Console.Write("Cevabınız: ");
                matcevap2 = Convert.ToInt32(Console.ReadLine());

                if (matcevap2 == 4)
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("3.Soru: 4 Sayısının Karekökünü Bulun");
                int matcevap3;
                Console.Write("Cevabınız: ");
                matcevap3 = Convert.ToInt32(Console.ReadLine());

                if (matcevap3 == 2)
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("4.Soru: 2 İle 8 Sayısının Aritmetik Toplanmasını Bulun");
                int matcevap4;
                Console.Write("Cevabınız: ");
                matcevap4 = Convert.ToInt32(Console.ReadLine());

                if (matcevap4 == 5)
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("5.Soru: X . 2 = 10\nDenkleminin Cevabını Bulun.");
                int matcevap5;
                Console.Write("Cevabınız: ");
                matcevap5 = Convert.ToInt32(Console.ReadLine());

                if (matcevap5 == 5)
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.ReadLine();
                Console.WriteLine("Cevap Anahtarı: 3, 4, 2, 5, 5");
                Console.WriteLine("Matematik Problemleriniz Bitti... Fen Problemlerine Geçmek İçin ENTER Tuşuna Basın");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Fen Problemleri");
                Console.WriteLine();

                Console.WriteLine("1.Soru: Türkiyede Bulunan Fay Hatları Arasında, 1.Derecede Deprem Kuşağı Olan Bölge Neresidir?\nA- Doğu Anadolu Fayı || Van\nB- Ege Fay Hatları || Aydın\nC- Kuzey Anadolu Fayı || Marmara\nD- Güneydoğu Anadolu Fayı || Diyarbakır");
                string fencevap1;
                Console.Write("Cevabınız: ");
                fencevap1 = Console.ReadLine();

                if (fencevap1 == "C")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("2.Soru: Hangi Hayvanlar Yalnızca Popolarıyla Nefes Alabilmektedir?\nA- Çekirge\nB- Kaplumbağa\nC- Akrep\nD- Fare");
                string fencevap2;
                Console.Write("Cevabınız: ");
                fencevap2 = Console.ReadLine();

                if (fencevap2 == "B")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("3.Soru: Direnç Nedir?\nA- Elektrik Akımının Hızını Gösteren Elemandır\nB- Elektrik Akımının Gücünü Gösteren Elemandır\nC- Elektrik Akımına Karşı Zorluk Gösteren Elemanlara Denir\nD- Elektrik Ve Elektronik Akımının Olup Olmadığını Kontrol Eden Cihazlardır");
                string fencevap3;
                Console.Write("Cevabınız: ");
                fencevap3 = Console.ReadLine();

                if (fencevap3 == "C")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("4.Soru: NaCI Çözeltisi Nedir? Hangi Atomlar Vardır?\nA- Sodyum Fosfat\nB- Sodyum Hidroklorik\nC- Sodyum Klorür\nD- Hidroklörik Asit");
                string fencevap4;
                Console.Write("Cevabınız: ");
                fencevap4 = Console.ReadLine();

                if (fencevap4 == "C")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("5.Soru: Bütün Canlıların Üreme Esnasında, Tek Farklı Üreyen Canlı Hangisidir?\nA- Çiçek\nB- Eşek\nC- Ot\nİnsan");
                string fencevap5;
                Console.Write("Cevabınız: ");
                fencevap5 = Console.ReadLine();

                if (fencevap5 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.ReadLine();
                Console.WriteLine("Cevap Anahtarı: C, B, C, C, A");
                Console.WriteLine("Fen Problemleriniz Bitti... Sosyal Bilgiler Problemlerine Geçmek İçin ENTER Tuşuna Basın");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Sosyal Bilgiler");
                Console.WriteLine();

                Console.WriteLine("1.Soru: 18 Yaşını Doldurmuş Olan Her Vatandaş Aşağıdaki Haklardan Hangisine Sahip Olur?\nA- Yaşama Hakkı\nB- Seçme Ve Seçilme Hakkı\nC- Mülkiyet Hakkı\nD- Seyahat Hakkı");
                string sosyalcevap1;
                Console.Write("Cevabınız: ");
                sosyalcevap1 = Console.ReadLine();

                if (sosyalcevap1 == "B")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("2.Soru: Fransız İhtilali Hangi Yılda Gerçekleşmiştir?\nA- 1760\nB- 1765\nC- 1789\nD- 1860");
                string sosyalcevap2;
                Console.Write("Cevabınız: ");
                sosyalcevap2 = Console.ReadLine();

                if (sosyalcevap2 == "C")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");


                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("3.Soru: Türkiye Cumhuriyeti Temelleri, Hangi Kongrede Temeli Atılmıştır?\nA- Erzurum Kongresi\nB- Sivas Kongresi\nC- Amasya Kongresi\nD- Samsun Kongresi");
                string sosyalcevap3;
                Console.Write("Cevabınız: ");
                sosyalcevap3 = Console.ReadLine();

                if (sosyalcevap3 == "B")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("4.Soru: II.Dünya Savaşında, Hangi Ülkeye Ve Şehire Atom Bombası Atılarak, Savaş Resen Sona Ermiştir?\nA- Pearl Harbor || A.B.D\nB- Berlin || Almanya\nC- Hiroşima || Japonya\nSeoul || Güney Kore");
                string sosyalcevap4;
                Console.Write("Cevabınız: ");
                sosyalcevap4 = Console.ReadLine();

                if (sosyalcevap4 == "C")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.WriteLine("5.Soru: Avusturya, Macaristan, Litvanya Ve Rusya'nın Aralarında Bulunduğu, Osmanlının Avrupa Topraklarından Bastırılması İçin Oluşturulan Bu Birliğin Adı Nedir?\nA- Kutsal İttifak\nB- Kutsal Haçlı Birliği\nC- Kutsal Roma\nC- Kutsal Bizans");
                string sosyalcevap5;
                Console.Write("Cevabınız: ");
                sosyalcevap5 = Console.ReadLine();

                if (sosyalcevap5 == "A")
                {
                    Console.WriteLine("Cevabınız Doğru!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış!");

                    Console.ReadLine();
                    Console.ReadKey();
                }
                Console.ReadLine();
                Console.WriteLine("Cevap Anahtarı: B, C, B, C, A");
                Console.WriteLine("Sosyal Bilgiler Problemleriniz Bitti...");
                Console.WriteLine("Değerli Kullanıcı;\nBaşarılı Bir Şekilde Bütün Soruları Cevapladınız. Oynadığınız İçin Teşekkürler");
                Console.WriteLine("Programming By Sh4d0wE4");
                Console.ReadKey();
                Console.WriteLine("Oyundan Çıkmak İçin ENTER Tuşuna Basmanız Yeterlidir.");
                Console.ReadKey();
            }
            if (secim == "2")
            {
                Console.Clear();
                string cevap;
                Console.Write("Çıkmak İstediğinize Emin Misiniz: ");
                cevap = Console.ReadLine();

                if (cevap == "Evet")
                {
                    Console.WriteLine("Oyundan Çıkış Yapılıyor...");
                    Console.ReadKey();
                }
                if (cevap == "Hayır")
                {
                    Console.WriteLine("Oyun Yeniden Başlatılacak...");
                    Console.ReadKey();
                    KimMilyonerOlmakİsterV1();
                }
            }
        }
    }
}
