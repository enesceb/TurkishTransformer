# TurkishTransformer

Bu C# kodu, Türkçe sayıları alfanumerik olarak yazılmış bir girdi olarak alır ve bunları sayısal değerlere dönüştürür. Daha sonra, bu sayıları cümle içindeki sayılara karşılık gelen sayısal ifadelerle değiştirerek çevirilmiş bir cümle döndürür.

Kod, bir sınıf içinde iki yöntem içerir: "ConvertToNumbers" ve "GetDigits", ayrıca bir sözlük "Numbers" içerir.

"Numbers" sözlüğü, Türkçe sayıları ve bunların sayısal değerlerini içerir. Örneğin, "bir" 1, "on" 10, "yüz" 100 vb. İle eşleştirilir.

"ConvertToNumbers" yöntemi, Türkçe cümleyi alır ve önceki sözlüğü kullanarak her kelimenin sayısal değerini hesaplar. Bu hesaplama işlemi, "GetDigits" yöntemi aracılığıyla gerçekleştirilir. Her bir kelimenin sayısal değeri, sözlükteki karşılığına göre hesaplanır. Daha sonra, cümledeki sayıları değiştirerek bir çıktı dizesi oluşturulur.

"GetDigits" yöntemi, sözlükteki sayısal değerleri hesaplamak için kullanılır. Bu yöntem, sözlükteki her sayısal değer için bir durum tablosu kullanarak sayıyı hesaplar. Örneğin, 120'yi hesaplamak için, "yüz" kelimesi ilk olarak hesaplanır, ardından "yirmi" kelimesi ve ardından "bir" kelimesi hesaplanır. Daha sonra, bu sayısal ifadelerin çarpımı, sayının toplam değerini oluşturur.

Son olarak, "Translate" yöntemi, "ConvertToNumbers" yöntemini çağırır ve elde edilen sayısal ifadeleri cümle içindeki sayılara karşılık gelen ifadelerle değiştirir. Bu işlem, her sayısal ifadenin "GetDigits" yöntemi ile hesaplanmasıyla gerçekleştirilir. Sonuç olarak, bu yöntem, Türkçe cümleyi sayısal ifadelere çevirir ve bu sayısal ifadeleri cümle içindeki sayılara karşılık gelen ifadelerle değiştirerek çevrilmiş bir cümle döndürür.
