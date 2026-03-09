using GenericRepository;
using Microsoft.EntityFrameworkCore;
using RentCarServer.Domain.LoginTokens;

namespace RentCarServer.WebAPI;

public class CheckLoginTokenBackgroundService(IServiceScopeFactory serviceScopeFactory) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var scoped = serviceScopeFactory.CreateScope();
        var srv = scoped.ServiceProvider;
        var loginTokenRepository = srv.GetRequiredService<ILoginTokenRepository>();
        var unitOfWork = srv.GetRequiredService<IUnitOfWork>();
        var now = DateTimeOffset.Now;
        var activeList = await loginTokenRepository.Where(x => x.IsActive.Value == true && x.ExpiresDate.Value < now).ToListAsync(stoppingToken);
        foreach (var item in activeList)
        {
            item.SetIsActive(new(false));
        }
        if (activeList.Any())
        {
            loginTokenRepository.UpdateRange(activeList);
            _ = await unitOfWork.SaveChangesAsync(stoppingToken);
        }
        await Task.Delay(TimeSpan.FromDays(1), stoppingToken);

        // Burada neler yaptık?
        // 1. Veritabanında aktif olan ve süresi geçmiş olan login token' kayıtlarını çektik.
        // 2. Bu kayıtların IsActive değerini false olarak güncelledik.
        // 3. Değişiklikleri veritabanına kaydettik.
        // 4. Bu işlemi her gün tekrarlamak için 1 gün bekledik.

    }
}
