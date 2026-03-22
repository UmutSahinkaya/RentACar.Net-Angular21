import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';
import { inject } from '@angular/core';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./branches'),
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('branch:create'),
    ],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('branch:edit'),
    ],
  },
  {
    path: 'detail/:id',
    loadComponent: () => import('./detail/detail'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('branch:view'),
    ],
  },
];
export default router;
