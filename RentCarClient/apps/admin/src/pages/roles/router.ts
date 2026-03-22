import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';
import { inject } from '@angular/core';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./roles'),
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('role:create'),
    ],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('role:edit'),
    ],
  },
  {
    path: 'detail/:id',
    loadComponent: () => import('./detail/detail'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('role:view'),
    ],
  },
  {
    path: 'permissions/:id',
    loadComponent: () => import('./permissions/permissions'),
    canActivate: [
      () =>
        inject(CommonService).checkPermissionForRoute(
          'role:updated_permissions',
        ),
    ],
  },
];
export default router;
