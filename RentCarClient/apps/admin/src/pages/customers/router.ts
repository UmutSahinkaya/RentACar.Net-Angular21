import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./customers'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('customer:view'),
    ],
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('customer:create'),
    ],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('customer:edit'),
    ],
  },
  {
    path: 'detail/:id',
    loadComponent: () => import('./detail/detail'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('customer:view'),
    ],
  },
];

export default router;
