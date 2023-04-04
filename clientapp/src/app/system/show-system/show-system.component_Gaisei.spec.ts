import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowSystemComponent_Gaisei } from './show-system.component_Gaisei';

describe('show-system.component_Gaisei', () => {
  let component: ShowSystemComponent_Gaisei;
  let fixture: ComponentFixture<ShowSystemComponent_Gaisei>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowSystemComponent_Gaisei ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowSystemComponent_Gaisei);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
