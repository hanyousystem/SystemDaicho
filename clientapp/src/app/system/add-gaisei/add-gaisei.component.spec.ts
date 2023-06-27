import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddGaiseiComponent } from './add-gaisei.component';

describe('AddGaiseiComponent', () => {
  let component: AddGaiseiComponent;
  let fixture: ComponentFixture<AddGaiseiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddGaiseiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddGaiseiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
