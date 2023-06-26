import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SystemComponent } from './system/system.component';
import { AddEditSystemComponent } from './system/add-edit-system/add-edit-system.component';
import { ShowSystemComponent } from './system/show-system_Naisei/show-system.component';

import { ApiserviceService } from './apiservice.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatButtonToggleModule } from "@angular/material/button-toggle";
import { SystemComponent_Gaisei } from './system/system.component_Gaisei';
import { ShowSystemComponent_Gaisei } from './system/sho-system_Gaisei/show-system.component_Gaisei';
import { AddNaiseiComponent } from './system/add-naisei/add-naisei.component';
import { EditNaiseiComponent } from './system/edit-naisei/edit-naisei.component';
import { EditGaiseiComponent } from './system/edit-gaisei/edit-gaisei.component';
import { AddGaiseiComponent } from './system/add-gaisei/add-gaisei.component';
@NgModule({
  declarations: [
    AppComponent,
    SystemComponent,
    SystemComponent_Gaisei,
    AddEditSystemComponent,
    ShowSystemComponent,
    ShowSystemComponent_Gaisei,
    AddNaiseiComponent,
    EditNaiseiComponent,
    EditGaiseiComponent,
    AddGaiseiComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatButtonToggleModule
  ],
  providers: [ApiserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
