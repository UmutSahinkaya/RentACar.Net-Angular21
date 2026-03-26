import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./extra'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('extra:view'),
    ],
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('extra:create'),
    ],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('extra:edit')],
  },
  {
    path: 'detail/:id',
    loadComponent: () => import('./detail/detail'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('extra:view')],
  },
];

export default router;
