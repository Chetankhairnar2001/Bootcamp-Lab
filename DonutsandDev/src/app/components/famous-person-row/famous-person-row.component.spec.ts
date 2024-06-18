import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FamousPersonRowComponent } from './famous-person-row.component';

describe('FamousPersonRowComponent', () => {
  let component: FamousPersonRowComponent;
  let fixture: ComponentFixture<FamousPersonRowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FamousPersonRowComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FamousPersonRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
