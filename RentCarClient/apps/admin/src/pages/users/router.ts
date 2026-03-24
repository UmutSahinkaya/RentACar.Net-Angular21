import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';
import { inject } from '@angular/core';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./users'),
    canActivate:[()=> inject(CommonService).checkPermissionForRoute('user:view')],
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('user:create'),
    ],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('user:edit'),
    ],
  },
  // {
  //   path: 'detail/:id',
  //   loadComponent: () => import('./detail/detail'),
  //   canActivate: [
  //     () => inject(CommonService).checkPermissionForRoute('user:view'),
  //   ],
  // },
];
export default router;
