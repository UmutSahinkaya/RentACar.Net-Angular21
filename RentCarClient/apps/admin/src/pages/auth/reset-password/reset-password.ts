/* eslint-disable @typescript-eslint/no-unused-expressions */
import { NgClass } from '@angular/common';
import { ChangeDetectionStrategy, Component, computed, ElementRef, inject, signal, viewChild, ViewEncapsulation } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpService } from 'apps/admin/src/services/http';
import { FlexiToastService } from 'flexi-toast';

@Component({
  imports: [FormsModule, NgClass],
  templateUrl: './reset-password.html',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export default class ResetPassword {
  readonly id = signal<string>('');
  readonly loading = signal<boolean>(false);
  readonly password = signal<string>('');
  readonly confirmPassword = signal<string>('');
  readonly passwordRequirements = computed(() => {
    const pwd = this.password();
    return {
      minLength: pwd.length >= 8,
      hasUppercase: /[A-Z]/.test(pwd),
      hasLowercase: /[a-z]/.test(pwd),
      hasNumber: /[0-9]/.test(pwd),
      hasSpecialChar: /[!@#$%^&*(),.?":{}|<>]/.test(pwd),
    };
  });
  readonly passwordStrength = computed(() => {
    const requirements = this.passwordRequirements();
    const validCount = Object.values(requirements).filter(Boolean).length;
    if (validCount === 0) return { level: 0, text: '', class: '' };
    if (validCount <= 2)
      return { level: validCount, text: 'Zayıf', class: 'weak' };
    if (validCount <= 3)
      return { level: validCount, text: 'Orta', class: 'medium' };
    if (validCount <= 4)
      return { level: validCount, text: 'İyi', class: 'medium' };
    return { level: validCount, text: 'Güçlü', class: 'strong' };
  });
  readonly isPasswordValid = computed(() => {
    const requirements = this.passwordRequirements();
    return Object.values(requirements).every(Boolean);
  });
  readonly passwordMatch = computed(() => {
    const pwd = this.password();
    const confirmPwd = this.confirmPassword();
    return pwd && confirmPwd && pwd === confirmPwd;
  });
  readonly isFormValid = computed(() => {
    return this.isPasswordValid() && this.passwordMatch();
  });
  readonly strengthProgress = computed(() => {
    const strength = this.passwordStrength();
    return (strength.level / 4) * 100; // 4 gereksinim var, her biri %25 katkıda bulunur
  });

  readonly newPasswordEl= viewChild<ElementRef<HTMLInputElement>>('newPasswordEl');
  readonly confirmPasswordEl= viewChild<ElementRef<HTMLInputElement>>('confirmPasswordEl');

  //service Injectişlemi burada başlar
  readonly #activated = inject(ActivatedRoute);
  readonly #toast = inject(FlexiToastService);
  readonly #http=inject(HttpService);
  readonly #router=inject(Router);
  //service Injectişlemi burada biter
  constructor() {
    this.#activated.params.subscribe((res) => this.id.set(res['id'])); //queryparam daki id'yi alır
  }

  toggleNewPassword() {
    this.newPasswordEl()?.nativeElement.type === 'password' 
    ? this.newPasswordEl()?.nativeElement.setAttribute('type', 'text')
    : this.newPasswordEl()?.nativeElement.setAttribute('type', 'password');
  }

  toggleConfirmPassword() {
    this.confirmPasswordEl()?.nativeElement.type === 'password' 
    ? this.confirmPasswordEl()?.nativeElement.setAttribute('type', 'text')
    : this.confirmPasswordEl()?.nativeElement.setAttribute('type', 'password');
  }

  onSubmit() {
    if (this.isFormValid()) {
     const data={
       forgotPasswordId:this.id(),
        newPassword:this.password(),
     }
     this.loading.set(true);
     this.#http.post<string>('/rent/auth/reset-password',data,(res)=>{
      this.#toast.showToast('Başarılı',res,'success');
      this.#router.navigateByUrl('/login');
      this.loading.set(false);
     },()=>this.loading.set(false));
    
    } else {
      console.log(
        'Form geçerli değil. Lütfen tüm gereksinimleri karşılayın ve şifrelerin eşleştiğinden emin olun.',
      );
      this.#toast.showToast(
        'Hata',
        'Form geçerli değil. Lütfen tüm gereksinimleri karşılayın ve şifrelerin eşleştiğinden emin olun.',
        'error',
      );
    }
  }
}
