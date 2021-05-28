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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribePayAsYouGoPriceResponseUnmarshaller
    {
        public static DescribePayAsYouGoPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePayAsYouGoPriceResponse describePayAsYouGoPriceResponse = new DescribePayAsYouGoPriceResponse();

			describePayAsYouGoPriceResponse.HttpResponse = _ctx.HttpResponse;
			describePayAsYouGoPriceResponse.RequestId = _ctx.StringValue("DescribePayAsYouGoPrice.RequestId");
			describePayAsYouGoPriceResponse.Success = _ctx.BooleanValue("DescribePayAsYouGoPrice.Success");
			describePayAsYouGoPriceResponse.Code = _ctx.StringValue("DescribePayAsYouGoPrice.Code");
			describePayAsYouGoPriceResponse.Message = _ctx.StringValue("DescribePayAsYouGoPrice.Message");
			describePayAsYouGoPriceResponse.Currency = _ctx.StringValue("DescribePayAsYouGoPrice.Currency");
			describePayAsYouGoPriceResponse.GatewayClassPrice = _ctx.FloatValue("DescribePayAsYouGoPrice.GatewayClassPrice");
			describePayAsYouGoPriceResponse.CacheCloudEfficiencySizePrice = _ctx.FloatValue("DescribePayAsYouGoPrice.CacheCloudEfficiencySizePrice");
			describePayAsYouGoPriceResponse.CacheCloudSSDSizePrice = _ctx.FloatValue("DescribePayAsYouGoPrice.CacheCloudSSDSizePrice");
        
			return describePayAsYouGoPriceResponse;
        }
    }
}
