import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaVencedoresComponent } from './lista-vencedores.component';

describe('ListaVencedoresComponent', () => {
  let component: ListaVencedoresComponent;
  let fixture: ComponentFixture<ListaVencedoresComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListaVencedoresComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaVencedoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
