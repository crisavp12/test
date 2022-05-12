import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { GetDefectiveItemComponent } from './components/get-defective-item/get-defective-item.component';
import { GetGoodItemComponent } from './components/get-good-item/get-good-item.component';
import { StorageItemComponent } from './components/storage-item/storage-item.component';

export const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'defectiveItems', component: GetDefectiveItemComponent},
  {path: 'goodItems', component: GetGoodItemComponent},
  {path: 'storage', component: StorageItemComponent},
  {path: '', pathMatch: 'full', redirectTo: 'home'},
  {path: '**', pathMatch: 'full', redirectTo: 'home'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes,{useHash: true})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
