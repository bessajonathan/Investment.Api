namespace Investment.Infra
{
    using global::Investment.Core.Entities;
    using global::Investment.Core.Enums;
    using global::Investment.Infra.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    namespace Investment.Infra
    {
        public class InitializeData
        {
            public static void Initialize(InvestmentDbContext context)
            {
                context.Database.Migrate();

                var initializerClass = new InitializeData();
                initializerClass.InsertInitialValues(context);

            }

            public void InsertInitialValues(InvestmentDbContext context)
            {
                if (!context.Actives.Any())
                {
                    Active[] plans =
                    {
                    new Active(15,EUserActiveType.MGLU3),
                    new Active(25,EUserActiveType.PETR4),
                    new Active(30,EUserActiveType.VALE3),
                };

                    context.Actives.AddRange(plans);
                    context.SaveChanges();
                };


                //var user = context.Users.FirstOrDefault();
                //var actives = context.Actives.ToList();

                //var userActives = actives.Select(x => new UserActive(user.Id, x.Id, 1)).ToList();
                //context.UserActives.AddRange(userActives);
                //user.Wallet.Amount = 100.0;
                //context.Users.Update(user);
                //context.SaveChanges();
            }
        }
    }

}
