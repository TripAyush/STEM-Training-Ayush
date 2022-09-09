import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'

@Component({
  selector: 'app-pizza-shop',
  templateUrl: './pizza-shop.component.html',
  styleUrls: ['./pizza-shop.component.css']
})
export class PizzaShopComponent implements OnInit {
  model: any = [];
  constructor() {
  }

  ngOnInit(): void {
    this.model.bigItalyuprice = 10;
    this.model.meatLoveruprice = 9;
    this.model.veggieLoveruprice = 8;
    this.model.meatLoverqty = 0;
    this.model.bigItalyqty = 0;
    this.model.veggieLoverqty = 0;
  }
  Submit(pizzaForm: NgForm) {
    if (pizzaForm.value.bigItaly) {
      if (pizzaForm.value.bigItalyqty == 0) {
        alert("enter the quantity for big italy pizza");
        return;
      }
      pizzaForm.value.bigItalyTotal = pizzaForm.value.bigItalyqty * pizzaForm.value.bigItalyuprice;
      this.model.bigItalyTotal = pizzaForm.value.bigItalyTotal;
    }
    else {
      pizzaForm.value.bigItalyTotal = 0;
      this.model.bigItalyTotal = 0;
    }
    if (pizzaForm.value.meatLover) {
      if (pizzaForm.value.meatLoverqty == 0) {
        alert("enter the quantity for meat lover pizza");
        return;
      }
      pizzaForm.value.meatLoverTotal = pizzaForm.value.meatLoverqty * pizzaForm.value.meatLoveruprice;
      this.model.meatLoverTotal = pizzaForm.value.meatLoverTotal;

    }
    else {
      pizzaForm.value.meatLoverTotal = 0;
      this.model.meatLoverTotal = 0;
    }
    if (pizzaForm.value.veggieLover) {
      if (pizzaForm.value.veggieLoverqty == 0) {
        alert("enter the quantity of veggie lover pizza");
        return;
      }
      pizzaForm.value.veggieLoverTotal = pizzaForm.value.veggieLoverqty * pizzaForm.value.veggieLoveruprice;
      this.model.veggieLoverTotal = pizzaForm.value.veggieLoverTotal;
    }
    else {
      pizzaForm.value.veggieLoverTotal = 0;
      this.model.veggieLoverTotal = 0;
    }
    this.model.Total = pizzaForm.value.bigItalyTotal + pizzaForm.value.meatLoverTotal + pizzaForm.value.veggieLoverTotal;
    console.log(pizzaForm.value.meatLoverqty, pizzaForm.value.meatLoverTotal);
  }


}