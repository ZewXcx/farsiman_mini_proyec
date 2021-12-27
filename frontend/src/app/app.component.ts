import { Component } from '@angular/core';
import { Login } from './Login/login.component';
import { Viajes } from './Viajes/viajes.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'transporte';
}
