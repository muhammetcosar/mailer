using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgs
{
    class Db
    {
        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection("Data Source=MUHAMMET;Initial Catalog=TGS;Integrated Security=True");
            }
        }
        public static DataTable ProgramTableGet()
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_PROGRAM__SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static Programs ProgramParseGet(DataRow row)
        {
            Programs p = new Programs();
            p.PROGRAMID = new Guid(row["PROGRAMID"].ToString());
            p.PROGRAMNAME = row["PROGRAMNAME"].ToString();

            return p;
        }
        public static List<Programs> ProgramListGet()
        {
            var table = ProgramTableGet();
            List<Programs> list = new List<Programs>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(ProgramParseGet(row));
            }
            return list;
        }

        public static DataTable ActivitiesTableGet(Guid id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_ACTIVITIES_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@PROGRAMID", id);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static Activities ActivitiesParseGet(DataRow row)
        {
            Activities p = new Activities();
            p.ACTIVITYID = new Guid(row["ACTIVITYID"].ToString());
            p.ACTIVITYNAME = row["ACTIVITYNAME"].ToString();

            return p;
        }
        public static List<Activities> ActivitiesListGet(Guid id)
        {
            var table = ActivitiesTableGet(id);
            List<Activities> list = new List<Activities>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(ActivitiesParseGet(row));
            }
            return list;
        }

        public static DataTable ActivityMailTableGet(Guid id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_AL_ST_ACTIVITYENROLLMENT_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@ACTIVITYID", id);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static ActivityMail ActivityMailParseGet(DataRow row)
        {
            ActivityMail p = new ActivityMail();
            p.ACTIVITYID = new Guid(row["ACTIVITYID"].ToString());
            p.EMAIL = row["EMAIL"].ToString();
            p.NAME = row["NAME"].ToString();
            p.SURNAME = row["SURNAME"].ToString();
            p.IDENTITYNUMBER = row["IDENTITYNUMBER"].ToString();
            p.USERNAME = row["USERNAME"].ToString();
            p.GROUPNAME = row["GROUPNAME"].ToString();

            return p;
        }
        public static List<ActivityMail> ActivityMailListGet(Guid id)
        {
            var table = ActivityMailTableGet(id);
            List<ActivityMail> list = new List<ActivityMail>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(ActivityMailParseGet(row));
            }
            return list;
        }

    }
}
