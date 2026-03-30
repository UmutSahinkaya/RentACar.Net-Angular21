import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./reservations'),
    canActivate: [
      () => inject(CommonService).checkPermissionForRoute('reservation:view'),
    ],
  },
  {
      path: 'add',
      loadComponent: () => import('./create/create'),
      canActivate: [() => inject(CommonService).checkPermissionForRoute('reservation:create')]
  },
  {
      path: 'edit/:id',
      loadComponent: () => import('./create/create'),
      canActivate: [() => inject(CommonService).checkPermissionForRoute('reservation:edit')]
  },
  {
      path: 'detail/:id',
      loadComponent: () => import('./detail/detail'),
      canActivate: [() => inject(CommonService).checkPermissionForRoute('reservation:view')]
  }
];

export default router;
