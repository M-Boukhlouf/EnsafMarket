﻿using EnsafMarket.Core.Models.Api.Requests.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnsafMarket.Core.Models.Api.Requests
{
    public class GetSimilarAdvertisementsRequest : BaseRequest
    {
        public int? Count { get; set; }
    }
}
