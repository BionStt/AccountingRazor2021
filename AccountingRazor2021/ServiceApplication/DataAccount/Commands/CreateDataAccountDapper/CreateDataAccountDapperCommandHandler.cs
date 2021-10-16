using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Dapper;
using AccountingRazor2021.Persistence.Dapper;

namespace AccountingRazor2021.ServiceApplication.DataAccount.Commands.CreateDataAccountDapper
{
    public class CreateDataAccountDapperCommandHandler : IRequestHandler<CreateDataAccountDapperCommand, Guid>
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public CreateDataAccountDapperCommandHandler(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<Guid> Handle(CreateDataAccountDapperCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.DataAccount.CreateDataAccount(request.Parent, request.KodeAccount, request.Account, request.NormalPos, request.Kelompok);
            
            return entity.DataAccountId;

            //var sql = "INSERT INTO Employee(Name) "
            //       + "VALUES(@Name)";
            //var parameters = new DynamicParameters();
            //parameters.Add("@Name", entity.Name, System.Data.DbType.String);

            //using (var conn = _connectionFactory.GetDbConnection())
            //{
            //    await conn.ExecuteAsync(@"
            //        INSERT INTO Book (Title, Author) 
            //        VALUES (@Title, @Author);
            //    ", command);
            //    await conn.QueryAsync(sql, parameters);
            //}
        }
    }
}
