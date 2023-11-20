import { MatToolbarModule } from "@angular/material/toolbar";
import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";

// Importações do Angular Material
import { MatButtonModule } from "@angular/material/button";
import { MatInputModule } from "@angular/material/input";
import { MatSnackBarModule } from "@angular/material/snack-bar";
import { MatMenuModule } from "@angular/material/menu";
import { MatDividerModule } from "@angular/material/divider";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatListModule } from "@angular/material/list";
import { MatIconModule } from "@angular/material/icon";
import { MatCardModule } from "@angular/material/card";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { TarefaListarComponent } from "./pages/tarefa/tarefa-listar/tarefa-listar.component";
import { TarefaCadastrarComponent } from "./pages/tarefa/tarefa-cadastrar/tarefa-cadastrar.component";
import { TarefaAlterarComponent } from "./pages/tarefa/tarefa-alterar/tarefa-alterar.component";
import { TarefaListarNaoconcluidasComponent } from "./pages/tarefa/tarefa-listar-naoconcluidas/tarefa-listar-naoconcluidas.component";
import { TarefaListarConcluidasComponent } from "./pages/tarefa/tarefa-listar-concluidas/tarefa-listar-concluidas.component";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
@NgModule({
  declarations: [
    AppComponent,
    TarefaListarComponent,
    TarefaCadastrarComponent,
    TarefaAlterarComponent,
    TarefaListarNaoconcluidasComponent,
    TarefaListarConcluidasComponent,
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    MatButtonModule,
    MatMenuModule,
    MatDividerModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatToolbarModule,
    MatCardModule,
    MatInputModule,
    AppRoutingModule,
    FormsModule,
    MatSnackBarModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
