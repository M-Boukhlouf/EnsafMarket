﻿using EnsafMarket.Core.Models.Api.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnsafMarket.Core.Models.Api.Responses
{
    public class GetAdvertisementsResponse : BaseResponse
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }

        public int Count { get; set; }
    }
}
