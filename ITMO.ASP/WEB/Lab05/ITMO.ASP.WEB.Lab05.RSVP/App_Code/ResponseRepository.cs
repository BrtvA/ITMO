﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.WEB.Lab05.RSVP
{
    public class ResponseRepository
    {
        public static ResponseRepository repository = new ResponseRepository();
        private List<GuestResponse> responses = new List<GuestResponse>();
        public static ResponseRepository GetRepository()
        {
            return repository;
        }
        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }
        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}