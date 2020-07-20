using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models {

    public class AlunoDisciplina {

        public AlunoDisciplina() {

        }

        public AlunoDisciplina(int DisciplinaId, int AlunoId) {
            this.DisciplinaId = DisciplinaId;
            this.AlunoId = AlunoId;

        }

        public Aluno Aluno { get; set; }
        public int AlunoId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }
        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }
       
    }
}