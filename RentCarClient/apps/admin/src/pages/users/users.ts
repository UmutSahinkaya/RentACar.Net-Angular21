import { ChangeDetectionStrategy, Component, inject, signal, ViewEncapsulation } from '@angular/core';
import { CommonService } from '../../services/common';
import { BreadcrumbModel } from '../../services/breadcrumb';
import { FlexiGridModule } from 'flexi-grid';
import Grid from '../../components/grid/grid';

@Component({
  imports: [Grid, FlexiGridModule],
  templateUrl: './users.html',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export default class Users {
  readonly breadcrumbs = signal<BreadcrumbModel[]>([
    {
      title: 'Kullanıcılar',
      icon: 'bi-people',
      url: '/users',
      isActive: true,
    },
  ]);

  readonly #common = inject(CommonService);

  checkPermission(permission: string): boolean {
    return this.#common.checkPermission(permission);
  }
}
