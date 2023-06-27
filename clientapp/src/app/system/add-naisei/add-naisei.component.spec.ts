import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNaiseiComponent } from './add-naisei.component';

describe('AddNaiseiComponent', () => {
  let component: AddNaiseiComponent;
  let fixture: ComponentFixture<AddNaiseiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddNaiseiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddNaiseiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
