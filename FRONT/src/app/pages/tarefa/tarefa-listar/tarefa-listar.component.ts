// animal-listar.component.ts
import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Tarefa } from "src/app/models/tarefa.model";
import { Router } from "@angular/router";
import { MatSnackBar } from "@angular/material/snack-bar";

@Component({
  selector: "app-animal-listar",
  templateUrl: "./tarefa-listar.component.html",
  styleUrls: ["./tarefa-listar.component.css"],
})
export class TarefaListarComponent implements OnInit {
  tarefas: Tarefa[] = [];

  constructor(
    private client: HttpClient,
    private snackBar: MatSnackBar,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.client
      .get<Tarefa[]>("https://localhost:7015/api/tarefa/listar")
      .subscribe({
        next: (tarefas) => {
          console.table(tarefas);
          this.tarefas = tarefas;
        },
        error: (erro) => {
          console.log(erro);
        },
      });
  }
}
