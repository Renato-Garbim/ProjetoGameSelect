import { Injectable } from '@angular/core';
import { EntidadeGame } from './Entidades/entidade-game';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';
import { catchError, map, tap } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})


export class GameService {

  listaDeVencedores : EntidadeGame[] = [];

  readonly APIBaseDados = "https://l3-processoseletivo.azurewebsites.net/api/Competidores?copa=games";
  readonly APIDominio = "https://localhost:44329/Game";

  constructor(private http:HttpClient, private messageService: MessageService) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // TODO: better job of transforming error for user consumption
      //this.log(`${operation} failed: ${error.message}`);
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  ObterListaDeJogos():Observable<EntidadeGame[]>{

    this.messageService.add('GameService: Lista de jogos obtida com sucesso!');
    return this.http.get<EntidadeGame[]>(this.APIBaseDados).pipe(
      catchError(this.handleError<EntidadeGame[]>('ObterListaDeJogos', []))
    );

  }

  IniciarCompeticao(val:EntidadeGame[]): Observable<EntidadeGame[]>{   
    
    var response = this.http.post(this.APIDominio + "", val, this.httpOptions)        
    .pipe(map((data) => this.listaDeVencedores = data as EntidadeGame[]));
      
    return response;
  }

}
