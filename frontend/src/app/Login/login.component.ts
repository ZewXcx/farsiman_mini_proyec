import { Component, OnInit } from '@angular/core';
import{FormGroup,FormBuilder,Validator, Validators}from '@angular/forms';
import { LoginService } from './Login_Services';
import{Router} from '@angular/router';

@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  //template:`<h1>hola</h1>`,
  styleUrls: ['./login.component.css']
})

export class Login implements OnInit {
  form:FormGroup;
  tittle = 'Login';

  constructor(private formbuilder:FormBuilder,private lgs:LoginService,private router:Router) {
    this.lgs=lgs;
    this.form=this.formbuilder.group({
    user:['',Validators.required],
    pass:['',Validators.required]});
  }

   login(){ 
    console.log(this.form);
    this.lgs.logIn(this.form.get('user')?.value,this.form.get('pass')?.value).subscribe(data=>{
      console.log("lasd");
      console.log(data);
      if(data.idUsuario!=-1&&data.idEmpleado!=-1){
        this.router.navigate(['/viajes']);
      }
    });
   }
  ngOnInit():void{}

}
