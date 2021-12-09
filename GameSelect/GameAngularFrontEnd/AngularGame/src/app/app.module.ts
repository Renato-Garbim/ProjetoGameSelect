import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListaSelecaoComponent } from './CompeticaoGames/lista-selecao/lista-selecao.component';
import { ListaVencedoresComponent } from './CompeticaoGames/lista-vencedores/lista-vencedores.component';
import { GameService } from './game.service'; 

import { HttpClientModule } from '@angular/common/http' 

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MessagesComponent } from './messages/messages.component';
import { MessageService } from './message.service';


@NgModule({
  declarations: [
    AppComponent,
    ListaSelecaoComponent,
    ListaVencedoresComponent,
    MessagesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule
  ],
  providers: 
  [GameService, MessageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
