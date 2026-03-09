import { HttpErrorResponse } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { FlexiToastService } from 'flexi-toast';

@Injectable({
  providedIn: 'root',
})
export class ErrorService {
  readonly #toast = inject(FlexiToastService);
  readonly #router = inject(Router);

  handle(err:HttpErrorResponse){
    console.log(err);
    const status = err.status;
    if (status === 400 ||status === 422 ||status === 403 ||status === 404 ||status === 500) 
      {
      const messages = err.error.message || err.error || 'Bilinmeyen bir hata oluştu.';
      messages.forEach((message: string) => {
        this.#toast.showToast('Hata!', message, 'error');
      });
    }else if(status === 401){
      this.#toast.showToast('Yetkisiz!', 'Giriş yapmanız gerekiyor.', 'error');
      this.#router.navigate(['/login']);
      localStorage.clear();
    }
  }
}