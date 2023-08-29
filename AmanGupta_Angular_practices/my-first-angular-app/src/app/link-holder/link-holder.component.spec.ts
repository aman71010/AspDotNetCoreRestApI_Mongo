import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinkHolderComponent } from './link-holder.component';

describe('LinkHolderComponent', () => {
  let component: LinkHolderComponent;
  let fixture: ComponentFixture<LinkHolderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LinkHolderComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LinkHolderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
