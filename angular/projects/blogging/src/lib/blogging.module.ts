import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { BloggingComponent } from './components/blogging.component';
import { BloggingRoutingModule } from './blogging-routing.module';

@NgModule({
  declarations: [BloggingComponent],
  imports: [CoreModule, ThemeSharedModule, BloggingRoutingModule],
  exports: [BloggingComponent],
})
export class BloggingModule {
  static forChild(): ModuleWithProviders<BloggingModule> {
    return {
      ngModule: BloggingModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<BloggingModule> {
    return new LazyModuleFactory(BloggingModule.forChild());
  }
}
