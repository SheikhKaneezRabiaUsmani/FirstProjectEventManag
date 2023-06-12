using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Event.DAL.Repositories;
using Event.DOM;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;


namespace Event.DAL.Repository
{
    public class VenueRepository : BaseRepository, IVenueRepository
    {
        IConfiguration _configuration;
        public VenueRepository(IConfiguration configuration) : base(configuration)
        {
            this. _configuration = configuration;
        }

        public List<Venue> ShowVenue()
        {
            IDbConnection dbconnection = new SqlConnection(_configuration.GetConnectionString("sql connection"));
            using (var connection = CreateConnection()) ;
            {
                var sql = "select * from Venue";
                List<Venue> venues = (List<Venue>)dbconnection.Query<Venue>(sql);
                return venues;
            }
        }
    }
}
    
            

    
   

  
