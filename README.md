# Asp.Net Core Api 8.0 Onion Architecture ile BookCar Projesi

## Proje Açıklaması
Bu proje, Murat Yücedağ'ın Udemy kursu kapsamında geliştirilen kapsamlı bir araç kiralama ve yönetim sistemidir. Asp.Net Core Api 8.0 ve Onion Architecture kullanılarak geliştirilmiştir.

## İçerik
Bu projede, aşağıdaki teknolojiler ve tasarım desenleri kullanılmıştır:
- **Backend Teknolojileri:**
  - Asp.Net Core Api 8.0
  - Onion Architecture
  - CQRS (Command Query Responsibility Segregation)
  - Mediator Design Pattern
  - MSSQL
  - Entity Framework Core
  - Code First
  - Fluent Validation
- **Frontend Teknolojileri:**
  - HTML
  - CSS
  - Bootstrap
  - JavaScript
  - ViewComponents
- **Ek Özellikler:**
  - Pivot Table
  - Dto Layer
  - JWT (JSON Web Tokens)
  - SignalR
  - Swagger & Postman

## Kullanım
Proje, kullanıcıların belirli bir konuma göre araç kiralayabileceği ve yönetebileceği kullanıcı dostu bir platform sunar. Yönetici paneli üzerinden, yöneticiler içerikleri yönetebilir ve yeni araç ile lokasyon bilgileri ekleyebilirler.

## Özellikler
- **Kullanıcılar:** Araç arama ve kiralama.
- **Yöneticiler:** Yeni araç ve lokasyon ekleme, mevcut içerikleri yönetme.
- **Güvenlik:** JWT ile kimlik doğrulama.
- **Gerçek Zamanlı İletişim:** SignalR ile bildirimler.
- **Veri Doğrulama:** Fluent Validation kullanımı.

## Proje Ekran Görüntüleri

![Screenshot_1](https://github.com/user-attachments/assets/0e6b8bab-b15a-4118-a827-696b585d5553)
![Screenshot_13](https://github.com/user-attachments/assets/5f094cb2-3aa1-4f6c-bdcc-326ca658b4f1)
![Screenshot_2](https://github.com/user-attachments/assets/1bf436cb-16d6-4813-8b9d-130c5c71d927)
![Screenshot_3](https://github.com/user-attachments/assets/628b44d4-e6be-412b-bf26-a92cc6b5f910)
![Screenshot_4](https://github.com/user-attachments/assets/367ed7a4-60a5-4fd8-94af-05eb9ad21032)
![Screenshot_5](https://github.com/user-attachments/assets/d4e33112-7109-4fb5-8711-4f99f794185b)
![Screenshot_6](https://github.com/user-attachments/assets/fb03dd65-a663-4c21-b84a-995ebc862b47)
![Screenshot_7](https://github.com/user-attachments/assets/32b38437-32b5-4cab-af2d-926c5783cbb2)
![Screenshot_8](https://github.com/user-attachments/assets/dae20d58-ffa8-4968-b0cf-9072e8e4429d)
![Screenshot_9](https://github.com/user-attachments/assets/58e9f47b-7d6d-4e87-a91b-9cb99d7cf7dd)
![Screenshot_10](https://github.com/user-attachments/assets/2997668d-edb6-4b67-820e-0a4c79073604)
![Screenshot_11](https://github.com/user-attachments/assets/24cf4a9d-4092-4b3d-bb2c-9c71fa5dd51b)
![Screenshot_12](https://github.com/user-attachments/assets/107a7827-0ceb-4eee-96b5-fef8873a7480)

## Kurulum

1. **Proje Depolanmasını Klonlayın:**
   ```bash
   git clone https://github.com/beratmusdal/Asp.Net-Core-Api-8.0-Onion-Architecture-ile-BookCar-Projesi.git
   ```

2. **Proje Dizine Geçin:**
   ```bash
   cd Asp.Net-Core-Api-8.0-Onion-Architecture-ile-BookCar-Projesi
   ```

3. **Gerekli Bağımlılıkları Yükleyin:**
   ```bash
   dotnet restore
   ```

4. **Veritabanını Güncelleyin:**
   ```bash
   dotnet ef database update
   ```

5. **Projeyi Çalıştırın:**
   ```bash
   dotnet run
   ```

