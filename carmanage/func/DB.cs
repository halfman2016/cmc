using carmanage.Model;
using SqlSugar;
using DbType = System.Data.DbType;


namespace carmanage.func
{
    public class DB
    {
        protected SqlSugarClient Db;

        public DB()
        {
            Db=new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "Server=localhost;Database=carmanager;Uid=root;Pwd=root",
                DbType = SqlSugar.DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.SystemTable
            });
        }

        public SimpleClient<cars> CarDb=>new SimpleClient<cars>(Db);
        public SimpleClient<sysusers> SystemuserDb => new SimpleClient<sysusers>(Db);
        public SimpleClient<comins>CominsDb=>new SimpleClient<comins>(Db);
        public SimpleClient<drivers>DriverDb=>new SimpleClient<drivers>(Db);
        public SimpleClient<forceins>ForeinsDb=>new SimpleClient<forceins>(Db);
        public SimpleClient<insclass>InsclassDb=>new SimpleClient<insclass>(Db);
        public SimpleClient<orgs>OrgsDb=>new SimpleClient<orgs>(Db);
        public SimpleClient<orgset>OrgsetDb=>new SimpleClient<orgset>(Db);
        public SimpleClient<owners>OwnersDb=>new SimpleClient<owners>(Db);
        public SimpleClient<people>PeopleDb=>new SimpleClient<people>(Db);
        public SimpleClient<testrec>TestDb=>new SimpleClient<testrec>(Db);
        
    }
}