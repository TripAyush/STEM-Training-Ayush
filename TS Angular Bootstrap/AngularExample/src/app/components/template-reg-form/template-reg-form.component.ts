import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-template-reg-form',
  templateUrl: './template-reg-form.component.html',
  styleUrls: ['./template-reg-form.component.css'],
})
export class TemplateRegFormComponent implements OnInit {
  model: any = [];
  route!: Router;
  constructor(route: Router) {
    this.route = route;
  }

  ngOnInit(): void { }

  Register(regform: NgForm) {
    alert(
      'Name : ' +
      regform.value.uname +
      ', Address : ' +
      regform.value.addr +
      ', Gender : ' +
      regform.value.gender +
      ', City' +
      regform.value.city +
      ', Passion' +
      regform.value.passion
    );

    sessionStorage.setItem('UNAME', regform.value.uname);
    sessionStorage.setItem('ADDRESS', regform.value.addr);
    sessionStorage.setItem('GENDER', regform.value.gender);
    sessionStorage.setItem('CITY', regform.value.city);
    sessionStorage.setItem('PASSION', regform.value.passion);

    alert('Data stored in sessionStorage');
    this.route.navigate(['login'])
  }
}
