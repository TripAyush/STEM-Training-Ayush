import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-reg-form',
  templateUrl: './reactive-reg-form.component.html',
  styleUrls: ['./reactive-reg-form.component.css'],
})
export class ReactiveRegFormComponent implements OnInit {
  regform!: FormGroup;
  constructor() {}

  ngOnInit(): void {
    this.regform = new FormGroup({
      uname: new FormControl(null, Validators.required),
      addr: new FormControl(null, Validators.required),
      gender: new FormControl(null, Validators.required),
      city: new FormControl(null, Validators.required),
      passion: new FormControl(null, Validators.required),
    });
  }

  Register() {
    alert(
      'Name : ' +
        this.regform.value.uname +
        ', Address : ' +
        this.regform.value.addr +
        ', Gender : ' +
        this.regform.value.gender +
        ', City : ' +
        this.regform.value.city +
        ', Passion : ' +
        this.regform.value.passion
    );

    localStorage.setItem('UNAME', this.regform.value.uname);
    localStorage.setItem('ADDRESS', this.regform.value.addr);
    localStorage.setItem('GENDER', this.regform.value.gender);
    localStorage.setItem('CITY', this.regform.value.city);
    localStorage.setItem('PASSION', this.regform.value.passion);

    alert("Data stored in localStorage")
  }
}
