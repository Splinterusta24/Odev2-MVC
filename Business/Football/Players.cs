using Odev2_MVC.DAL;
using Odev2_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Odev2_MVC.Business.Football
{
    public class Players : Base, Imethod1, Imethod2
    {
        SqlProcess process = new SqlProcess();
        DataTable data = new DataTable();
      
        public void Ekle()
        {
            process.SetExecuteNonQuery("Insert into FootballPlayers (NameSurname,Salary,MatchPosition,ContractDeadline,SportsgearNo,Age) values (@name,@salary,@position,@contract,@sportsno,@age)",
                new SqlParameter("@name",NameSurname),
                new SqlParameter("@salary",Salary),
                new SqlParameter("@position",MatchPosition),
                new SqlParameter("@contract",ContractDeadline),
                new SqlParameter("@sportsno",SportsgearNo),
                new SqlParameter("@age",Age)
                );   
        }

        public void Getir()
        {
            //data = process.SetExecuteReader("")

        }

        public void Guncelle()
        {
            throw new NotImplementedException();
        }

        public void MaasOde()
        {
            throw new NotImplementedException();
        }

        public void Prim()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }
    }
}