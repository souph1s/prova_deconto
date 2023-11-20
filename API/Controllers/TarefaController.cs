using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using System.Dynamic;

namespace API.Controllers;

[Route("api/tarefa")]
[ApiController]
public class TarefaController : ControllerBase
{
    private readonly AppDataContext _context;

    public TarefaController(AppDataContext context) =>
        _context = context;

    // GET: api/tarefa/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Tarefa> tarefas = _context.Tarefas.Include(x => x.Categoria).ToList();
            return Ok(tarefas);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    // POST: api/tarefa/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Tarefa tarefa)
    {
        try
        {
            Categoria? categoria = _context.Categorias.Find(tarefa.CategoriaId);
            if (categoria == null)
            {
                return NotFound();
            }
            tarefa.Categoria = categoria;
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Created("", tarefa);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

   [HttpPatch]
[Route("atualizar/{id}")]
public IActionResult AtualizarStatus([FromRoute] int id, [FromBody] AtualizacaoStatusModel atualizacaoStatus)
{
    try
    {
        Tarefa tarefaExistente = _context.Tarefas.Find(id);

        if (tarefaExistente == null)
        {
            return NotFound();
        }

        // Atualiza apenas o status da tarefa
        tarefaExistente.Status = atualizacaoStatus.Status;

        _context.SaveChanges();

        return Ok(tarefaExistente);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}

public class AtualizacaoStatusModel
{
    public string Status { get; set; }
}

// GET: api/tarefa/listar/concluidas
[HttpGet]
[Route("listar/concluidas")]
public IActionResult ListarTarefasConcluidas()
{
    try
    {
        List<Tarefa> tarefasConcluidas = _context.Tarefas
            .Where(x => x.Status == "Concluída")
            .Include(x => x.Categoria)
            .ToList();

        return Ok(tarefasConcluidas);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}

// GET: api/tarefa/listar/naoconcluidas
[HttpGet]
[Route("listar/naoconcluidas")]
public IActionResult ListarTarefasNaoConcluidas()
{
    try
    {
        List<Tarefa> tarefasNaoConcluidas = _context.Tarefas
            .Where(x => x.Status != "Concluída")
            .Include(x => x.Categoria)
            .ToList();

        return Ok(tarefasNaoConcluidas);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}

}
