using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;


namespace WcfDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CIAService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CIAService.svc or CIAService.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract]
    public class CiaService : ICiaServics
    {
        [OperationContract]
        public List<Person> GetSalesPeople()
        {
            var db = new WideWorldImportersEntities();
            var salesPeople = db.People.Where(x => x.IsSalesperson).ToList();
            return salesPeople;
        }

        //    public List<Peeps> GetData()
        //    {
        //        var connString = ConfigurationManager.ConnectionStrings["CIA"].ConnectionString;
        //        var peepsList = new List<Peeps>();
        //        //using var db = new LinqToDB.Data.DataConnection(
        //        //    ProviderName.SqlServer2017, connString);

        //        //var p = db.GetTable<ApplicationSchema.Person>().Take(100);
        //    //    var peeps = from p in db.GetTable<ApplicationSchema.Person>()
        //    //                where p.PhoneNumber != null && p.IsSalesperson && p.IsPermittedToLogon
        //    //                select new
        //    //                {
        //    //                    p.People.PersonId,
        //    //                    p.FullName,
        //    //                    p.PreferredName,
        //    //                    p.SearchName,
        //    //                    p.IsPermittedToLogon,
        //    //                    p.LogonName,
        //    //                    p.IsSystemUser,
        //    //                    p.IsEmployee,
        //    //                    p.IsSalesperson,
        //    //                    p.PhoneNumber,
        //    //                    p.FaxNumber,
        //    //                    p.EmailAddress,


        //    //                };
        //    //    foreach (var pp in peeps.ToList())
        //    //    {
        //    //        var ps = new Peeps
        //    //        {
        //    //            PersonId = pp.PersonId,
        //    //            FullName = pp.FullName,
        //    //            PreferredName = pp.PreferredName,
        //    //            SearchName = pp.SearchName,
        //    //            IsPermittedToLogon = pp.IsPermittedToLogon,
        //    //            LogonName = pp.LogonName,
        //    //            IsSystemUser = pp.IsEmployee,
        //    //            IsEmployee = pp.IsEmployee,
        //    //            IsSalesperson = pp.IsSalesperson,
        //    //            PhoneNumber = pp.PhoneNumber,
        //    //            FaxNumber = pp.FaxNumber,
        //    //            EmailAddress = pp.EmailAddress,
        //    //        };
        //    //        peepsList.Add(ps);
        //    //    }

        //    //    return peepsList;
        //    //}



        //}
    }
}