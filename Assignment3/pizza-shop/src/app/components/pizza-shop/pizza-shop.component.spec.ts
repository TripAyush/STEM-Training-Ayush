import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PizzaShopComponent } from './pizza-shop.component';

describe('PizzaShopComponent', () => {
  let component: PizzaShopComponent;
  let fixture: ComponentFixture<PizzaShopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PizzaShopComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PizzaShopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
