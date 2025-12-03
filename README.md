# GuresArenasi
https://aynuradibelli.itch.io/gre-arenas

# 🥇 Güreş Arenası – WebGL Oynanabilir Oyun

Bu proje, Unity kullanılarak geliştirilmiş basit bir **3D Arena Güreşi / İtme Mücadelesi** oyunudur.  
Oyuncu ve rakip karakterin en az dört aksiyona sahip olduğu, ses–müzik ayarları bulunan  
ve tarayıcıda oynanabilir WebGL sürümü olan bir oyundur.

🎮 **Oyunu tarayıcıda hemen oyna:**  
👉 https://aynuradibelli.itch.io/gre-arenas

---

## 📌 Proje Özeti

- Oyuncu ve rakip karakter olmak üzere iki karakter içerir.
- Oyuncu 4 aksiyona sahiptir:  
  - **Dash** (Hızlı hücum)
  - **Shoulder Push** (Omuzla itme)
  - **Slam Jump** (Zıplama + çarpma etkisi)
  - **Power Mode** (Geçici güç artışı)
- Rakip karakter de 4 farklı aksiyon metoduna sahiptir (ileriki aşamada AI tarafından kullanılacak şekilde hazırlanmıştır).
- Arena dışına düşen oyuncu kaybeder; rakip düşerse oyuncu kazanır.
- Kamera oyuncuyu dinamik şekilde takip eder.
- Oyun WebGL olarak build edilmiştir.

---

## 🎮 Kontroller

| Tuş | Aksiyon |
|-----|---------|
| **Ok Tuşları** | Hareket |
| **Shift** | Dash |
| **Q** | Shoulder Push |
| **Space** | Slam Jump |
| **E** | Power Mode |

---

## 🔊 Ses ve Müzik Ayarları

Ana menüde iki adet ses kontrol barı bulunur:

- 🎵 **Müzik Sesi** (Müzik yüksekliği)
- 🔈 **Efekt Sesi** (Efekt sesleri yüksekliği)

Her ikisi Unity AudioMixer ile kontrol edilir.

---

## 🧠 Rakip Aksiyonları (AI için hazır)

Rakip bu aşamada *AI barındırmaz*, ancak gelecekte kullanılmak üzere aşağıdaki aksiyon fonksiyonları hazırlanmıştır:

- `CounterPush()`  
- `HeavyMode()`  
- `CreateSlipZone()`  
- `Charge()`

Henüz tetiklenmez; sonraki aşamada ML-Agent veya davranış ağacı ile kullanılacaktır.

---

## 🏗 Sahne Düzeni

Projede iki sahne bulunur:

1. **MainMenu** – Oyun başlatma + ses ayarları
2. **GameScene** – Oyunun oynandığı arena sahnesi

---

## 🕹 WebGL Build

Oyun, WebGL platformunda çalışacak şekilde optimize edilmiştir.

Itch.io üzerindeki sürümde:

- Menü ve ses ayarları çalışır
- Kamera takip sistemi sorunsuzdur
- Oyuncu ve rakip fiziksel olarak çarpışır
- Kazanma / kaybetme panelleri çalışır

---

## 📁 Proje Yapısı

Projede aşağıdaki klasörler bulunur:

- `Assets/`  
- `Packages/`  
- `ProjectSettings/`  

`.gitignore` sayesinde Unity’nin gereksiz klasörleri (Library, Logs, Temp, obj, Build vb.) depoya dahil edilmemiştir.

---

## 👩‍💻 Kullanılan Teknolojiler

- **Unity 2022/2023**
- **C#**
- **Unity Physics**
- **Unity UI Toolkit / TextMeshPro**
- **AudioMixer**
- **WebGL Build**

---

## 📜 Lisans

Bu proje eğitim amaçlıdır ve bireysel olarak geliştirilmiştir.


