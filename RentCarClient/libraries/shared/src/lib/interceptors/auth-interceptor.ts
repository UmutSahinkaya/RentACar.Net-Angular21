/* eslint-disable @typescript-eslint/no-unused-vars */
import { HttpHeaders, HttpInterceptorFn } from '@angular/common/http';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const token=localStorage.getItem('response');
  // const clone=req.clone({
  //   headers:new HttpHeaders({
  //     Authorization: `Bearer ${token}`
  //   })
  // })
 
  const clone=req.clone({
    setHeaders:{
      Authorization: token ? `Bearer ${token}` : ''
    }
  });
  
  return next(clone);
};
