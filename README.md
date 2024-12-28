# SkyRun-2D

SkyRun adalah game 2D sederhana yang dikembangkan menggunakan C# dan Windows Forms, di mana pemain mengendalikan karakter untuk melompat dan menghindari rintangan yang datang. Game ini memiliki sistem skor di mana pemain mendapatkan poin untuk setiap rintangan yang berhasil dihindari. Game akan berakhir jika pemain bertabrakan dengan rintangan.

## Fitur:
- **Gerakan Karakter**: Pemain mengendalikan karakter yang dapat melompat.
- **Rintangan**: Rintangan muncul dari sisi kanan layar dan bergerak ke kiri. Pemain harus menghindarinya.
- **Skor**: Skor meningkat setiap kali pemain berhasil menghindari rintangan.
- **Game Over**: Game berakhir jika pemain bertabrakan dengan rintangan.

## Mekanika Game:
- **Melompat**: Tekan tombol `Up` (panah atas) untuk membuat karakter pemain melompat.
- **Tabrakan**: Game berakhir jika pemain bertabrakan dengan rintangan.
- **Skor**: Skor ditampilkan di pojok kiri atas layar dan meningkat setiap kali pemain menghindari rintangan.

## Prasyarat:
- **Lingkungan pengembangan C#** (Visual Studio disarankan).
- **.NET Framework** (atau **.NET Core** untuk platform lain).
- **Library Windows Forms** untuk antarmuka grafis.

## Cara Menjalankannya
1. Clone atau unduh repositori ini.
2. Buka file solusi `SkyRun.sln` di **Visual Studio**.
3. Pastikan aset yang diperlukan (`player.png`, `obstacle.png`, `background.jpg`) ada di folder **Assets/**.
4. Bangun dan jalankan aplikasi dengan menekan tombol `F5` di Visual Studio.

## Aset:
- `player.png`: Gambar karakter pemain.
- `obstacle.png`: Gambar rintangan.
- `background.jpg`: Gambar latar belakang untuk game.

