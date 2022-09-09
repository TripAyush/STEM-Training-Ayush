import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateRegFormComponent } from './template-reg-form.component';

describe('TemplateRegFormComponent', () => {
  let component: TemplateRegFormComponent;
  let fixture: ComponentFixture<TemplateRegFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemplateRegFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemplateRegFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
