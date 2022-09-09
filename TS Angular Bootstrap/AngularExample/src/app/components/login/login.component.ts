import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  model: any = [];
  constructor() {}

  ngOnInit(): void {}

  Login(loginform: NgForm) {
    alert(
      'Email : ' +
        loginform.value.uname +
        ', Password : ' +
        loginform.value.password
    );

    sessionStorage.setItem('UEMAIL', loginform.value.uname);
    sessionStorage.setItem('UPASS', loginform.value.upass);

    alert('Data stored in sessionStorage');
  }
}
