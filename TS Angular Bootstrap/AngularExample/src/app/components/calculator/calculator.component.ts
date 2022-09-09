import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css'],
})
export class CalculatorComponent implements OnInit {
  num1!: number;
  num2!: number;
  result!: number;
  constructor() {
    this.num1 = 45;
    this.num2 = 37;
    this.result = 0;
  }

  ngOnInit(): void {}

  add(): void {
    this.result = this.num1 + this.num2;
  }
  sub(): void {
    this.result = this.num1 - this.num2;
  }
  mul(): void {
    this.result = this.num1 * this.num2;
  }
  div(): void {
    this.result = this.num1 / this.num2;
  }
}
