import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import {CommonService } from '../../services/common';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./protection-packages'),
    canActivate: [
      () =>
        inject(CommonService).checkPermissionForRoute(
          'protection_package:view',
        ),
    ],
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () =>
        inject(CommonService).checkPermissionForRoute(
          'protection_package:create',
        ),
    ],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () =>
        inject(CommonService).checkPermissionForRoute(
          'protection_package:edit',
        ),
    ],
  },
  {
    path: 'detail/:id',
    loadComponent: () => import('./detail/detail'),
    canActivate: [
      () =>
        inject(CommonService).checkPermissionForRoute(
          'protection_package:view',
        ),
    ],
  },
];

export default router;
