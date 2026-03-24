import { Routes } from '@angular/router';
import { CommonService } from '../../services/common';
import { inject } from '@angular/core';

const router: Routes = [
  {
    path: '',
    loadComponent: () => import('./categories'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('category:view')],
  },
  {
    path: 'add',
    loadComponent: () => import('./create/create'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('category:create')],
  },
  {
    path: 'edit/:id',
    loadComponent: () => import('./create/create'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('category:edit')],
  },
  {
    path: 'detail/:id',
    loadComponent: () => import('./detail/detail'),
    canActivate: [() => inject(CommonService).checkPermissionForRoute('category:view')],
  },
];
export default router;
