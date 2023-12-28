
using Architecture10PatternRepository.Services;
using Architecture10PatternRepository.Services.Impl;
using MySqlConnector;
using MySqlConnector.Logging;

namespace Architecture10PatternRepository
{
    public class Program
    {
        /// <summary>
        /// https://sqlitestudio.pl/
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //ConfigureSqlLiteConnection();
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IClientRepository, ClientRepository>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void ConfigureSqlLiteConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=architecture10patternrepository;User ID=root;Password=123456789Sasha;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                PrepareSchema(connection);
            }
        }

        private static void PrepareSchema(MySqlConnection mySqlConnection)
        {
            using (MySqlCommand mySqlCommand = mySqlConnection.CreateCommand())
            {
                mySqlCommand.CommandText = "DROP TABLE IF EXISTS consultations";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "DROP TABLE IF EXISTS pets";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "DROP TABLE IF EXISTS clients";
                mySqlCommand.ExecuteNonQuery();

                mySqlCommand.CommandText =
                    @"CREATE TABLE Clients(ClientId INT AUTO_INCREMENT PRIMARY KEY,
            Document TEXT,
            SurName TEXT,
            FirstName TEXT,
            Patronymic TEXT,
            Birthday DATE)";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText =
                    @"CREATE TABLE Pets(PetId INT AUTO_INCREMENT PRIMARY KEY,
            ClientId INT,
            Name TEXT,
            Birthday DATE)";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText =
                    @"CREATE TABLE Consultations(ConsultationId INT AUTO_INCREMENT PRIMARY KEY,
            ClientId INT,
            PetId INT,
            ConsultationDate DATE,
            Description TEXT)";
                mySqlCommand.ExecuteNonQuery();
            }

        }
    }
}
