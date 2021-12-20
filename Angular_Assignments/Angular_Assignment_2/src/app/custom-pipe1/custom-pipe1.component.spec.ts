import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomPipe1Component } from './custom-pipe1.component';

describe('CustomPipe1Component', () => {
  let component: CustomPipe1Component;
  let fixture: ComponentFixture<CustomPipe1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomPipe1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomPipe1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
