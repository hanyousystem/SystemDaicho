import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemComponent_Gaisei } from './system.component_Gaisei';

describe('system.component_Gaisei', () => {
  let component: SystemComponent_Gaisei;
  let fixture: ComponentFixture<SystemComponent_Gaisei>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SystemComponent_Gaisei ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SystemComponent_Gaisei);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
