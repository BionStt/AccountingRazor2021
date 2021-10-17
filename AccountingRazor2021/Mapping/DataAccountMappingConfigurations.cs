using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataAccount.Commands.CreateDataAccount;
using AccountingRazor2021.ServiceApplication.DataAccount.Commands.CreateDataAccountDapper;

namespace AccountingRazor2021.Mapping
{
    public static class DataAccountMappingConfigurations
    {
        public static CreateDataAccountCommand ToCommand(this CreateDataAccountCommandRequest model)
        {
            return new CreateDataAccountCommand
            {
                Account = model.Account,
                Kelompok = model.Kelompok,
                KodeAccount = model.KodeAccount,
                NormalPos = model.NormalPos,
                Parent = model.Parent
            };
        }

        public static CreateDataAccountDapperCommand ToCommandDapper(this CreateDataAccountCommandRequest model)
        {
            return new CreateDataAccountDapperCommand
            {
                Account = model.Account,
                Kelompok = model.Kelompok,
                KodeAccount = model.KodeAccount,
                NormalPos = model.NormalPos,
                Parent = model.Parent
            };

        }
    }
}
