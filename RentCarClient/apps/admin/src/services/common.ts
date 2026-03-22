
import { Router } from '@angular/router';
import { DecodeModel, initialDecode } from './../models/decode.model';
import { inject, Injectable, signal } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CommonService {
  readonly decode = signal<DecodeModel>({ ...initialDecode });
  readonly #router = inject(Router);

  checkPermission(permission: string): boolean {
    if (this.decode().role === 'sys_admin') return true;

    if (this.decode().permissions.some((i) => i === permission)) return true;

    return false;
  }
  checkPermissionForRoute(permission: string): boolean {
   const res= this.checkPermission(permission);
    if (!res) this.#router.navigate(['/unauthorize']);
    
    return res;
  }
}
