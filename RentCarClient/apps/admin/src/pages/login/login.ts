/* eslint-disable @typescript-eslint/no-non-null-assertion */
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import {
  ChangeDetectionStrategy,
  Component,
  ElementRef,
  inject,
  signal,
  viewChild,
  ViewChild,
  ViewEncapsulation,
} from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Result } from '../../models/result.model';
import { Router } from '@angular/router';
import { FormValidateDirective } from 'form-validate-angular';
import { HttpService } from '../../services/http';
import { FlexiToastService } from 'flexi-toast';

@Component({
  imports: [FormsModule, FormValidateDirective],
  templateUrl: './login.html',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export default class Login {
  readonly #http = inject(HttpService);
  readonly #router = inject(Router);
  readonly #toast = inject(FlexiToastService);

  readonly loading = signal(false);
  readonly email = signal<string>('');
  readonly closeBtn = viewChild<ElementRef<HTMLButtonElement>>('modalCloseBtn');

  login(form: NgForm) {
    if (!form.valid) return;
    this.loading.set(true);
    this.#http.post<string>(
      '/rent/Auth/login',
      form.value,
      (res) => {
        localStorage.setItem('response', res!);
        this.#router.navigateByUrl('/');
        this.loading.set(false);
      },
      () => {
        this.loading.set(false);
      },
    );
  }

  forgotpassword() {
    this.#http.post<string>(
      `/rent/auth/forgot-password/${this.email()}`,
      {},
      (res) => {
        this.#toast.showToast('Başarılı', res, 'info');
        this.closeBtn()!.nativeElement.click();
      }
    );
  }
}
