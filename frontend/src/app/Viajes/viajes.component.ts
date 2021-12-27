import { Component, OnInit } from '@angular/core';
import{FormGroup,FormBuilder,Validator, Validators}from '@angular/forms';
import { Empleado } from '../GlobalModels/Empleado';
@Component({
  selector: 'viajes',
  templateUrl: './viajes.component.html',
  styleUrls: ['./viajes.component.css']
})

export class Viajes implements OnInit {
  form:FormGroup;
  tittle = 'Viajes';
  //empleados:Empleado=[{}];

 
  ngOnInit():void{}
  addViaje(){

  }
}