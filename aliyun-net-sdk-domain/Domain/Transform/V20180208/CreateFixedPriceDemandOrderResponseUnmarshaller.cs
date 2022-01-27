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
using Aliyun.Acs.Domain.Model.V20180208;

namespace Aliyun.Acs.Domain.Transform.V20180208
{
    public class CreateFixedPriceDemandOrderResponseUnmarshaller
    {
        public static CreateFixedPriceDemandOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFixedPriceDemandOrderResponse createFixedPriceDemandOrderResponse = new CreateFixedPriceDemandOrderResponse();

			createFixedPriceDemandOrderResponse.HttpResponse = _ctx.HttpResponse;
			createFixedPriceDemandOrderResponse.RequestId = _ctx.StringValue("CreateFixedPriceDemandOrder.RequestId");
			createFixedPriceDemandOrderResponse.HttpStatusCode = _ctx.IntegerValue("CreateFixedPriceDemandOrder.HttpStatusCode");
			createFixedPriceDemandOrderResponse.ErrorCode = _ctx.StringValue("CreateFixedPriceDemandOrder.ErrorCode");
			createFixedPriceDemandOrderResponse.Success = _ctx.BooleanValue("CreateFixedPriceDemandOrder.Success");

			CreateFixedPriceDemandOrderResponse.CreateFixedPriceDemandOrder_Module module = new CreateFixedPriceDemandOrderResponse.CreateFixedPriceDemandOrder_Module();
			module.OrderNo = _ctx.StringValue("CreateFixedPriceDemandOrder.Module.OrderNo");
			module.Price = _ctx.LongValue("CreateFixedPriceDemandOrder.Module.Price");
			module.Domain = _ctx.StringValue("CreateFixedPriceDemandOrder.Module.Domain");
			createFixedPriceDemandOrderResponse.Module = module;
        
			return createFixedPriceDemandOrderResponse;
        }
    }
}
