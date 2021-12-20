import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StringWordsComponent } from './string-words.component';

describe('StringWordsComponent', () => {
  let component: StringWordsComponent;
  let fixture: ComponentFixture<StringWordsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StringWordsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StringWordsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
