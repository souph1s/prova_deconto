import { Categoria } from "./categoria.model";

export interface Tarefa {
  tarefaId: number;
  titulo: string;
  descricao: string;
  criadoEm: Date;
  categoria: Categoria;
  categoriaId: number;
  status: string;
}
