/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable @typescript-eslint/no-non-null-assertion */
import { inject } from '@angular/core';
import { CanActivateChildFn, Router } from '@angular/router';
import { jwtDecode } from 'jwt-decode';
import { CommonService } from '../services/common';

export const authGuard: CanActivateChildFn = (childRoute, state) => {
  const token = localStorage.getItem('response');
  const router = inject(Router);
  const commonService=inject(CommonService);
  if (!token) {
    router.navigateByUrl('/login');
    return false;
  }
  try {
    const decode: any = jwtDecode(token);

    commonService.decode().id =decode['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'] ?? '';
    commonService.decode().fullName = decode['fullName'] ?? '';
    commonService.decode().fullNameWithEmail = decode['fullNameWithEmail'] ?? '';
    commonService.decode().email = decode['email'];
    commonService.decode().role = decode['role'] ?? '';
    commonService.decode().permissions = JSON.parse(decode['permissions']);
    commonService.decode().branch = decode['branch'] ?? '';

    console.log(commonService.decode());

    const now = new Date().getTime() / 1000;
    const exp = decode.exp ?? 0;

    if (exp! <= now) {
      router.navigateByUrl('/login');
      return false;
    }
    return true;
  } catch (error) {
    router.navigateByUrl('/login');
    return false;
  }
};
