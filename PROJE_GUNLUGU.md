# Proje Günlüğü

### [2026-03-26] Extra (Ek Hizmetler) Modülü ve CRUD
- Commit: f5fd92c, 2e789d8
- Kapsam: Backend & Frontend — Extra modeli, CRUD, OData, migration, Angular sayfaları
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/models/extra.model.ts`
  - `RentCarClient/apps/admin/src/pages/extra/create/create.html`
  - `RentCarClient/apps/admin/src/pages/extra/create/create.ts`
  - `RentCarClient/apps/admin/src/pages/extra/detail/detail.html`
  - `RentCarClient/apps/admin/src/pages/extra/detail/detail.ts`
  - `RentCarClient/apps/admin/src/pages/extra/extra.html`
  - `RentCarClient/apps/admin/src/pages/extra/extra.ts`
  - `RentCarClient/apps/admin/src/pages/extra/router.ts`
  - `RentCarServer/src/RentCarServer.Domain/Extras/Extra.cs`
  - `RentCarServer/src/RentCarServer.Domain/Extras/IExtraRepository.cs`
  - `RentCarServer/src/RentCarServer.Application/Extras/ExtraCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Extras/ExtraDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Extras/ExtraDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Extras/ExtraGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Extras/ExtraGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Extras/ExtraUpdateCommand.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/ExtraConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/ExtraRepository.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260326071542_i_added_extras_table.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/ExtraModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/MainODataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Extra (ek hizmetler) aggregate ve value object'leri oluşturuldu.
  - CRUD komutları, sorguları, DTO ve repository ile tam uçtan uca akış sağlandı.
  - EF Core migration ve configuration ile Extras tablosu oluşturuldu.
  - OData ve Minimal API endpointleri eklendi.
  - Angular tarafında Extra için model, router ve CRUD sayfaları geliştirildi.

### [2026-03-25] Protection Package Modülü ve CRUD/OData
- Commit: b22d1cb, d86e284, 686b1af, 3ecc7f5
- Kapsam: Backend & Frontend — Protection Package aggregate, CRUD, OData, Angular sayfaları
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/models/protection-package.model.ts`
  - `RentCarClient/apps/admin/src/pages/protection-packages/create/create.html`
  - `RentCarClient/apps/admin/src/pages/protection-packages/create/create.ts`
  - `RentCarClient/apps/admin/src/pages/protection-packages/detail/detail.html`
  - `RentCarClient/apps/admin/src/pages/protection-packages/detail/detail.ts`
  - `RentCarClient/apps/admin/src/pages/protection-packages/protection-packages.html`
  - `RentCarClient/apps/admin/src/pages/protection-packages/protection-packages.ts`
  - `RentCarClient/apps/admin/src/pages/protection-packages/router.ts`
  - `RentCarServer/src/RentCarServer.Domain/ProtectionPackages/ProtectionPackage.cs`
  - `RentCarServer/src/RentCarServer.Domain/ProtectionPackages/ValueObjects/IsRecommended.cs`
  - `RentCarServer/src/RentCarServer.Domain/ProtectionPackages/ValueObjects/Price.cs`
  - `RentCarServer/src/RentCarServer.Domain/ProtectionPackages/ValueObjects/ProtectionCoverage.cs`
  - `RentCarServer/src/RentCarServer.Domain/ProtectionPackages/IProtectionPackageRepository.cs`
  - `RentCarServer/src/RentCarServer.Application/ProtectionPackages/ProtectionPackageCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/ProtectionPackages/ProtectionPackageDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/ProtectionPackages/ProtectionPackageDto.cs`
  - `RentCarServer/src/RentCarServer.Application/ProtectionPackages/ProtectionPackageGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/ProtectionPackages/ProtectionPackageGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/ProtectionPackages/ProtectionPackageUpdateCommand.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/ProtectionPackageConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/ProtectionPackageRepository.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260325073009_i_added_protection_package_table.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/ProtectionPackageModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/MainODataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Protection Package aggregate ve value object'leri oluşturuldu.
  - CRUD komutları, sorguları, DTO ve repository ile tam uçtan uca akış sağlandı.
  - EF Core migration ve configuration ile ProtectionPackages tablosu oluşturuldu.
  - OData ve Minimal API endpointleri eklendi.
  - Angular tarafında Protection Package için model, router ve CRUD sayfaları geliştirildi.

### [2026-03-24] Category Modülü ve CRUD/OData
- Commit: 7662c46, f796c45, 967855a, ba51ef5
- Kapsam: Backend & Frontend — Category aggregate, CRUD, OData, Angular sayfaları
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/models/category.model.ts`
  - `RentCarClient/apps/admin/src/pages/categories/categories.html`
  - `RentCarClient/apps/admin/src/pages/categories/categories.ts`
  - `RentCarClient/apps/admin/src/pages/categories/create/create.html`
  - `RentCarClient/apps/admin/src/pages/categories/create/create.ts`
  - `RentCarClient/apps/admin/src/pages/categories/detail/detail.html`
  - `RentCarClient/apps/admin/src/pages/categories/detail/detail.ts`
  - `RentCarClient/apps/admin/src/pages/categories/router.ts`
  - `RentCarServer/src/RentCarServer.Domain/Categories/Category.cs`
  - `RentCarServer/src/RentCarServer.Domain/Categories/ICategoryRepository.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryUpdateCommand.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/CategoryConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/CategoryRepository.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260324071025_i_created_category_table.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/CategoryModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/MainODataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Category aggregate ve value object'leri oluşturuldu.
  - CRUD komutları, sorguları, DTO ve repository ile tam uçtan uca akış sağlandı.
  - EF Core migration ve configuration ile Categories tablosu oluşturuldu.
  - OData ve Minimal API endpointleri eklendi.
  - Angular tarafında Category için model, router ve CRUD sayfaları geliştirildi.

### [2026-03-23] User Yönetimi ve CRUD/OData
- Commit: fa3f25c, 23ab1c5, 51bc78d, 7620cb0, e66001b, 2934776, 018da9b, bea9556, 7cf2a7e
- Kapsam: Backend & Frontend — User aggregate, CRUD, OData, Angular sayfaları
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/models/user.model.ts`
  - `RentCarClient/apps/admin/src/pages/users/create/create.html`
  - `RentCarClient/apps/admin/src/pages/users/create/create.ts`
  - `RentCarClient/apps/admin/src/pages/users/detail/detail.html`
  - `RentCarClient/apps/admin/src/pages/users/detail/detail.ts`
  - `RentCarClient/apps/admin/src/pages/users/users.html`
  - `RentCarClient/apps/admin/src/pages/users/users.ts`
  - `RentCarClient/apps/admin/src/pages/users/router.ts`
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/IUserRepository.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserUpdateCommand.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/UserModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/MainODataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - User aggregate ve value object'leri oluşturuldu.
  - CRUD komutları, sorguları, DTO ve repository ile tam uçtan uca akış sağlandı.
  - EF Core migration ve configuration ile Users tablosu güncellendi.
  - OData ve Minimal API endpointleri eklendi.
  - Angular tarafında User için model, router ve CRUD sayfaları geliştirildi.

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

### [2026-03-29] Merge: kurtarilan-commitler branch'i birleştirildi
- Commit: be5b60b
- Kapsam: Merge — kurtarilan-commitler
- Etkilenen Dosyalar (örnek):
  - RentCarClient/apps/admin/src/pages/vehicles/detail/detail.ts
  - RentCarServer/src/RentCarServer.Domain/Reservations/Reservation.cs
  - RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260329090011_i_added_reservation_table.Designer.cs
  - RentCarServer/src/RentCarServer.Infrastructure/Migrations/ApplicationDbContextModelSnapshot.cs
  - ... (toplam 23 dosya)
- Yapılanlar:
  - kurtarilan-commitler branch'inden ana dala (master) çoklu dosya ve migration içeren büyük bir değişiklik birleştirildi.
  - Reservation aggregate, migration ve ilgili repository dosyaları eklendi.

### [2026-03-29] Merge: master ile remote master birleştirildi
- Commit: 841572e
- Kapsam: Merge — remote/master
- Etkilenen Dosyalar:
  - (Çeşitli dosyalar, detay git logunda)
- Yapılanlar:
  - Remote repository'deki master branch ile yerel master branch birleştirildi.

### [2026-03-24] Kategori (Category) özelliği eklendi
- Commit: ba51ef5
- Kapsam: Backend — Kategori CRUD & OData
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Categories/CategoryGetAllQuery.cs`
  - ...
- Yapılanlar:
  - Kategori için create, delete, get, getAll komutları ve DTO'lar eklendi.
  - OData ve API endpointleriyle tam CRUD desteği sağlandı.

### [2026-03-24] User Detail sayfası ve model güncellemeleri (Angular)
- Commit: fa3f25c
- Kapsam: Frontend — User detay
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/users/detail/detail.html`
  - `RentCarClient/apps/admin/src/pages/users/detail/detail.ts`
  - `RentCarClient/apps/admin/src/pages/users/router.ts`
  - `RentCarServer/src/RentCarServer.Application/Users/UserDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserUpdateCommand.cs`
- Yapılanlar:
  - Kullanıcı detay sayfası ve detay bileşenleri oluşturuldu.
  - User modeline yeni alanlar eklendi ve güncellendi.

### [2026-03-24] User listesi role göre filtrelendi
- Commit: e92e1a7
- Kapsam: Backend — User listeleme
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Services/IClaimContext.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/ClaimContext.cs`
- Yapılanlar:
  - Kullanıcı listesi, admin olmayan roller için şube bazında filtrelendi.

### [2026-03-24] User Create/Update sayfaları ve telefon formatı (Angular)
- Commit: 23ab1c5
- Kapsam: Frontend — User CRUD
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/users/create/create.html`
  - `RentCarClient/apps/admin/src/pages/users/create/create.ts`
  - `RentCarClient/apps/admin/src/pages/users/detail/detail.html`
  - `RentCarClient/apps/admin/src/pages/users/detail/detail.ts`
  - `RentCarClient/apps/admin/src/pages/users/router.ts`
  - `RentCarClient/apps/admin/src/pages/users/users.ts`
  - ...
- Yapılanlar:
  - Kullanıcı oluşturma ve güncelleme sayfaları eklendi.
  - Telefon numarası formatlama ve validasyonları geliştirildi.

### [2026-03-23] Angular'da Users sayfası ve backend CRUD
- Commit: 51bc78d
- Kapsam: Fullstack — User yönetimi
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/users/users.html`
  - `RentCarClient/apps/admin/src/pages/users/users.ts`
  - `RentCarServer/src/RentCarServer.Application/Users/UserCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetAllQuery.cs`
  - ...
- Yapılanlar:
  - Kullanıcı yönetimi için Angular'da sayfa ve backend'de CRUD komutları eklendi.
  - Navigation ve routing güncellendi.

### [2026-03-23] .NET User CRUD endpointleri ve OData desteği
- Commit: 7620cb0
- Kapsam: Backend — User API
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/MainODataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/RoleModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/UserModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - User için CRUD endpointleri ve OData desteği eklendi.
  - UserDto OData modeline entegre edildi.

### [2026-03-23] UserGetAllQuery ve UserGetQuery handlerları
- Commit: e66001b
- Kapsam: Backend — User sorguları
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetQuery.cs`
- Yapılanlar:
  - Kullanıcıları listeleyen ve tekil getiren query/handler yapıları eklendi.

### [2026-03-23] UserGetQuery ve UserDto ile audit refactor
- Commit: 2934776
- Kapsam: Backend — User query & audit
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Users/UserDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/IUserRepository.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/UserRepository.cs`
- Yapılanlar:
  - User sorgularında audit bilgileri ve DTO dönüşümleri iyileştirildi.

### [2026-03-23] UserDeleteCommand ve UserUpdateCommand
- Commit: 018da9b
- Kapsam: Backend — User silme/güncelleme
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Users/UserDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserUpdateCommand.cs`
- Yapılanlar:
  - Kullanıcı silme ve güncelleme komutları ile ilgili handlerlar eklendi.

### [2026-03-23] UserUpdateCommand handler ve validasyon
- Commit: bea9556
- Kapsam: Backend — User güncelleme
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Users/UserUpdateCommand.cs`
- Yapılanlar:
  - Kullanıcı güncelleme için handler ve validasyon akışı eklendi.

### [2026-03-23] UserCreate methodunu yeniden yazdım
- Commit: 7cf2a7e
- Kapsam: Backend — User/Branch context
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Behaviors/PermissionBehavior.cs`
  - `RentCarServer/src/RentCarServer.Application/Services/IClaimContext.cs`
  - `RentCarServer/src/RentCarServer.Application/Users/UserCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/ClaimContext.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/JwtProvider.cs`
- Yapılanlar:
  - UserCreate işlemi için context ve claim yönetimi yeniden düzenlendi.

### [2026-03-22] Angular'da JWT decode ve permission kontrolü
- Commit: 9e4f45d
- Kapsam: Fullstack — Yetkilendirme
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/guards/auth-guard.ts`
  - `RentCarClient/apps/admin/src/models/decode.model.ts`
  - `RentCarClient/apps/admin/src/pages/unauthorize/unauthorize.html`
  - `RentCarClient/apps/admin/src/pages/unauthorize/unauthorize.ts`
  - `RentCarServer/src/RentCarServer.Application/Roles/RoleUpdatePermissionCommand.cs`
  - ...
- Yapılanlar:
  - JWT decode edilen bilgilerle kullanıcıya özel yetki kontrolü sağlandı.
  - Frontend ve backend tarafında permission sistemi entegre edildi.

### [2026-03-22] Login'de user permissionlar claims'e eklendi
- Commit: d109e6b
- Kapsam: Backend — JWT claims
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Infrastructure/Services/JwtProvider.cs`
- Yapılanlar:
  - Kullanıcıya ait rol ve permission bilgileri JWT claims'e eklendi.

### [2026-03-19] User tablosu refactor edildi (BranchId, RoleId)
- Commit: 64aee42
- Kapsam: Backend — User tablo güncelleme
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260319080554_i_added_branchId_roleId_to_usertable.cs`
  - ...
- Yapılanlar:
  - User tablosuna BranchId ve RoleId alanları eklendi, migration güncellendi.

### [2026-03-19] String alanlar nvarchar'a çevrildi
- Commit: 9e08ae1
- Kapsam: Backend — Unicode desteği
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Infrastructure/Context/ApplicationDbContext.cs`
  - ...
- Yapılanlar:
  - String alanlar nchar yerine nvarchar(MAX) olarak güncellendi.

### [2026-03-19] Branch tablosuna Contact alanı eklendi
- Commit: c813d38
- Kapsam: Backend & Frontend — Branch iletişim
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/models/branch.model.ts`
  - `RentCarServer/src/RentCarServer.Domain/Branches/Branch.cs`
  - ...
- Yapılanlar:
  - Branch tablosuna Contact (iletişim) alanı eklendi, migration ve model güncellendi.

### [2026-03-19] Permission Attribute silinince Role'dan da silinsin
- Commit: 2a8da81
- Kapsam: Backend — Permission temizlik
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Services/PermissionCleanerService.cs`
  - ...
- Yapılanlar:
  - Permission attribute silinince, ilgili rollerden de otomatik olarak kaldırılması sağlandı.

### [2026-03-18] Angular'da Role için permission atama
- Commit: 199b397
- Kapsam: Fullstack — Role permission yönetimi
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/pages/roles/permissions/permissions.html`
  - `RentCarClient/apps/admin/src/pages/roles/permissions/permissions.ts`
  - ...
- Yapılanlar:
  - Role permission atama ve yönetim ekranı eklendi.
  - Backend ile entegre permission güncelleme akışı sağlandı.

### [2026-03-10] Audit için Generic Extensions yazıldı
- Commit: fd0dca7
- Kapsam: Backend - Audit mapping refactor
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/ExtensionMethods.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/oDataController.cs`
- Yapılanlar:
  - Audit bilgilerini (`CreatedDate`, `CreatedBy`, `UpdatedDate`, `UpdatedBy`) tekrar eden kod yazmadan DTO'lara taşıyan generic extension metotları eklendi.
  - Branch listeleme/sorgulama tarafındaki manuel mapleme kodları kaldırılarak extension tabanlı tek bir dönüşüm standardına geçildi.
  - OData controller çıktılarında audit alanlarının tutarlı dönmesi için projection akışı güncellendi.

### [2026-03-10] Branch GetAll MapTo ve endpoint testleri tamamlandı
- Commit: 9e2b0bd
- Kapsam: Backend - Branch query/refactor
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchGetAllQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchUpdateCommand.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/oDataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/BranchModule.cs`
- Yapılanlar:
  - `BranchGetAllQuery` içinde listeleme dönüşümleri `MapTo` yaklaşımına taşınarak handler içindeki karmaşıklık azaltıldı.
  - `BranchDto` kullanımına göre Get/GetAll/Delete/Update komut-sorgu tarafındaki dönüşüm noktaları hizalandı.
  - Branch endpointlerinde istek-yanıt akışları tekrar test edilerek DTO şemasının API ile uyumluluğu doğrulandı.

### [2026-03-10] Branch endpoint testleri ve DTO iyileştirmeleri
- Commit: 5cbb44f
- Kapsam: Backend - Branch API iyileştirme
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchDto.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchGetQuery.cs`
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/Entity.cs`
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/EntityDto.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/oDataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/BranchModule.cs`
- Yapılanlar:
  - Branch sorgularında doğrudan entity döndürme yaklaşımı bırakılıp `BranchDto` tabanlı response modeline geçildi.
  - `Entity` ve `EntityDto` üzerinde yapılan düzenlemelerle ortak alanlar (audit/kullanıcı bilgileri) endpoint cevaplarında standardize edildi.
  - OData ve modül endpointlerinin aynı DTO sözleşmesini kullanması sağlanarak istemci tarafı tüketimi sadeleştirildi.

### [2026-03-10] Branch GetAll için OData endpoint düzeni
- Commit: e55f32d
- Kapsam: Backend - OData / Branch endpoint
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.WebAPI/Controllers/oDataController.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/BranchModule.cs`
- Yapılanlar:
  - `oDataController` içinde Branch GetAll için filtreleme/sıralama/genişletme destekli OData endpoint akışı oluşturuldu.
  - Branch route etiketleri ve endpoint adlandırmaları OData tarafıyla uyumlu hale getirildi.
  - BranchModule ve OData controller arasında çakışabilecek route kullanım desenleri düzenlendi.

### [2026-03-10] BranchModule ile CRUD endpointleri eklendi
- Commit: 3f36e39
- Kapsam: Backend - Branch REST API
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/BranchModule.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Branch varlığı için Create, Update, Delete ve Get operasyonlarını kapsayan `BranchModule` Minimal API uçları tanımlandı.
  - Endpointlerin MediatR command/query akışına bağlanması yapıldı ve request binding yapıları netleştirildi.
  - `Program.cs` üzerinde module kaydı/pipeline entegrasyonu tamamlanarak Branch endpointleri uygulama başlangıcında aktif hale getirildi.

### [2026-03-10] Branch GetAll query response standardizasyonu
- Commit: c20b5c3
- Kapsam: Backend - Query response modeli
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchGetAllQueryResponse.cs`
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/EntityDto.cs`
- Yapılanlar:
  - Branch listeleme senaryoları için ayrı bir `BranchGetAllQueryResponse` modeli eklenerek endpoint cevabı tip güvenli hale getirildi.
  - `EntityDto` içinde ortak alanların standardizasyonu yapılarak farklı sorgularda aynı temel response sözleşmesi kullanılmaya başlandı.
  - Query tarafındaki dönüşümlerde response modeli ile DTO yapısı arasında uyum sağlandı.

### [2026-03-09] Entity sınıfına kullanıcı ad-soyad alanları eklendi
- Commit: 97ff85d
- Kapsam: Backend - Domain abstraction güncellemesi
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/Entity.cs`
  - `RentCarServer/src/RentCarServer.Domain/RentCarServer.Domain.csproj`
- Yapılanlar:
  - `Entity` base sınıfı, kayıtları oluşturan/güncelleyen kullanıcının ad-soyad bilgisini taşıyacak şekilde genişletildi.
  - Audit ile ilişkili kullanıcı bilgileri domain seviyesinde merkezileştirildiği için alt entity'lerde tekrar tanımlama ihtiyacı azaltıldı.
  - Domain proje ayarları ve derleme referansları yeni alanlarla uyumlu olacak şekilde güncellendi.

### [2026-03-09] Branch delete/get command-query eklendi
- Commit: 119a9f8
- Kapsam: Backend - Branch CQRS
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchDeleteCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchGetQuery.cs`
- Yapılanlar:
  - Branch silme işlemi için `BranchDeleteCommand` ve ilgili handler akışı eklendi.
  - Tekil branch detayını döndüren `BranchGetQuery` ile sorgulama hattı oluşturuldu.
  - Her iki akışta da CQRS ayrımı korunarak command ve query sorumlulukları netleştirildi.

### [2026-03-09] Branch update metodu eklendi
- Commit: 5d66eb0
- Kapsam: Backend - Branch güncelleme
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchUpdateCommand.cs`
- Yapılanlar:
  - `BranchUpdateCommand` ile branch güncelleme isteğinin command modeli tanımlandı.
  - Güncelleme handler akışında kayıt bulunurluğu, alan güncelleme ve repository persist adımları tamamlandı.
  - Update isteğine yönelik validasyon kuralları ile hatalı payload'ların erken aşamada yakalanması sağlandı.

### [2026-03-09] Branch create metodu ve namespace düzeni
- Commit: 22cd28f
- Kapsam: Backend - Branch oluşturma
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Branches/BranchCreateCommand.cs`
  - `RentCarServer/src/RentCarServer.Domain/Abstractions/Entity.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branches/Branch.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branches/IBranchRepository.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branches/ValueObjects/Address.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branches/ValueObjects/Name.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/BranchConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Context/ApplicationDbContext.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/BranchRepository.cs`
- Yapılanlar:
  - Yeni branch kaydı oluşturmak için `BranchCreateCommand` ve handler yapısı eklendi.
  - Yazım/tutarlılık için `Branchs` namespace'i `Branches` olarak tüm ilgili katmanlarda standardize edildi.
  - EF Core configuration, DbContext tanımı ve repository implementasyonları yeni namespace/model yapısına göre revize edildi.
  - Create akışının MediatR üzerinden çalışması için dependency ve bağlama noktaları güncellendi.

### [2026-03-09] Branch modeli ve veri tabanı şeması oluşturuldu
- Commit: 964a807
- Kapsam: Backend - Domain (Branch) ve migration
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Branchs/Branch.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branchs/IBranchRepository.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branchs/ValueObjects/Address.cs`
  - `RentCarServer/src/RentCarServer.Domain/Branchs/ValueObjects/Name.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/BranchConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Context/ApplicationDbContext.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260309144358_i_created_brach_table.Designer.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260309144358_i_created_brach_table.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/ApplicationDbContextModelSnapshot.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Repositories/BranchRepository.cs`
- Yapılanlar:
  - `Branch` entity'si ile birlikte `Name` ve `Address` value object'leri domain katmanında tanımlandı.
  - Branch verisine erişim için repository arayüzü ve infrastructure implementasyonu oluşturuldu.
  - EF Core tarafında entity configuration ve DbContext entegrasyonu yapıldı.
  - Veritabanına Branch tablosunu taşıyan migration ve snapshot güncellemeleri üretildi.

### [2026-03-09] Error interceptor refactoring yapıldı (Angular)
- Commit: f43f512
- Kapsam: Frontend - HTTP hata yönetimi
- Etkilenen Dosyalar:
  - `RentCarClient/apps/admin/src/app.config.ts`
  - `RentCarClient/apps/admin/src/interceptors/error-interceptor.ts`
  - `RentCarClient/apps/admin/src/pages/dashboard/dashboard.ts`
  - `RentCarClient/apps/admin/src/services/error.ts`
  - `RentCarClient/apps/admin/src/services/http.ts`
- Yapılanlar:
  - `error-interceptor` içinde API hatalarını merkezi biçimde yakalayan ve normalize eden akış yeniden düzenlendi.
  - `HttpContext` tabanlı istek senaryolarında hata yönetimi davranışları (`skip/handle`) servis katmanıyla uyumlu hale getirildi.
  - `error` ve `http` servisleri güncellenerek dashboard çağrılarındaki hata geri bildirimi daha öngörülebilir hale getirildi.

### [2026-03-09] Angular login akışı 2FA'ya göre güncellendi
- Commit: 402094e
- Kapsam: Frontend & Backend - 2FA login entegrasyonu
- Etkilenen Dosyalar:
  - `PROJE_GUNLUGU.md`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.html`
  - `RentCarClient/apps/admin/src/pages/auth/login/login.ts`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Login formu, ilk kimlik doğrulama sonrası 2FA adımına geçişi destekleyecek şekilde UI ve durum yönetimi açısından revize edildi.
  - Login component içinde 2FA gerekli/başarılı/hatalı senaryolar için kullanıcı akışları ayrıştırıldı.
  - İstemci tarafı istekleri 2FA endpoint davranışıyla uyumlu hale getirildi.
  - WebAPI `Program.cs` üzerinde ilgili middleware/endpoint akışının 2FA sürecini desteklemesi için gerekli düzenlemeler yapıldı.

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

### [2026-03-09] Birden fazla giriş ve token pasifleme servisi
- Commit: 11b9df9
- Kapsam: Backend - Login token yaşam döngüsü
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Infrastructure/Context/ApplicationDbContext.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/CheckLoginTokenBackgroundService.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Program.cs`
- Yapılanlar:
  - Aynı kullanıcı için birden fazla aktif giriş senaryosuna uyumlu token yönetimi güncellendi.
  - Süresi dolan token kayıtlarını pasife çekmek için `CheckLoginTokenBackgroundService` eklendi.
  - Background service uygulama başlangıcında çalışacak şekilde `Program.cs` üzerinden kaydedildi.

### [2026-03-09] User modeline 2FA alanları eklendi
- Commit: 032d124
- Kapsam: Backend - Domain (User) ve veri tabanı şeması
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/TFACode.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/TFAConfirmCode.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/TFAExpiresDate.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/TFAIsCompleted.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/ValueObjects/TFAStatus.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Configurations/UserConfiguration.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260309065733_i_added_Tfa_fields_to_user_table.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/20260309065733_i_added_Tfa_fields_to_user_table.Designer.cs`
  - `RentCarServer/src/RentCarServer.Infrastructure/Migrations/ApplicationDbContextModelSnapshot.cs`
- Yapılanlar:
  - User aggregate içine 2FA durumunu tutan alanlar eklendi.
  - 2FA kodu, doğrulama kodu, bitiş zamanı ve tamamlanma durumu için Value Object'ler oluşturuldu.
  - EF Core mapping ve migration dosyaları ile 2FA alanları veritabanına taşındı.

### [2026-03-09] Login akisi 2FA ile güncellendi
- Commit: 6142b35
- Kapsam: Backend - Authentication
- Etkilenen Dosyalar:
  - `RentCarServer/src/RentCarServer.Application/Auth/LoginCommand.cs`
  - `RentCarServer/src/RentCarServer.Application/Auth/LoginWithTFACommand.cs`
  - `RentCarServer/src/RentCarServer.Domain/Users/User.cs`
  - `RentCarServer/src/RentCarServer.WebAPI/Modules/AuthModule.cs`
- Yapılanlar:
  - Mevcut login akisi 2FA gereksinimini dikkate alacak sekilde revize edildi.
  - `LoginWithTFACommand` ile ikinci adim dogrulama komutu eklendi.
  - Auth modulu, 2FA tabanli login akisini destekleyecek endpoint/akislara gore guncellendi.
