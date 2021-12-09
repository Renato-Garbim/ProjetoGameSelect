import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListaSelecaoComponent} from './CompeticaoGames/lista-selecao/lista-selecao.component';
import { ListaVencedoresComponent } from './CompeticaoGames/lista-vencedores/lista-vencedores.component';


const routes: Routes = [
{path:'selecao', component:ListaSelecaoComponent},
{path:'vencedores', component:ListaVencedoresComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
