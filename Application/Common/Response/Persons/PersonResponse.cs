using Application.Common.Response.Auditables;
using Application.Common.Response.Documents;

namespace Application.Common.Response.Persons
{
    public class PersonResponse : ResponseBase
    {
        public string Name { get; private set; }
        public int Age { get; }
        public CpfResponse Cpf { get; }
        public RgResponse Rg { get; }

        public PersonResponse(
            string id,
            AuditableEntityResponse auditable,
            string name,
            int age,
            CpfResponse cpf,
            RgResponse rg)
            : base(id, auditable)
        {
            Name = name;
            Age = age;
            Cpf = cpf;
            Rg = rg;
        }
    }
}
