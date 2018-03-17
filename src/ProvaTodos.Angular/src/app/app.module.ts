import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { UsuarioService } from './usuario.service';
import { HttpClientModule } from '@angular/common/http';




import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, HttpClientModule
  ],
  providers: [UsuarioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
