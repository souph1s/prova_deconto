import { Categoria } from "./categoria.model";

export interface Tarefa {
  TarefaId: number;
  Titulo: string;
  Descricao: string;
  CriadoEm: Date;
  Categoria: Categoria;
  CategoriaId: number;
  Status: string;
}
