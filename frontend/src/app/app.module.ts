import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { Login } from './Login/login.component';
import {Viajes} from './Viajes/viajes.component';
import {ReactiveFormsModule} from '@angular/forms'
import { HttpClientModule } from '@angular/common/http';
import { Routes,RouterModule } from '@angular/router';
const routes:Routes=[
  {path:'',component:Login},
  {path:'viajes',component:Viajes}
]
@NgModule({
  declarations: [
    AppComponent,
    Login,
    Viajes
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent],
  exports:[RouterModule]
})
export class AppModule { }
