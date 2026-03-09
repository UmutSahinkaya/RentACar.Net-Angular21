import { ChangeDetectionStrategy, Component, inject, OnInit, resource, ViewEncapsulation } from '@angular/core';
import { BreadcrumbService } from '../../services/breadcrumb';
import Blank from '../../components/blank/blank';
import { lastValueFrom } from 'rxjs';
import { HttpService } from '../../services/http';

@Component({
  imports: [Blank],
  templateUrl: './dashboard.html',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export default class Dashboard implements OnInit {
  readonly #breadcrumb = inject(BreadcrumbService);
  readonly #http = inject(HttpService);
  readonly result=resource({
    loader:async ()=>{
      // eslint-disable-next-line no-var
      var res= await lastValueFrom(this.#http.getResource("/rent/"));
      return res;
    }
  });
  ngOnInit(): void {
    this.#breadcrumb.setDashboard();
  }
  makeRequest(){
    this.result.reload();
  }
}
