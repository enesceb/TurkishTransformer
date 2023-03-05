### TurkishTransformer

Bu C# kodu, Türkçe sayıları alfanumerik olarak yazılmış bir girdi olarak alır ve bunları sayısal değerlere dönüştürür. Daha sonra, bu sayıları cümle içindeki sayılara karşılık gelen sayısal ifadelerle değiştirerek çevirilmiş bir cümle döndürür.

Kod, bir sınıf içinde iki yöntem içerir: "ConvertToNumbers" ve "GetDigits", ayrıca bir sözlük "Numbers" içerir.

"Numbers" sözlüğü, Türkçe sayıları ve bunların sayısal değerlerini içerir. Örneğin, "bir" 1, "on" 10, "yüz" 100 vb. İle eşleştirilir.

"ConvertToNumbers" yöntemi, Türkçe cümleyi alır ve önceki sözlüğü kullanarak her kelimenin sayısal değerini hesaplar. Bu hesaplama işlemi, "GetDigits" yöntemi aracılığıyla gerçekleştirilir. Her bir kelimenin sayısal değeri, sözlükteki karşılığına göre hesaplanır. Daha sonra, cümledeki sayıları değiştirerek bir çıktı dizesi oluşturulur.

"GetDigits" yöntemi, sözlükteki sayısal değerleri hesaplamak için kullanılır. Bu yöntem, sözlükteki her sayısal değer için bir durum tablosu kullanarak sayıyı hesaplar. Örneğin, 120'yi hesaplamak için, "yüz" kelimesi ilk olarak hesaplanır, ardından "yirmi" kelimesi ve ardından "bir" kelimesi hesaplanır. Daha sonra, bu sayısal ifadelerin çarpımı, sayının toplam değerini oluşturur.

Son olarak, "Translate" yöntemi, "ConvertToNumbers" yöntemini çağırır ve elde edilen sayısal ifadeleri cümle içindeki sayılara karşılık gelen ifadelerle değiştirir. Bu işlem, her sayısal ifadenin "GetDigits" yöntemi ile hesaplanmasıyla gerçekleştirilir. Sonuç olarak, bu yöntem, Türkçe cümleyi sayısal ifadelere çevirir ve bu sayısal ifadeleri cümle içindeki sayılara karşılık gelen ifadelerle değiştirerek çevrilmiş bir cümle döndürür.


### Detaylı Açıklama
-Translate(string input) metodu, girdi dizesini sayılara dönüştürür ve sonucu birleştirerek döndürür.

-ConvertToNumbers(string words) metodu, verilen girdi dizesini parçalara ayırır ve her bir parçayı sayıya dönüştürür. Bu işlem sırasında, Regex sınıfı kullanılarak dize içindeki kelime eşleşmeleri bulunur ve bunlar ayrı bir liste halinde saklanır. Daha sonra, her kelimenin sayıya dönüştürülebilir olup olmadığını belirlemek için Numbers sözlüğü kullanılır. Sayıya dönüştürülebilir olan kelimelerin sayı değerleri ayrı bir liste halinde saklanır ve GetDigits() metodu kullanılarak bu sayılar birleştirilerek tek bir sayıya dönüştürülür.

-GetDigits(IEnumerable<long> numbers, int signatureFlag = 1) metodu, sayıları birleştirerek son sayısal değeri hesaplar. Bu hesaplama işlemi, percentile ve result adında iki değişken kullanarak yapılır. percentile, sayının yüzler, binler, milyonlar gibi basamaklarına karşılık gelirken, result ise hesaplanan sonuç değerini tutar.

### Neden IEnumerable kullanılmıştır?
IEnumerable kullanımının sebebi, metotların birbirine bağımlılığı ve liste işlemlerinde kolaylık sağlamasıdır. ConvertToNumbers metodu, girdi dizesini Regex sınıfı kullanarak kelimelere ayırır ve her kelimenin sayıya dönüştürülebilir olup olmadığını belirlemek için Numbers sözlüğünü kullanır. Sayıya dönüştürülebilir olan kelimelerin sayı değerleri GetDigits() metodu tarafından kullanılmak üzere ayrı bir liste halinde saklanır. Bu nedenle, IEnumerable kullanımı, metotlar arasındaki veri geçişini kolaylaştırır ve liste işlemlerinin yapılmasını sağlar.

### Usage

``` csharp

  var transformer = TransformerFactory.Create(TransformerFactory.NameOfInstance.TurkishTransformer) as TurkishTransformer;
   string input = "Elli altı bin lira kredi alıp üç yılda geri ödeyeceğim"          
// converting the input 
var output = transformer.Translate(input);
            return Ok(new { Output = output });
// 56000 lira kredi alıp 3 yılda geri ödeyeceğim 

```
