import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReactiveRegFormComponent } from './reactive-reg-form.component';

describe('ReactiveRegFormComponent', () => {
  let component: ReactiveRegFormComponent;
  let fixture: ComponentFixture<ReactiveRegFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReactiveRegFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReactiveRegFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
