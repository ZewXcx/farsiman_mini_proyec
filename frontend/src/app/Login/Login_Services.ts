
import { Injectable } from "@angular/core";
import{HttpClient} from '@angular/common/http';
import { Usuario } from "./Usuario";
import { Observable, UnsubscriptionError } from "rxjs";
@Injectable({
    providedIn: 'root'
})
export class LoginService{
    user:Usuario;
    loginUrl='https://localhost:44395/';
    apiUrl='api/Usuarios';
    constructor(private http:HttpClient){

    }

    logIn(usr:string,pass:string):Observable<Usuario>{
       this.user= new Usuario(usr,pass);
       return this.http.post<Usuario>(this.loginUrl+this.apiUrl,this.user);
    }
 

}