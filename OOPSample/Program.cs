


using AngleSharp.Io.Dom;
using System.Collections.Generic;
using OOPSample;


//film service class dan instance aldık


List<Film> films = FilmService.GetFilms();


//Kaç adet film var?
//Console.WriteLine(films.Count);


//LINQ veya LAMBDA EXPRESSIONS

//2000 sonrası filmler hangileri?
List<Film> films1 = films.Where(q => q.Year > 2000).ToList();

//a harfi ile başlayan filmler hangileri
List<Film> films2 = films.Where(q => q.Name.StartsWith('a')).ToList();

// a harfi ile biten filmler neler
List<Film> films3 = films.Where(q => q.Name.EndsWith('a')).ToList();

//Puanı 8.1 den büyük olan filmeri bana ver
List<Film> films4 = films.Where(q => q.Point > 4).ToList();

//Puanı 7 den küçük VE 2000 sonrası filmler
List<Film> films5 = films.Where(q => q.Point < 7 && q.Year > 2000).ToList();

//En uzun film kaç dakika?
List<Film> films6 = films.OrderByDescending(q => q.Time).ToList();

// Filmin adının içerisinde x harfi geçen filmler?
List<Film> films7 = films.Where(q => q.Name.Contains("x")).ToList();

//filmeri ada göre tersten sırala
List<Film> films8 = films.OrderByDescending(q => q.Name).ToList();



// 1) Puanı 5 ile 10 arasındaki filmleri listele
//where keyword ile bir filtreleme işlemi yapıyorum. ( sql deki where düşünebilirsiniz. )
var films9 = films.Where(q => q.Point >= 5 && q.Point <= 10).ToList();

//foreach (var item in films9)
//{
//    Console.WriteLine("Name: " + item.Name + " Point: " + item.Point);
//}



// 2) Filmleri ada göre sırala ve ilk 10 filmi ekrana yaz
//Take metodu ile kaç adet eleman alacağımı belirtiyorum.SQL deki TOP keywordune karsılık gelir
List<Film> films10 = films.OrderBy(q => q.Name).Take(10).ToList();

//foreach (var item in films10)
//{
//    Console.WriteLine("Name: " + item.Name);
//}

// 3) Yılı 2000 den büyük kaç adet film var?
//Count metot olarak ve property olarak kullanabiliriz.
int count = films.Where(q => q.Year > 2000).Count();
int count2 = films.Where(q => q.Year > 2000).ToList().Count;


// 4) Adının içerisinde X harfi geçen filmler
List<Film> films11 = films.Where(q => q.Name.Contains('x')).ToList();


//5) Id si 5 olan film hangisidir?
Film film = films.FirstOrDefault(q => q.Id == 5);

//6) Adı Whiplash olan filmi bana ver
Film film2 = films.FirstOrDefault(q => q.Name == "Whiplash");

//7) Puanı en yüksek filmin adını ekrana yazdır
Film film3 = films.OrderByDescending(q => q.Point).Take(1).FirstOrDefault();

//8) Puanı en düşük filmin adını ekrana yazdır
Film film4 = films.OrderByDescending(q => q.Point).Take(1).FirstOrDefault();

//Console.WriteLine("Name :" + film3.Name + "Point: " + film3.Point);
//Console.WriteLine("Name :" + film4.Name + "Point: " + film4.Point);



// Adının içerisinde w harfi geçen film var mı?
bool hasFilm = films.Any(q => q.Name.Contains('x'));


// WHERE
// ORDER BY
// ORDER BY DESC
// TAKE
// FirstOrDefault
// Any

List<City> cities = CityService.GenerateRandomCities();

// ID si 5 olan şehrin ADI nedir?
City city = cities.FirstOrDefault(q => q.Id == 5);
//Console.WriteLine("Name :" + city.Name);


// İçerisinde x harfi geçen KAÇ ADET ŞEHİR VAR?
int count3 = cities.Where(q => q.Name.Contains('x')).Count();
//Console.WriteLine("Count: " +  count3);

// İki kelimelik şehirleri ekrana yaz. Kansas City gibi...
List<City> cities1 = cities.Where(q => q.Name.Trim().Contains(' ')).ToList();

foreach (var item in cities1)
{
    Console.WriteLine("Name: " + item.Name);
}

//List<City> cities2 = new List<City>();

//foreach (var item in cities)
//{
//    var namesCount = item.Name.Split(' ').Count();
//    if (namesCount > 1)
//    {
//        cities2.Add(item);
//    }
//}


//ID si 135 olan şehir?
//first metotdu içerisindeki koşula uygun data bulamazsa exception FIRLATIR firstordefault metodu ise exception FIRLATMAZ ONUN YERİNE NULL BİR DEĞER DÖNER!

City city1 = cities.FirstOrDefault(q => q.Id == 135);

if (city1 != null)
{
    Console.WriteLine(city1.Name);
}

//City city1 = cities.First(q => q.Id == 135);




List<Product> products = ProductService.GenerateProductData();

//Ürün fiyatı 50 ile 100 arasında olan ürünleri console a yaz
var products1 = products.Where(q => q.UnitPrice > 50 && q.UnitPrice < 100).ToList();

foreach (var item in products1)
{
   // Console.WriteLine("Name " + item.Name + " Price: " + item.UnitPrice);
}

//Id si 10 olan ürünün kategorisinin adı nedir?
Product product = products.FirstOrDefault(q => q.Id == 10);
Console.WriteLine("Category Name: " + product.Category?.Name);

//Stok değeri 5 in altına düşen ürünlerin adı, stoğu ve ürünün kategorisinin adını ekrana yaz

List<Product> products2 = products.Where(q => q.UnitsInStock < 5).ToList();

foreach (var item in products2)
{
    Console.WriteLine("Name: " + item.Name + " Stock: " + item.UnitsInStock + " Category: " + item.Category?.Name);
}


//kategori Id si 5 olan ürünleri listele
List<Product> products3 = products.Where(q => q.Category?.Id == 5).ToList();



//Kategori adında hi kelimesi geçen ürünler
List<Product> products4 = products.Where(q => q.Category.Name.Contains("hi")).ToList();



Console.Read();











