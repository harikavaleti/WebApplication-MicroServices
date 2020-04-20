﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Infrastructure;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class EventService : IEventService
    {
        private readonly string _baseUri;
        private readonly IHttpClient _client;
        public EventService(IConfiguration config, IHttpClient client)
        {
            _baseUri = $"{config["EventCatalogUrl"]}/api/event/";
            _client = client;
        }
        public async Task<Event> GetEventItemsAsync(int page, int size)
        {

           var eventItemsUri = ApiPaths.Catalog.GetAllCatalogItems(_baseUri, page, size);

           string datastring = await _client.GetStringAsync(eventItemsUri);

            return JsonConvert.DeserializeObject<Event>(datastring);

        }
    }
}
