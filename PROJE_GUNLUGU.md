# Proje Günlüğü

Bu dosya, projede yapılan işleri adım adım takip etmek içindir. README sade kalır, proje geçmişi burada birikir.

## Kullanım Kuralı

Her commit atmadan önce, aşağıdaki şablonu bu dosyanın en üstüne (Geçmiş bölümüne) yeni bir madde olarak ekle:

```
## [YYYY-MM-DD] Kısa Başlık
- Commit: <hash veya geçici>
- Kapsam: <hangi ekran/feature>
- Etkilenen Dosyalar:
  - <dosya-yolu-1>
  - <dosya-yolu-2>
- Yapılanlar:
  - ...
  - ...
- Not: <opsiyonel teknik not>
```

---

## Geçmiş (Başlangıçtan Bugüne)

### [2026-03-03] Proje ilk kurulum
- Commit: a5fcdd0
- Kapsam: Başlangıç altyapısı
- Etkilenen Dosyalar:
  - `.gitattributes`
  - `.gitignore`
- Yapılanlar:
  - Git dosyaları (.gitattributes, .gitignore) oluşturuldu.

### [2026-03-03] Solution dosyası oluşturuldu
- Commit: 31398a5
- Kapsam: Solution yapısı
- Etkilenen Dosyalar:
  - `RentCarServer/RentCarServer.slnx`
- Yapılanlar:
  - .NET solution dosyası oluşturuldu.

### [2026-03-03] Domain katmanı — Entity base class
- Commit: ee0dbf7
- Kapsam: Domain katmanı
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/Entiy.cs`
  - `RentCarServer/src/RentCarServer.Domain/RentCarServer.Domain.csproj`
- Yapılanlar:
  - Domain katmanı oluşturuldu.
  - `Entity` base class eklendi.

### [2026-03-03] Domain katmanı — Warning'leri hataya dönüştürme
- Commit: 21840f2
- Kapsam: Domain katmanı
- Etkilenen Dosyalar:
  - `RentCarServer/RentCarServer.slnx`
  - `RentCarServer/src/.editorconfig`
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/Entity.cs`
  - `RentCarServer/src/RentCarServer.Domain/RentCarServer.Domain.csproj`
- Yapılanlar:
  - `.editorconfig` ile kod standartları tanımlandı.
  - Warning'ler hataya dönüştürüldü.
  - `Entity` sınıfı düzenlendi.

### [2026-03-03] Application katmanı oluşturuldu
- Commit: 68ed694
- Kapsam: Application katmanı
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Behaviors/PermissionBehavior.cs`
  - `RentCarServer/src/RentCarServer.Application/Behaviors/ValidationBehavior.cs`
  - `RentCarServer/src/RentCarServer.Application/RentCarServer.Application.csproj`
  - `RentCarServer/src/RentCarServer.Application/ServiceRegistrar.cs`
  - `RentCarServer/src/RentCarServer.Application/Services/IUserContext.cs`
- Yapılanlar:
  - Application katmanı oluşturuldu.
  - MediatR pipeline behavior'ları eklendi (ValidationBehavior, PermissionBehavior).
  - Servis arayüzleri tanımlandı (IUserContext).
  - ServiceRegistrar ile DI konfigürasyonu yapıldı.

### [2026-03-03] Infrastructure katmanı oluşturuldu
- Commit: dc8b586
- Kapsam: Infrastructure katmanı
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Infrastructure/Context/ApplicationDbContext.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/ExtensionMethods.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/RentCarServer.Infrastructure.csproj`
  - `RentCarServer/src/RentCarServer.Infrastructure/ServiceRegistrar.cs.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/UserContext.cs`
- Yapılanlar:
  - Infrastructure katmanı oluşturuldu.
  - EF Core `ApplicationDbContext` tanımlandı.
  - `UserContext` servisi eklendi.
  - Gerekli NuGet kütüphaneleri yüklendi.

### [2026-03-03] WebAPI katmanı oluşturuldu
- Commit: a361a5b
- Kapsam: WebAPI katmanı
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/oDataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Properties/launchSettings.json`
  - `RentCarServer/src/RentCarServer.WebAPI/RentCarServer.WebAPI.csproj`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.Development.json`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.Production.json`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.json`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260303082910_Initial.cs`
- Yapılanlar:
  - WebAPI projesi oluşturuldu.
  - OData controller eklendi.
  - Program.cs ile uygulama konfigürasyonu yapıldı.
  - İlk migration oluşturuldu (Initial).
- Not: Clean Architecture 4 katmanı (Domain, Application, Infrastructure, WebAPI) tamamlandı.

### [2026-03-03] Angular workspace oluşturuldu (NX)
- Commit: 5e80775
- Kapsam: Frontend — Angular admin uygulaması
- Etkilenen Dosyalar:
  - `RentCarClient/.editorconfig`
  - `RentCarClient/.gitignore`
  - `RentCarClient/.prettierignore`
  - `RentCarClient/.prettierrc`
  - `RentCarClient/apps/admin/src/app.config.ts`
  - `RentCarClient/apps/admin/src/app.routes.ts`
  - `RentCarClient/apps/admin/src/main.ts`
  - `RentCarClient/package.json`
  - `RentCarClient/nx.json`
  - `RentCarClient/tsconfig.base.json`
- Yapılanlar:
  - NX tabanlı Angular workspace oluşturuldu.
  - Admin uygulaması için temel giriş dosyaları ve route altyapısı üretildi.
  - Lint/format, TypeScript ayarları yapıldı.

### [2026-03-03] Admin teması giydirildi
- Commit: 9a1488c
- Kapsam: Frontend — Layout
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.html`
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.ts`
  - `RentCarClient/apps/admin/src/styles.css`
- Yapılanlar:
  - Admin layout (sidebar + dashboard) bileşenleri oluşturuldu.

### [2026-03-03] Sidebar işlevselliği eklendi
- Commit: 3e4b501
- Kapsam: Frontend — Sidebar
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.ts`
- Yapılanlar:
  - Sidebar JS kodları Angular'a uygun hale getirildi.
  - Responsive davranış ve alt menü açma/kapama (toggle) eklendi.

### [2026-03-03] Dashboard sayfası ve navigasyon modeli
- Commit: adc7665
- Kapsam: Frontend — Dashboard & Navigation
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.routes.ts`
  - `RentCarClient/apps/admin/src/navigation.ts`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.html`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.ts`
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.html`
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.ts`
- Yapılanlar:
  - Dashboard sayfası oluşturuldu.
  - Navigasyon modeli tanımlandı.
  - Sidebar düzenlendi.

### [2026-03-03] Breadcrumb bileşeni ve servisi
- Commit: f91fdc1
- Kapsam: Frontend — Navbar / Breadcrumb
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/layouts/breadcrumb/breadcrumb.html`
  - `RentCarClient/apps/admin/src/pages/layouts/breadcrumb/breadcrumb.ts`
  - `RentCarClient/apps/admin/src/services/breadcrumb.ts`
- Yapılanlar:
  - Breadcrumb bileşeni ve servisi oluşturuldu.
  - Dashboard navigasyonu için breadcrumb entegre edildi.

### [2026-03-03] Content kısmı generic hale getirildi
- Commit: 02cbf16
- Kapsam: Frontend — Blank bileşen & Entity modeli
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/components/blank/blank.html`
  - `RentCarClient/apps/admin/src/components/blank/blank.ts`
  - `RentCarClient/apps/admin/src/models/entity.model.ts`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.html`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.ts`
- Yapılanlar:
  - Blank (boş sayfa) bileşeni oluşturuldu.
  - Entity modeli tanımlandı.
  - Content kısmı generic yapıya dönüştürüldü.

### [2026-03-03] HTTP Interceptor eklendi
- Commit: 6e57c72
- Kapsam: Frontend — API iletişimi
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.config.ts`
  - `RentCarClient/apps/admin/src/interceptors/http-interceptor.ts`
- Yapılanlar:
  - API endpoint'ini Interceptor ile yönetmek için HTTP interceptor oluşturuldu.

### [2026-03-04] Login sayfası teması
- Commit: 2020f62
- Kapsam: Frontend — Login sayfası
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.routes.ts`
  - `RentCarClient/apps/admin/src/pages/login/login.html`
  - `RentCarClient/apps/admin/src/pages/login/login.ts`
- Yapılanlar:
  - Login sayfasının HTML/CSS teması giydirildi.

### [2026-03-04] Auth Guard eklendi
- Commit: 9e2f408
- Kapsam: Frontend — Route koruması
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.routes.ts`
  - `RentCarClient/apps/admin/src/guards/auth-guard.ts`
  - `RentCarClient/package.json`
- Yapılanlar:
  - AuthGuard ile route koruması eklendi.
  - `jwt-decode` bağımlılığı yüklendi.

### [2026-03-04] User modeli oluşturuldu (.NET)
- Commit: de3cae4
- Kapsam: Backend — Domain (User)
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/IUserRepository.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/Email.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/FirstName.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/FullName.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/LastName.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/Password.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/UserName.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/UserConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/UserRepository.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260304072150_i_users_table_added.cs`
- Yapılanlar:
  - User aggregate root ve Value Object'ler (Email, FirstName, LastName, FullName, Password, UserName) tanımlandı.
  - IUserRepository arayüzü ve UserRepository implementasyonu oluşturuldu.
  - UserConfiguration ile EF Core mapping yapıldı.
  - Users tablosu migration'ı oluşturuldu.

### [2026-03-04] Create First User metodu
- Commit: c4926f7
- Kapsam: Backend — Seed Data
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Context/ApplicationDbContext.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/ExtensionMethods.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - İlk kullanıcı oluşturma (seed) metodu yazıldı.

### [2026-03-04] Login metodu yazıldı (.NET)
- Commit: 12d66f2
- Kapsam: Backend — Authentication
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Auth/LoginCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/RentCarServer.Application.csproj`
  - `RentCarServer/src/RentCarServer.Application/Services/IJwtProvider.cs`
- Yapılanlar:
  - LoginCommand ve handler yazıldı (CQRS pattern).
  - IJwtProvider arayüzü tanımlandı.

### [2026-03-04] Auth module ve Login endpoint
- Commit: fd8fdc9
- Kapsam: Backend — WebAPI endpoint
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/JwtProvider.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - AuthModule oluşturuldu.
  - Login endpoint'i (Minimal API) tanımlandı.
  - JwtProvider implementasyonu yazıldı.

### [2026-03-04] ExceptionHandler
- Commit: 4e63009
- Kapsam: Backend — Hata yönetimi
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.WebAPI/ExceptionHandler.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Global exception handler eklendi.

### [2026-03-04] JWT yapısı kuruldu
- Commit: c80993d
- Kapsam: Backend — JWT token üretimi
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Behaviors/PermissionBehavior.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Options/JwtOptions.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/JwtProvider.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/UserContext.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/ServiceRegistrar.cs.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.Development.json`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.Production.json`
- Yapılanlar:
  - JWT yapılandırması (JwtOptions) eklendi.
  - JwtProvider ile token üretimi tamamlandı.
  - PermissionBehavior güncellendi.

### [2026-03-04] Authentication kontrolü
- Commit: c9e5f04
- Kapsam: Backend — Authentication middleware
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Infrastructure/Options/JwtSetupOptions.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/ServiceRegistrar.cs.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - JWT setup options eklendi.
  - Authentication middleware konfigürasyonu yapıldı.

### [2026-03-05] Rate Limiting ve Response Compression
- Commit: a1627fc
- Kapsam: Backend — Performans & Güvenlik
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Login endpoint'i için özel rate limit (`login-fixed`) tanımlandı.
  - Response compression eklendi.

### [2026-03-05] Angular'da login işlemi
- Commit: 3b041b4
- Kapsam: Frontend — Login
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/interceptors/http-interceptor.ts`
  - `RentCarClient/apps/admin/src/models/result.model.ts`
  - `RentCarClient/apps/admin/src/pages/login/login.html`
  - `RentCarClient/apps/admin/src/pages/login/login.ts`
- Yapılanlar:
  - Login formu backend'e bağlandı.
  - Result modeli oluşturuldu.
  - HTTP interceptor güncellendi.

### [2026-03-05] Angular'da logout işlemi
- Commit: 39d6f02
- Kapsam: Frontend — Logout
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.html`
  - `RentCarClient/apps/admin/src/pages/layouts/layouts.ts`
  - `RentCarClient/apps/admin/src/pages/login/login.ts`
  - `RentCarClient/apps/admin/src/styles.css`
- Yapılanlar:
  - Logout butonu ve işlevi eklendi.
  - Layout'a logout entegre edildi.

### [2026-03-05] Error service ve error interceptor
- Commit: 5be3e31
- Kapsam: Frontend — Hata yönetimi
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.config.ts`
  - `RentCarClient/apps/admin/src/interceptors/error-interceptor.ts`
  - `RentCarClient/apps/admin/src/services/error.ts`
  - `RentCarClient/apps/admin/src/styles.css`
- Yapılanlar:
  - Error interceptor oluşturuldu.
  - Error service ile global hata yönetimi eklendi.

### [2026-03-05] Form validation hataları
- Commit: 4f5652c
- Kapsam: Frontend — Validation
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/login/login.html`
  - `RentCarClient/apps/admin/src/pages/login/login.ts`
- Yapılanlar:
  - Form yapısında validation hataları yakalanır hale getirildi.

### [2026-03-06] HttpService oluşturuldu
- Commit: 29909d0
- Kapsam: Frontend — HTTP servisi
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.config.ts`
  - `RentCarClient/apps/admin/src/interceptors/error-interceptor.ts`
  - `RentCarClient/apps/admin/src/pages/login/login.html`
  - `RentCarClient/apps/admin/src/pages/login/login.ts`
  - `RentCarClient/apps/admin/src/services/http.ts`
- Yapılanlar:
  - Merkezi HttpService oluşturuldu.
  - Login sayfası HttpService'i kullanacak şekilde güncellendi.

### [2026-03-06] Forgot Password metodu ve Angular tetiklemesi
- Commit: 8f9c72c
- Kapsam: Backend & Frontend — Şifre sıfırlama talebi
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Auth/ForgotPasswordCommand.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
  - `RentCarClient/apps/admin/src/pages/login/login.html`
  - `RentCarClient/apps/admin/src/pages/login/login.ts`
- Yapılanlar:
  - ForgotPasswordCommand ve handler yazıldı.
  - Forgot password endpoint'i AuthModule'e eklendi.
  - Angular'da forgot password tetiklemesi yapıldı.
  - Forgot password için rate limit eklendi.
- Not: User modeline ForgotPasswordId, ForgotPasswordDate, IsForgotPasswordCompleted alanları eklendi.

### [2026-03-06] Mail gönderme altyapısı
- Commit: f0bb93b
- Kapsam: Backend — Mail servisi
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Services/IMailService.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Options/MailSettingOptions.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/MailService.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/ServiceRegistrar.cs.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/RentCarServer.Infrastructure.csproj`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.Development.json`
  - `RentCarServer/src/RentCarServer.WebAPI/appsettings.Production.json`
- Yapılanlar:
  - IMailService arayüzü ve MailService implementasyonu oluşturuldu.
  - MailSettingOptions ile SMTP konfigürasyonu yapılandırıldı.
  - appsettings dosyalarına mail ayarları eklendi.

### [2026-03-06] Şifre sıfırlama maili gönderimi
- Commit: ecdd96b
- Kapsam: Backend & Frontend — Şifre sıfırlama e-postası
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Auth/ForgotPasswordCommand.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/ForgotPasswordDate.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/IsForgotPasswordCompleted.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/UserConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260306090022_i_added_forgot_password_fields_to_users_table.cs`
  - `RentCarClient/apps/admin/src/components/loading/loading.html`
  - `RentCarClient/apps/admin/src/components/loading/loading.ts`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.html`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.ts`
  - `RentCarClient/apps/admin/src/styles.css`
- Yapılanlar:
  - ForgotPasswordCommand handler'a HTML mail gönderimi eklendi.
  - User modeline şifre sıfırlama alanları eklendi ve migration oluşturuldu.
  - Angular'da loading bileşeni oluşturuldu.
  - Reset password sayfası oluşturulmaya başlandı.

### [2026-03-07] Angular şifre sıfırlama sayfası
- Commit: 6588f5a
- Kapsam: Frontend — Şifre sıfırlama sayfası
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.routes.ts`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.html`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.ts`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.html`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.ts`
  - `RentCarServer/src/RentCarServer.Application/Auth/ForgotPasswordCommand.cs`
- Yapılanlar:
  - Şifre sıfırlama sayfası Angular'da oluşturuldu.
  - Login sayfası auth klasörüne taşındı.
  - Route yapısı güncellendi.

### [2026-03-08] Şifre sıfırlama işlemi tamamlandı
- Commit: d190106
- Kapsam: Frontend — Şifre sıfırlama tamamlama
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/components/loading/loading.html`
  - `RentCarClient/apps/admin/src/components/loading/loading.ts`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.html`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.ts`
  - `RentCarClient/apps/admin/src/styles.css`
- Yapılanlar:
  - Şifre sıfırlama akışı (kod doğrulama + yeni şifre belirleme) tamamlandı.
  - Loading bileşeni güncellendi.

### [2026-03-08] Login Token yapısı kuruldu
- Commit: adbfa7b
- Kapsam: Backend — Login Token & Şifre sıfırlama son düzenlemeler
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Auth/CheckForgotPasswordCodeCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Auth/ForgotPasswordCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Auth/LoginCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Auth/ResetPasswordCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Services/IJwtProvider.cs`
  - `RentCarServer/src/RentCarServer.Domain/LoginTokens/LoginToken.cs`
  - `RentCarServer/src/RentCarServer.Domain/LoginTokens/ILoginTokenRepository.cs`
  - `RentCarServer/src/RentCarServer.Domain/LoginTokens/ValueObjects/Token.cs`
  - `RentCarServer/src/RentCarServer.Domain/LoginTokens/ValueObjects/IsActive.cs`
  - `RentCarServer/src/RentCarServer.Domain/LoginTokens/ValueObjects/ExpiresDate.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/ForgotPasswordCode.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/LoginTokenConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/LoginTokenRepository.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/JwtProvider.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260307083522_i_changed_nullable_structure_is_forgot_password_completed_field_on_the_user_model.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260307140214_i_changed_forgotpassword_to_code_on_user_model.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260308074518_i_created_login_token_table.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - LoginToken aggregate root ve Value Object'leri (Token, IsActive, ExpiresDate) oluşturuldu.
  - LoginTokenRepository ve LoginTokenConfiguration eklendi.
  - CheckForgotPasswordCodeCommand ve ResetPasswordCommand oluşturuldu.
  - ForgotPasswordCode Value Object'i eklendi (ForgotPasswordId'den dönüştürüldü).
  - Login işlemi token tablosuyla entegre edildi.
  - Auth endpoint'leri güncellendi (check-forgot-password-code, reset-password).
  - Migration'lar oluşturuldu.
- Not: .NET 10, Clean Architecture, CQRS + MediatR, FluentValidation, EF Core, JWT, SMTP Mail. Frontend: Angular 21 + NX workspace.

### [2026-03-08] Login Token refactoring ve parola görünürlüğü
- Commit: f500b1a
- Kapsam: Frontend — Login UX & Token akışı refactor hazırlığı
- Etkilenen Dosyalar:
  - `PROJE_GUNLUGU.md`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.html`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.ts`
- Yapılanlar:
  - Login sayfasına parola göster/gizle (password visibility toggle) davranışı eklendi.
  - Login component içinde `togglePassword` ve `viewChild` ile input tipi dinamik yönetilecek şekilde güncelleme yapıldı.
  - Login formu şablonu toggle ikonları ile güncellendi.

### [2026-03-09] Cihazlardan çıkış (token doğrulama) akışı
- Commit: 90c22a9
- Kapsam: Backend & Frontend — Aktif token doğrulama ve oturum güvenliği
- Etkilenen Dosyalar:
  - `PROJE_GUNLUGU.md`
  - `RentCarClient/apps/admin/src/app.config.ts`
  - `RentCarClient/apps/admin/src/interceptors/auth-interceptor.ts`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.html`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.html`
  - `RentCarClient/apps/admin/src/pages/auth/reset-password/reset-password.ts`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.html`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.ts`
  - `RentCarClient/apps/admin/src/services/error.ts`
  - `RentCarClient/apps/admin/src/services/http.ts`
  - `RentCarServer/src/RentCarServer.Application/Auth/ResetPasswordCommand.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/ExceptionHandler.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/MiddleWares/CheckTokenMiddleware.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Angular tarafına `auth-interceptor` eklendi ve isteklerde `Authorization: Bearer <token>` header'ı gönderilmeye başlandı.
  - WebAPI tarafında `CheckTokenMiddleware` eklendi; gelen token, login token tablosundaki aktif token kaydıyla doğrulanır hale getirildi.
  - `Program.cs` pipeline sırası güncellendi ve token kontrol middleware'i exception handler sonrasına eklendi.
  - Dashboard, login, reset-password ve servis katmanında token/oturum akışına uyumlu güncellemeler yapıldı.
- Not: Bu commit'te günlük dosyası (`PROJE_GUNLUGU.md`) yanlışlıkla silinmiş görünmektedir; mevcut çalışma ile dosya geri eklendi.
