import { ModuleWithProviders, NgModule } from '@angular/core';
import { BLOGGING_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class BloggingConfigModule {
  static forRoot(): ModuleWithProviders<BloggingConfigModule> {
    return {
      ngModule: BloggingConfigModule,
      providers: [BLOGGING_ROUTE_PROVIDERS],
    };
  }
}
