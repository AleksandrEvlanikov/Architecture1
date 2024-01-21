using Architecture10PatternRepository.Controllers;
using Architecture10PatternRepository.Models;
using Architecture10PatternRepository.Models.Requests;
using Architecture10PatternRepository.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Architecture12ClinicServisUnitTest
{
    public class ClientControllerUnitTest
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mockClientRepository;

        public ClientControllerUnitTest()
        {
            _mockClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mockClientRepository.Object);
        }


        [Fact]
        public void GetAllClientsTest()
        {
            // [1] ���������� ������ ��� ������������

            List<Client> clientsList = new List<Client>();
            clientsList.Add(new Client());
            clientsList.Add(new Client());
            clientsList.Add(new Client());

            _mockClientRepository
                .Setup(repository => repository.GetAll())
                .Returns(clientsList);

            // [2] ���������� ������������ ������


            var operationResult = _clientController.GetAll();

            // [3] ���������� ���������� ���������� � �������� ����������
            Assert.IsType<OkObjectResult>(operationResult.Result);

            var result = (OkObjectResult)operationResult.Result;
            Assert.IsAssignableFrom<List<Client>>(result.Value);

            _mockClientRepository.Verify(repository =>
            repository.GetAll(), Times.AtLeastOnce);

        }


        public static object[][] CorrectCreateClientData =
{
            new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������1", "���������1", "���������1" },
            new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������2", "���������2", "���������2" },
            //new object[] { new DateTime(2013, 1, 22), "AA1 B11222", "������3", "���������3", "���������3" },
            new object[] { new DateTime(2018, 1, 22), "AA1 B11222", "������4", "���������4", "���������4" },
            new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������5", "���������5", "���������5" },
            //new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������", "", "���������" },
            new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������6", "���������6", "���������6" },
            new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������7", "���������7", "���������7" },
            new object[] { new DateTime(1986, 1, 22), "AA1 B11222", "������8", "���������8", "���������8" },

        };

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void CreateClientTest(
            DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            // [1] ���������� ������ ��� ������������

            CreateClientRequest createClientRequest = new CreateClientRequest();
            createClientRequest.Birthday = birthday;
            createClientRequest.Document = document;
            createClientRequest.SurName = surName;
            createClientRequest.FirstName = firstName;
            createClientRequest.Patronymic = patronymic;

            int res = 1;

            _mockClientRepository
                .Setup(repository => repository.Create(It.IsNotNull<Client>()))
                .Returns(res);


            // [2] ���������� ������������ ������
            var operationResult = _clientController.Create(createClientRequest);

            // [3] ���������� ���������� ���������� � �������� ����������
            Assert.IsType<OkObjectResult>(operationResult.Result);

            var result = (OkObjectResult)operationResult.Result;
            Assert.IsAssignableFrom<int>(result.Value);

            _mockClientRepository.Verify(repository =>
            repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        [Fact]
        public void DeleteAllClientTest()
        {
            // [1] ���������� ������ ��� ������������
            Client client = new Client();

            List<Client> clientsList = new List<Client>();
            clientsList.Add(new Client());
            clientsList.Add(new Client());
            clientsList.Add(new Client());

            int res = 1;
            _mockClientRepository
                .Setup(repository => repository.DeleteAll())
                .Callback(() => clientsList.RemoveAll(client => true))
                .Returns(res);

            // [2] ���������� ������������ ������
            var operationResult = _clientController.DeleteAll();


            // [3] ���������� ���������� ���������� � �������� ����������
            
            Assert.IsType<OkObjectResult>(operationResult.Result);

            
            var result = (OkObjectResult)operationResult.Result;
            //Assert.IsAssignableFrom<int>(result.Value);

            Assert.Equal(res, result.Value); // ����� ������������ Equal � ����� IsAssignableFrom
            Assert.Empty(clientsList); // ����� ��������� �� ������ ����.

            _mockClientRepository.Verify(repository =>
            repository.DeleteAll(), Times.AtLeastOnce());
        }

        [Fact]
        public void DeleteOneClientsTest()
        {
            // [1] ���������� ������ ��� ������������
            Client client = new Client();
            List<Client> clientsList = new List<Client>();
            clientsList.Add(new Client(0, "1234 56543", "Ivanov", "Ivan", "Ivanov", new DateTime(1986, 1, 22)));
            clientsList.Add(new Client(1, "1234 56543", "Petrov", "Petr", "Petrovih", new DateTime(1989, 3, 11)));
            clientsList.Add(new Client(2, "1234 56543", "Vagonodova", "Irina", "Vivitova", new DateTime(1981, 4, 28)));


            int res = 1;
            int delID = 2;
            _mockClientRepository
                .Setup(repository => repository.Delete(delID))
                .Callback<int>(id => clientsList.RemoveAll(client => client.ClientId == id))
                .Returns(res);

            // [2] ���������� ������������ ������
            var operationResult = _clientController.Delete(delID);


            // [3] ���������� ���������� ���������� � �������� ����������

            Assert.IsType<OkObjectResult>(operationResult.Result);


            var result = (OkObjectResult)operationResult.Result;
            Assert.IsAssignableFrom<int>(result.Value);

            Assert.DoesNotContain(clientsList, client => client.ClientId == delID);
            //Assert.Equal(2, clientsList.Count);


            _mockClientRepository.Verify(repository =>
            repository.Delete(It.IsAny<int>()), Times.AtLeastOnce());
        }

        [Fact]
        public void UpdateDataClientTest()
        {
            // [1] ���������� ������ ��� ������������
            Client client = new Client();
            List<Client> clientsList = new List<Client>();
            clientsList.Add(new Client(0, "1234 56543", "Ivanov", "Ivan", "Ivanov", new DateTime(1986, 1, 22)));
            clientsList.Add(new Client(1, "1234 56543", "Petrov", "Petr", "Petrovih", new DateTime(1989, 3, 11)));
            clientsList.Add(new Client(2, "1234 56543", "Vagonodova", "Irina", "Vivitova", new DateTime(1981, 4, 28)));

            UpdateClientRequest updateClientRequest = new UpdateClientRequest
            {
                ClientId = 2,
                Document = "23423 232423",
                SurName = "Petrova",
                FirstName = "Irina",
                Patronymic = "Vivitova",
                Birthday = new DateTime(1990, 5, 15)
            };


            int res = 1;
            //int updateID = 2;
            _mockClientRepository
                .Setup(repository => repository.Update(It.IsAny<Client>()))
                .Callback<Client>(updateClient =>
                {
                     var firstDateClient = clientsList.FirstOrDefault(c => c.ClientId == updateClientRequest.ClientId);
                    firstDateClient.SurName = updateClient.SurName;
                    firstDateClient.Document = updateClient.Document;
                    firstDateClient.Birthday = updateClient.Birthday;
                })
                .Returns(res);

            // [2] ���������� ������������ ������
            var operationResult = _clientController.Update(updateClientRequest);
            var firstDateClient = clientsList.FirstOrDefault(c => c.ClientId == updateClientRequest.ClientId);


            // [3] ���������� ���������� ���������� � �������� ����������
            Assert.IsType<OkObjectResult>(operationResult.Result);

            var result = (OkObjectResult)operationResult.Result;
            Assert.IsAssignableFrom<int>(result.Value);

            Assert.Equal(updateClientRequest.SurName, firstDateClient.SurName);
            Assert.Equal(updateClientRequest.Document, firstDateClient.Document);
            Assert.Equal(updateClientRequest.Birthday, firstDateClient.Birthday);

            _mockClientRepository.Verify(repository =>
            repository.Update(It.IsAny<Client>()), Times.AtLeastOnce());
        }
    }
}