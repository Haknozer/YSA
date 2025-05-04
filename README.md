
# Yapay Sinir Ağı ile Harf Tanıma

Bu proje, C# kullanılarak geliştirilmiş basit bir **Yapay Sinir Ağı (YSA)** uygulamasıdır. Amaç, verilen giriş verilerine (örn. harf görüntüsü) karşılık doğru harfi tanımlamaktır.

## 🔧 Özellikler

- İki katmanlı (gizli ve çıkış) yapay sinir ağı
- Giriş verilerini `double[,]` matris olarak alır
- Sigmoid aktivasyon fonksiyonu kullanılır
- İleri besleme ve geri yayılım algoritmaları uygulanmıştır
- One-hot encoding ile çıktı vektörü oluşturulur
- Tahmin işlemi sonucu harf tespiti yapılır

## 🧠 Ağ Yapısı

```
Giriş → Gizli Katman → Çıkış Katmanı
```

- **Giriş Katmanı:** Görüntü verisi veya manuel giriş matris
- **Gizli Katman:** Ağırlıklarla çarpım ve sigmoid uygulanır
- **Çıkış Katmanı:** 5 sınıflı çıktı (A, B, C, D, E) ile sonlandırılır

## 📁 Proje Dosya Yapısı

```
├── Program.cs
├── NeuralNetwork.cs
├── README.md
```

## 🚀 Kullanım

1. Projeyi derleyin ve çalıştırın.
2. Eğitim verisini ve hedef çıktıyı vererek ağı eğitin.
3. `TahminEt()` fonksiyonu ile test verisini girerek çıktı vektörünü alın.
4. Çıktı vektisindeki en yüksek değerin indeksi, tahmin edilen harfi temsil eder.

### Örnek Kullanım

```csharp
double[,] ornekGiris = new double[,] {
    { 0, 1, 1 },
    { 1, 0, 1 },
    { 0, 1, 0 }
};

double[] sonuc = neuralNetwork.TahminEt(ornekGiris);

// En yüksek değeri bulup harf tahmini yapılır
int tahminIndex = Array.IndexOf(sonuc, sonuc.Max());
char[] harfler = { 'A', 'B', 'C', 'D', 'E' };
Console.WriteLine("Tahmin Edilen Harf: " + harfler[tahminIndex]);
```

## 📚 Kullanılan Yöntemler

- **İleri Besleme (Feedforward)**
- **Geri Yayılım (Backpropagation)**
- **Sigmoid aktivasyon fonksiyonu**
- **One-Hot Encoding**
- **Mean Squared Error (isteğe bağlı)**

## ⚠️ Notlar

- Eğitim verisi yeterince çeşitlendirilmemişse tahmin doğruluğu düşebilir.
- Ağırlıklar rastgele başlatılır, bu nedenle sonuçlar her seferinde farklı olabilir.
- Daha karmaşık veri setleri için ağın katman sayısı ve nöron sayısı artırılabilir.

## 🧑‍💻 Geliştirici

Hakan Özer  
3. Sınıf Bilgisayar Mühendisliği Öğrencisi  
Selçuk Üniversitesi
