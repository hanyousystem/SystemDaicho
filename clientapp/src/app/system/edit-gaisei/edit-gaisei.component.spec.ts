import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditGaiseiComponent } from './edit-gaisei.component';

describe('EditGaiseiComponent', () => {
  let component: EditGaiseiComponent;
  let fixture: ComponentFixture<EditGaiseiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditGaiseiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditGaiseiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
