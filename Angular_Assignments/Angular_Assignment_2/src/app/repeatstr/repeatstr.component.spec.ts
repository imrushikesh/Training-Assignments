import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RepeatstrComponent } from './repeatstr.component';

describe('RepeatstrComponent', () => {
  let component: RepeatstrComponent;
  let fixture: ComponentFixture<RepeatstrComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RepeatstrComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RepeatstrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
