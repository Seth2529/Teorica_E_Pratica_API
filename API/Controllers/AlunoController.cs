using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using API.Models.Request;

namespace Aluno.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly string _CaminhoArquivoAluno;
        public AlunoController()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            _CaminhoArquivoAluno = Path.Combine(Directory.GetCurrentDirectory(), "Data", "aluno.json");
        }

        #region Métodos arquivo
        private List<AlunoViewModel> LerArquivoAlunos()
        {
            if (!System.IO.File.Exists(_CaminhoArquivoAluno))
            {
                return new List<AlunoViewModel>();
            }

            string json = System.IO.File.ReadAllText(_CaminhoArquivoAluno);
            return JsonConvert.DeserializeObject<List<AlunoViewModel>>(json);
        }


        private void EscreverArquivoAlunos(List<AlunoViewModel> alunos)
        {
            string json = JsonConvert.SerializeObject(alunos);
            System.IO.File.WriteAllText(_CaminhoArquivoAluno, json);
        }
        #endregion

        #region Operações CRUD

        [HttpGet]
        public IActionResult Get()
        {
            List<AlunoViewModel> alunos = LerArquivoAlunos();
            return Ok(alunos);
        }

        [HttpGet("{RA}")]
        public IActionResult Get(string RA)
        {
            List<AlunoViewModel> alunos = LerArquivoAlunos();
            AlunoViewModel aluno = alunos.Find(a => a.ra == RA);
            if (aluno == null)
            {
                return NotFound();
            }

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AlunoViewModel newAluno)
        {
            if (newAluno == null)
            {
                return BadRequest();
            }

            List<AlunoViewModel> alunos = LerArquivoAlunos();

            if (alunos.Any(a => a.ra == newAluno.ra))

                return BadRequest("existe um aluno com esse RA !!");

            AlunoViewModel novoAluno = new AlunoViewModel()
            {

                ra = newAluno.ra,
                nome = newAluno.nome,
                email = newAluno.email,
                cpf = newAluno.cpf,
                ativo = newAluno.ativo
            };

            alunos.Add(novoAluno);
            EscreverArquivoAlunos(alunos);

            return CreatedAtAction(nameof(Get), new { codigo = novoAluno.ra }, novoAluno);
        }

        [HttpPut("{RA}")]
        public IActionResult Put(string RA, [FromBody] AlunoViewModel aluno)
        {
            if (RA == null)

                return BadRequest();

            List<AlunoViewModel> alunos = LerArquivoAlunos();
            int index = alunos.FindIndex(a => a.ra == RA);
            if (index == -1)
                return NotFound();

            AlunoViewModel novoAluno = new AlunoViewModel()
            {
                ra = aluno.ra,
                nome = aluno.nome,
                email = aluno.email,
                cpf = aluno.cpf
            };

            alunos[index] = novoAluno;
            EscreverArquivoAlunos(alunos);

            return NoContent();
        }

        [HttpDelete("{RA}")]
        public IActionResult Delete(string RA)
        {
            List<AlunoViewModel> alunos = LerArquivoAlunos();
            AlunoViewModel aluno = alunos.Find(a => a.ra == RA);
            if (aluno == null)
                return NotFound();

            alunos.Remove(aluno);
            EscreverArquivoAlunos(alunos);

            return NoContent();
        }
        #endregion
    }
}