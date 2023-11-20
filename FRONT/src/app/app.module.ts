import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { TarefaListarComponent } from "./pages/tarefa/tarefa-listar/tarefa-listar.component";
import { TarefaCadastrarComponent } from "./pages/tarefa/tarefa-cadastrar/tarefa-cadastrar.component";
import { TarefaAlterarComponent } from "./pages/tarefa/tarefa-alterar/tarefa-alterar.component";
import { TarefaListarNaoconcluidasComponent } from './pages/tarefa/tarefa-listar-naoconcluidas/tarefa-listar-naoconcluidas.component';
import { TarefaListarConcluidasComponent } from './pages/tarefa/tarefa-listar-concluidas/tarefa-listar-concluidas.component';
@NgModule({
  declarations: [
    AppComponent,
    TarefaListarComponent,
    TarefaCadastrarComponent,
    TarefaAlterarComponent,
    TarefaListarNaoconcluidasComponent,
    TarefaListarConcluidasComponent,
  ],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
