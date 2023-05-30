using UserService.Messaging.Interfaces;
using UserService.Models;
using UserService.Services.Interfaces;

namespace UserService.Services
{
    public class UserServices : IUserServices
    {
        private readonly IKafkaController _kafkaController;

        public UserServices(IKafkaController kafkaController)
        {
            _kafkaController = kafkaController;
        }

        public async Task<string> deleteUser(UserBody userBody)
        {
            try
            {
                await _kafkaController.ProduceAsync("DELETE_USER", Newtonsoft.Json.JsonConvert.SerializeObject(userBody));
                return "User has been deleted";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
