import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SystemComponent } from './system/system.component';
import { AddEditSystemComponent } from './system/add-edit-system/add-edit-system.component';
import { ShowSystemComponent } from './system/show-system/show-system.component';

import { ApiserviceService } from './apiservice.service';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatButtonToggleModule } from "@angular/material/button-toggle";
import { SystemComponent_Gaisei } from './system/system.component_Gaisei';
import { ShowSystemComponent_Gaisei } from './system/show-system/show-system.component_Gaisei';
@NgModule({
  declarations: [
    AppComponent,
    SystemComponent,
    SystemComponent_Gaisei,
    AddEditSystemComponent,
    ShowSystemComponent,
    ShowSystemComponent_Gaisei
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
