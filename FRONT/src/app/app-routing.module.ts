import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { TarefaListarComponent } from "./pages/tarefa/tarefa-listar/tarefa-listar.component";
import { TarefaAlterarComponent } from "./pages/tarefa/tarefa-alterar/tarefa-alterar.component";
import { TarefaCadastrarComponent } from "./pages/tarefa/tarefa-cadastrar/tarefa-cadastrar.component";
import { TarefaListarConcluidasComponent } from "./pages/tarefa/tarefa-listar-concluidas/tarefa-listar-concluidas.component";
import { TarefaListarNaoconcluidasComponent } from "./pages/tarefa/tarefa-listar-naoconcluidas/tarefa-listar-naoconcluidas.component";

const routes: Routes = [
  {
    path: "",
    redirectTo: "pages/tarefa/listar",
    pathMatch: "full",
  },
  {
    path: "pages/tarefa/listar",
    component: TarefaListarComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
