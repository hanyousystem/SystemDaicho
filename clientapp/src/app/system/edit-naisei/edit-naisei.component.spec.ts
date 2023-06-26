import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditNaiseiComponent } from './edit-naisei.component';

describe('EditNaiseiComponent', () => {
  let component: EditNaiseiComponent;
  let fixture: ComponentFixture<EditNaiseiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditNaiseiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditNaiseiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
