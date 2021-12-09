import { Component, OnInit } from '@angular/core';
import { EntidadeGame } from 'src/app/Entidades/entidade-game';
import { GameService } from 'src/app/game.service';

@Component({
  selector: 'app-lista-vencedores',
  templateUrl: './lista-vencedores.component.html',
  styleUrls: ['./lista-vencedores.component.css']
})
export class ListaVencedoresComponent implements OnInit {
  
  constructor(private service: GameService) { }
  Lista: EntidadeGame[] = [];

  ngOnInit(): void {

    this.Lista = this.service.listaDeVencedores;

  }

}
