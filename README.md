TechSpot<br />
Teknoloji Konseptli Haberler Paylaşan Web Sitesi<br />

:information_source: Bu websitenin geliştirimesinin amacı html,css,js ve .net MVC teknolojilerini kullanarak içerisinde temel UI tasarımı,Entity Framework kullanarak CRUD ve database işlemleri,LINQ kullanımı ve ilişkili sorgu işlemleri içeren bir websitesi oluşturmaktır. <br />

:information_source: Bu web sitesi 20 Ocak 2025 tarihinde başlayan Techcareer.net kurumunun gerçekleştirdiği Beginner Full Stack Bootcamp programı kapsamında edinilen bilgileri uygulamak ve bu programdan mezun olmak amacıyla geliştirilmiştir.<br />

Web Sitenin Genel Yapısı ve Özellikleri:<br />

:heavy_check_mark: Web site açıldığında kullanıcıyı bir anasayfa karşılar.Bu anasayfada layout üzerine oturtulmuş bir header ve footer bulunmaktadır.Bu ikisinin arasında ise bulunulan sayfanın Index sayfası görüntülenir.Anasayfada öncelikle öne çıkan haberlerin bulunduğu bir slider daha sonra diğer haberlerin kartlar ile listelendiği bir haber akışı bulunmaktadır.<br />

:heavy_check_mark: Header kısmında kullanıcının tıklayarak gidebileceği anasayfa,kategoriler,hakkımızda&iletişime geçin şeklinde 3 yönlendirme butonu ve sosyal medyalar,profil,arama gibi fonksiyonların olduğu ikonlar bulunmaktadır.<br />

:heavy_check_mark: Footer kısmında ise site hakkında genel bilgi veren ve bir iletişim adresi bulunan genel bir kısım vardır.<br />

:heavy_check_mark: Anasayfada veritabanına kaydedilen haber verileri çekilir ve slider kısmında IsFeatured alanı true olan haberler görüntülenir.Haber akışı kısmında ise çekilen tüm haberler card şeklinde listelenerek görüntülenir.<br />

:heavy_check_mark: Haber akışındaki haber kartının sağ alt kısmında bulunan düzenle butonuna basılarak ilgili haberin verilerinde düzenleme yapılacak sayfaya gidilir,burada istenen değişiklikler yapılarak güncelle butonuna basıldığında ilgili haberin alanları veritabanında güncellenir.<br />

:heavy_check_mark: Yine haber kartının sağ alt kısmında bulunan silme butonuna basıldığında o haberin silinmek istendiğinden emin olunup olunmadığı sorulur evete basılırsa haber veritabanından silinir,hayıra basılırsa önceki sayfaya geri dönülür.<br />

:heavy_check_mark: Header üzerinde bulunan kategoriler butonuna basıldığında veritabanında Categories tablosunda bulunan kategoriler dinamik olarak dropdown menu üzerinde listelenir.Kullanıcı bu kategorilerden herhangi birine tıklandığında o kategoriye ait haberlerin card şeklinde listenelerek görüntülendiği sayfaya yönlendirilir.<br />

:heavy_check_mark: Haberlerin başlığına tıklandığında haber detaylarının görüntülendiği detay sayfası açılır,bu sayfada haber başlığı,açıklaması,resmi,kategorisi gibi bilgiler kullanıcıya gösterilir.<br />


Kullanılan Diller ve Teknolojiler:<br />

:pushpin: HTML<br />
:pushpin: CSS<br />
:pushpin: Bootstrap<br />
:pushpin: Javascript<br />
:pushpin: Entity Framework Core<br />
:pushpin: Microsoft SQL Server<br />
:pushpin: .NET Core MVC<br />

Projeden Görseller:<br />
Anasayfa<br />
![Anasayfa 1](./readme-images/anasayfa1_1.jpg)<br /><br />
![Anasayfa 2](./readme-images/anasayfa2_2.jpg)<br /><br />
Haber Ekleme<br />
![Haber Ekleme](./readme-images/haberekle_1.jpg)<br /><br />
Haber Güncelleme<br />
![Haber Güncelleme](./readme-images/habergüncelle_1.jpg)<br /><br />
Haber Sil<br />
![Haber Sil](./readme-images/habersil_1.jpg)<br /><br />
Haber Detayları<br />
![Haber Detayları](./readme-images/haberdetayları_1.jpg)<br /><br />
Kategorilendirme<br />
![Kategorilendirme](./readme-images/kateogirlendirme_1.jpg)<br /><br />

Bu proje Yusuf Uğuz tarafından geliştirilmiştir. [YusufUguz](https://github.com/YusufUguz)<br />
