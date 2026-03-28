import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./vehicles'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('vehicle:view')],
  },
  {
      path: 'add',
      loadComponent: () => import('./create/create'),
      canActivate: [() => inject(CommonService).checkPermissionForRoute('vehicle:create')]
  },
  {
      path: 'edit/:id',
      loadComponent: () => import('./create/create'),
      canActivate: [() => inject(CommonService).checkPermissionForRoute('vehicle:edit')]
  },
  {
      path: 'detail/:id',
      loadComponent: () => import('./detail/detail'),
      canActivate: [() => inject(CommonService).checkPermissionForRoute('vehicle:view')]
  }
];

export default router;
