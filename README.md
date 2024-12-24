## Parking system
Bangun sistem parkir menggunakan .net 5 tanpa menggunakan ui, cukup mengunakan console. Dengan menggunakan sistem lot, tiap lot bisa muat 1 mobil dan 1 motor, tiap orang mendapatkan quota 1 lot. Terdapat jumlah total lot tertentu di setiap tempatnya.

### Check-In
i.Semua kendaraan bebas menggunakan lot yang tersedia
ii.Kendaraan yang boleh masuk hanya Mobil Kecil dan Motor.
iii.Setiap kendaraan yang masuk di catat Berdasarkan Nomor Polisi-nya.
iv.Perhitungan biaya parkir adalah per jam, untuk yang baru masuk sudah di hitung 1 jam.

### Check-out
i.Setiap kendaraan yang sudah checkout lot tersebut akan available dan bisa di gunakan oleh orang lain.

### Report
i.Dibutuhkan laporan jumlah lot yang terisi.
ii.Dibutuhkan laporan jumlah lot yang tersedia.
iii.Dibutuhkan laporan jumlah kendaraan berdasarkan nomor kendaraan ganjil dan genap.
iv.Dibutuhkan laporan jumlah kendaraan berdasarkan jenis kendaraan.
v.Dibutuhkan laporan jumlah kendaraan berdasarkan warna kendaraan.

## .NET 8 Application
This is a sample .NET 8 application. The following instructions will guide you through the process of setting up and running the application on your local machine.

## Prerequisites
Before running the application, make sure you have the following installed:

## .NET 8 SDK (version 8)
Visual Studio 2022 or Visual Studio Code with the C# extension
Git (for cloning the repository)
Verify .NET Installation
To verify that .NET is installed, open a terminal/command prompt and run:

```bash
dotnet --version
```
This should return the version of .NET installed, e.g., 8.x.x

### Getting Started
1. Clone the Repository
If you haven't already, clone the repository to your local machine:

```bash
git clone https://github.com/vchandra22/parkinglot-dotnet-console.git
```
cd parkinglot-dotnet-console
2. Install Dependencies
Navigate to the root folder of your project in the terminal. If your project uses additional packages or dependencies, restore them using the following command:

```bash
dotnet restore
```
3. Build the Application
Once the dependencies are restored, you can build the application:

```bash
dotnet build
```
This will compile the project and prepare it to be run.

4. Run the Application
To run the application locally, use the following command:

```bash
dotnet run
```
This will start the application, and you should see output in the terminal indicating that the app is running.
