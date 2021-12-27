
import { Injectable } from "@angular/core";
import{HttpClient} from '@angular/common/http';
import { Empleado } from "../GlobalModels/Empleado";
import { Observable, UnsubscriptionError } from "rxjs";
@Injectable({
    providedIn: 'root'
})
export class ViajeService{
   
    loginUrl='https://localhost:44395/';
    apiUrl='api/?';
    constructor(private http:HttpClient){

    }

    addViaje(usr:string,pass:string){
       
        this.http.post(this.loginUrl+this.apiUrl,"data");
    }
 

}