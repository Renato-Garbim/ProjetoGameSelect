import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, FormControl, ValidatorFn } from '@angular/forms';
import { EntidadeGame } from 'src/app/Entidades/entidade-game';
import { GameService } from 'src/app/game.service';
import { MessageService } from 'src/app/message.service';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-lista-selecao',
  templateUrl: './lista-selecao.component.html',
  styleUrls: ['./lista-selecao.component.css']
})

export class ListaSelecaoComponent implements OnInit {
  
  form: FormGroup;
  ListaJogos:EntidadeGame[] = [];
  quantidade:number = 0;
  
  get ListaJogosSelecionados() {
    return this.form.controls.orders as FormArray;
  }

  constructor(private service: GameService, private formBuilder: FormBuilder, private messageService: MessageService) { 

    //Criar o Form
    this.form = this.formBuilder.group({
      orders: new FormArray([])
    });

    //Recarregar o Form 
    this.addCheckboxes();
  }
  
  
  private addCheckboxes() {
    this.ListaJogos.forEach(() => this.ListaJogosSelecionados.push(new FormControl(false)));
  }

  ngOnInit(): void {

    this.recarregarLista();

  }

  onCheckChange(event: any, entidade: EntidadeGame) {
  
    const controlsForm = this.form.value.orders;            

    /* Selected */
    if(event.target.checked){

      // Add a new control in the arrayForm
      controlsForm.push(new FormControl(entidade));
      this.quantidade = this.quantidade + 1;    

      this.messageService.clear();
      this.messageService.add('Você Selecionou até o moento ' + this.quantidade + ' Jogos');


      console.log(this.quantidade);
      console.log(controlsForm);
    }
    /* unselected */
    else{
      
      // find the unselected element
      let i:number = 0;
  
      controlsForm.forEach((ctrl: FormControl) => {

        if(ctrl.value == entidade) {          

          // Remover o FormControl que foi deselecionado 
          controlsForm.splice(i, 1);          
          this.quantidade = this.quantidade - 1;

          this.messageService.clear();
          this.messageService.add('Você Selecionou até o moento ' + this.quantidade + ' Jogos');


          return;

        }
  
        i++;

      });
    }
  }


  submit() {
    
    var lista:EntidadeGame[] = [];

    var json = this.form.value.orders;

    json.forEach(function(order: FormControl){
      lista.push(order.value);
    });

    this.service.IniciarCompeticao(lista).subscribe((data) => console.log(data));

    console.log(lista);

  }

  recarregarLista(){
    this.service.ObterListaDeJogos().subscribe(data => {

      this.ListaJogos = data;

    });
  }

}
