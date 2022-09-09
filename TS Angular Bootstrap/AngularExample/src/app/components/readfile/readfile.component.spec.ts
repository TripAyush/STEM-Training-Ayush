import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadfileComponent } from './readfile.component';

describe('ReadfileComponent', () => {
  let component: ReadfileComponent;
  let fixture: ComponentFixture<ReadfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReadfileComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReadfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
