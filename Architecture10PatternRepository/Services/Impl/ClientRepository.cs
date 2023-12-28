using Architecture10PatternRepository.Models;
using MySqlConnector;

namespace Architecture10PatternRepository.Services.Impl
{
    public class ClientRepository : IClientRepository
    {
        private const string connectionString = "Server=localhost;Port=3306;Database=architecture10patternrepository;User ID=root;Password=123456789Sasha;";

        public int Create(Client item)
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using MySqlCommand command = new MySqlCommand("INSERT INTO clients(Document, SurName, FirstName, Patronymic, Birthday) VALUES(@Document, @SurName, @FirstName, @Patronymic, @Birthday)", connection);
            command.Parameters.AddWithValue("@Document", item.Document);
            command.Parameters.AddWithValue("@SurName", item.SurName);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
            command.Parameters.AddWithValue("@Birthday", item.Birthday);
            command.Prepare();


            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка!!!: {ex.Message}");
                return -1;
            }
        }

        public int Update(Client item)
        {
            using MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using MySqlCommand command =
                new MySqlCommand("UPDATE clients SET Document = @Document, FirstName = @FirstName, SurName = @SurName, Patronymic = @Patronymic, Birthday = @Birthday WHERE ClientId=@ClientId", connection);
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Document", item.Document);
            command.Parameters.AddWithValue("@SurName", item.SurName);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
            command.Parameters.AddWithValue("@Birthday", item.Birthday);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public IList<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            using MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using MySqlCommand command =
                new MySqlCommand("SELECT * FROM clients", connection);
            command.Prepare();
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Client client = new Client();
                client.ClientId = reader.GetInt32(0);
                client.Document = reader.GetString(1);
                client.SurName = reader.GetString(2);
                client.FirstName = reader.GetString(3);
                client.Patronymic = reader.GetString(4);
                client.Birthday = reader.GetDateTime(5);
                list.Add(client);
            }
            return list;
        }

        public Client GetById(int id)
        {
            using MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using MySqlCommand command =
                new MySqlCommand("SELECT * FROM clients WHERE ClientId=@ClientId", connection);
            command.Parameters.AddWithValue("@ClientId", id);
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Client client = new Client();
                client.ClientId = reader.GetInt32(0);
                client.Document = reader.GetString(1);
                client.SurName = reader.GetString(2);
                client.FirstName = reader.GetString(3);
                client.Patronymic = reader.GetString(4);
                client.Birthday = reader.GetDateTime(5);
                return client;
            }
            return null;
        }

        public int Delete(int id)
        {
            using MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using MySqlCommand command =
                new MySqlCommand("DELETE FROM clients WHERE ClientId=@ClientId", connection);
            command.Parameters.AddWithValue("@ClientId", id);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public Client GetBySurName(string surName)
        {
            using MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using MySqlCommand command =
                new MySqlCommand("SELECT * FROM clients WHERE SurName=@SurName", connection);
            command.Parameters.AddWithValue("@SurName", surName);
            command.Prepare();
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Client client = new Client();
                client.ClientId = reader.GetInt32(0);
                client.Document = reader.GetString(1);
                client.SurName = reader.GetString(2);
                client.FirstName = reader.GetString(3);
                client.Patronymic = reader.GetString(4);
                client.Birthday = reader.GetDateTime(5);
                return client;
            }

            return null;

        }

        public int DeleteAll()
        {
            using MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using MySqlCommand command =
                new MySqlCommand("DELETE FROM clients", connection);
            //command.Parameters.AddWithValue("@ClientId", id);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

    }
}
