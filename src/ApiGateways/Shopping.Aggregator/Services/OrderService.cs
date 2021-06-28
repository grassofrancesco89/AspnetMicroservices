using Shopping.Aggregator.Extensions;
using Shopping.Aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services
{
    public class OrderService: IOrderService
    {
        private readonly HttpClient _client;
        private readonly string orderV1 = "/api/v1/Order";

        public OrderService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName)
        {
            var response = await _client.GetAsync($"{orderV1}/{userName}");
            return await response.ReadContentAs<List<OrderResponseModel>>();
        }
    }
}
