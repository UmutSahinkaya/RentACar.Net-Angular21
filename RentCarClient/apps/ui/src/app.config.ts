import { httpInterceptor } from '@shared/lib/interceptors/http-interceptor';
import { authInterceptor } from '@shared/lib/interceptors/auth-interceptor';
import { errorInterceptor } from '@shared/lib/interceptors/error-interceptor';
import {
  ApplicationConfig,
  provideBrowserGlobalErrorListeners,
} from '@angular/core';
import { provideRouter } from '@angular/router';
import { appRoutes } from './app.routes';
import { provideHttpClient, withInterceptors } from '@angular/common/http';

export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideRouter(appRoutes),
    provideHttpClient(withInterceptors([authInterceptor,errorInterceptor,httpInterceptor])),
  ],
};
