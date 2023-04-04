
### [TR] - Türkçe Açıklama 
## TurkishTransformer

Bu C# kodu, Türkçe sayıları alfanumerik olarak yazılmış bir girdi olarak alır ve bunları sayısal değerlere dönüştürür. Daha sonra, bu sayıları cümle içindeki sayılara karşılık gelen sayısal ifadelerle değiştirerek çevirilmiş bir cümle döndürür.

Kod, bir sınıf içinde iki yöntem içerir: "ConvertToNumbers" ve "GetDigits", ayrıca bir sözlük "Numbers" içerir.

"Numbers" sözlüğü, Türkçe sayıları ve bunların sayısal değerlerini içerir. Örneğin, "bir" 1, "on" 10, "yüz" 100 vb. İle eşleştirilir.

"ConvertToNumbers" yöntemi, Türkçe cümleyi alır ve önceki sözlüğü kullanarak her kelimenin sayısal değerini hesaplar. Bu hesaplama işlemi, "GetDigits" yöntemi aracılığıyla gerçekleştirilir. Her bir kelimenin sayısal değeri, sözlükteki karşılığına göre hesaplanır. Daha sonra, cümledeki sayıları değiştirerek bir çıktı dizesi oluşturulur.

"GetDigits" yöntemi, sözlükteki sayısal değerleri hesaplamak için kullanılır. Bu yöntem, sözlükteki her sayısal değer için bir durum tablosu kullanarak sayıyı hesaplar. Örneğin, 120'yi hesaplamak için, "yüz" kelimesi ilk olarak hesaplanır, ardından "yirmi" kelimesi ve ardından "bir" kelimesi hesaplanır. Daha sonra, bu sayısal ifadelerin çarpımı, sayının toplam değerini oluşturur.

Son olarak, "Translate" yöntemi, "ConvertToNumbers" yöntemini çağırır ve elde edilen sayısal ifadeleri cümle içindeki sayılara karşılık gelen ifadelerle değiştirir. Bu işlem, her sayısal ifadenin "GetDigits" yöntemi ile hesaplanmasıyla gerçekleştirilir. Sonuç olarak, bu yöntem, Türkçe cümleyi sayısal ifadelere çevirir ve bu sayısal ifadeleri cümle içindeki sayılara karşılık gelen ifadelerle değiştirerek çevrilmiş bir cümle döndürür.


## Detaylı Açıklama
-Translate(string input) metodu, girdi dizesini sayılara dönüştürür ve sonucu birleştirerek döndürür.

-ConvertToNumbers(string words) metodu, verilen girdi dizesini parçalara ayırır ve her bir parçayı sayıya dönüştürür. Bu işlem sırasında, Regex sınıfı kullanılarak dize içindeki kelime eşleşmeleri bulunur ve bunlar ayrı bir liste halinde saklanır. Daha sonra, her kelimenin sayıya dönüştürülebilir olup olmadığını belirlemek için Numbers sözlüğü kullanılır. Sayıya dönüştürülebilir olan kelimelerin sayı değerleri ayrı bir liste halinde saklanır ve GetDigits() metodu kullanılarak bu sayılar birleştirilerek tek bir sayıya dönüştürülür.

-GetDigits(IEnumerable<long> numbers, int signatureFlag = 1) metodu, sayıları birleştirerek son sayısal değeri hesaplar. Bu hesaplama işlemi, percentile ve result adında iki değişken kullanarak yapılır. percentile, sayının yüzler, binler, milyonlar gibi basamaklarına karşılık gelirken, result ise hesaplanan sonuç değerini tutar.



### [EN] - English Description 
## TurkishTransformer

This C# code takes Turkish numbers as an alphanumeric input and converts them to numeric values. It then replaces those numbers with numeric expressions that correspond to the numbers in the sentence, returning a translated sentence.

The code contains two methods inside a class: "ConvertToNumbers" and "GetDigits", also includes a dictionary "Numbers".

"Numbers" dictionary contains Turkish numbers and their numerical values. For example, "one" is 1, "ten" is 10, "one hundred" is 100, etc. It is paired with.

The "ConvertToNumbers" method takes the Turkish sentence and calculates the numerical value of each word using the previous dictionary. This calculation is done via the "GetDigits" method. The numerical value of each word is calculated based on its equivalent in the dictionary. An output string is then created by replacing the numbers in the sentence.

The "GetDigits" method is used to calculate numeric values in the dictionary. This method calculates the number using a state table for each numeric value in the dictionary. For example, to calculate 120, the word "hundred" is calculated first, followed by the word "twenty" and then the word "one". Then, the product of these numeric expressions creates the total value of the number.

Finally, the "Translate" method calls the "ConvertToNumbers" method and replaces the resulting numeric expressions with expressions corresponding to the numbers in the sentence. This is done by calculating each numeric expression with the "GetDigits" method. As a result, this method converts the Turkish sentence to numeric expressions and returns a translated sentence by replacing these numeric expressions with expressions corresponding to the numbers in the sentence.


## Detailed Description
-Translate(string input) method converts the input string to numbers and returns the result concatenated.

The -ConvertToNumbers(string words) method splits the given input string into parts and converts each part to a number. During this process, word matches within the string are found using the Regex class and they are stored in a separate list. The Numbers dictionary is then used to determine whether each word is convertible to numbers. The number values of words that can be converted to numbers are stored in a separate list and these numbers are combined into a single number using the GetDigits() method.

The -GetDigits(IEnumerable<long> numbers, int signatureFlag = 1) method calculates the final numeric value by concatenating the numbers. This calculation is done using two variables named percentile and result. percentile corresponds to the digits of the number such as hundreds, thousands, millions, while result holds the calculated result value.


### Usage

``` csharp
// Crate Instance using Factory 
var transformer = TransformerFactory.Create(TransformerFactory.NameOfInstance.TurkishTransformer) as TurkishTransformer;
// Specifying an input value
string input = "Elli altı bin lira kredi alıp üç yılda geri ödeyeceğim"          
// converting the input 
var output = transformer.Translate(input);
return Ok(new { Output = output });
//Output = 56000 lira kredi alıp 3 yılda geri ödeyeceğim 
```
