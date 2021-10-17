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
             var xx = Guid.NewGuid();
            var parameters = new DynamicParameters();
            parameters.Add("KodeAccount", request.KodeAccount);
            parameters.Add("Account", request.Account);
            parameters.Add("NormalPos", request.NormalPos);
            parameters.Add("Kelompok", request.Kelompok);
            parameters.Add("DataAccountId", xx);


            if (request.Parent != "0")
            {
                parameters.Add("Parent", request.Parent);
            }
            else 
            {
                parameters.Add("Parent", (string)null); 
            }
          
            var sql = "INSERT INTO DataAccount(KodeAccount, Account, NormalPos, Kelompok, DataAccountId,Parent) VALUES(@KodeAccount, @Account, @NormalPos, @Kelompok, @DataAccountId,@Parent)";

            using (var conn = _connectionFactory.GetDbConnection())
            {
                await conn.QueryAsync(sql,parameters);

            }
            // var entity = Domain.DataAccount.CreateDataAccount(request.Parent, request.KodeAccount, request.Account, request.NormalPos, request.Kelompok);

            return xx;

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

            //const string sql = @" insert into dbo.Product (Name)
            //            values (@Name);
            //            SELECT CAST(SCOPE_IDENTITY() as int)";

            //using (var connection = _dataAccess.GetOpenConnection())
            //{
            //    var id = connection.Query<int>(sql, new { Name = name }).Single();
            //    return id;
            


        }
    }
}
