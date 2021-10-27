using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.ServiceApplication.DataAccount.Commands.CreateDataAccount;
using AccountingRazor2021.ServiceApplication.DataAccount.Commands.CreateDataAccountDapper;
using AccountingRazor2021.ServiceApplication.DataJournals.Commands.CreateDataJournals;
using AccountingRazor2021.ServiceApplication.DataJournalsDetails.Commands.CreateDataJournalsDetails;

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
        public static CreateDataJournalsDetailsCommand ToCommand(this CreateDataJournalsDetailsRequest model)
        {
            return new CreateDataJournalsDetailsCommand {
            DataAccountId = model.DataAccountId,
            DataJournalHeaderId = model.DataJournalHeaderId,
            Debit = model.Debit,
            Kredit = model.Kredit,
            Keterangan = model.Keterangan
            };
        }
        public static CreateDataJournalsCommand ToCommand(this CreateDataJournalsRequest model)
        {
            return new CreateDataJournalsCommand {
            Keterangan = model.Keterangan,
            TanggalInput = model.TanggalInput,
            TipeJournalId = model.TipeJournalId,
            UserInput = model.UserInput

            };
        }



    }
}
