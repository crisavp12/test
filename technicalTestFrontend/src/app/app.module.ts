//start modules
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule, routes } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
//end modules

//start components
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { StorageItemComponent } from './components/storage-item/storage-item.component';
import { GetGoodItemComponent } from './components/get-good-item/get-good-item.component';
import { GetDefectiveItemComponent } from './components/get-defective-item/get-defective-item.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
//end components

//start services
//end services

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StorageItemComponent,
    GetGoodItemComponent,
    GetDefectiveItemComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    DataTablesModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
