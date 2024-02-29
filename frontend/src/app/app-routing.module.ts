import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsAdminComponent } from './components/product/products-admin/products-admin.component';
import { ProductsComponent } from './components/product/products/products.component';

const routes: Routes = [
  {path: 'admin/products', component: ProductsAdminComponent},
  {path: 'products', component: ProductsComponent},
  {path: '', pathMatch: "full", redirectTo: 'products'},
  {path: '**', pathMatch: "full", redirectTo: 'products'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
