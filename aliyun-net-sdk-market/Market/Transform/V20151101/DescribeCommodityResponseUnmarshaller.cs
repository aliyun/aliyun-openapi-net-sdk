/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeCommodityResponseUnmarshaller
    {
        public static DescribeCommodityResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCommodityResponse describeCommodityResponse = new DescribeCommodityResponse();

			describeCommodityResponse.HttpResponse = context.HttpResponse;
			describeCommodityResponse.RequestId = context.StringValue("DescribeCommodity.RequestId");
			describeCommodityResponse.Success = context.BooleanValue("DescribeCommodity.Success");

			DescribeCommodityResponse.DescribeCommodity_Commodity commodity = new DescribeCommodityResponse.DescribeCommodity_Commodity();
			commodity.CommodityId = context.StringValue("DescribeCommodity.Commodity.CommodityId");
			commodity.Properties = context.StringValue("DescribeCommodity.Commodity.Properties");
			commodity.CommoditySpecs = context.StringValue("DescribeCommodity.Commodity.CommoditySpecs");
			commodity.ApplicationId = context.StringValue("DescribeCommodity.Commodity.ApplicationId");
			describeCommodityResponse.Commodity = commodity;
        
			return describeCommodityResponse;
        }
    }
}
