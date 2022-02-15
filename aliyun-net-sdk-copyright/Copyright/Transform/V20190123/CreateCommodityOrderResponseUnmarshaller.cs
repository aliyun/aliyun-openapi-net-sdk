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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class CreateCommodityOrderResponseUnmarshaller
    {
        public static CreateCommodityOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateCommodityOrderResponse createCommodityOrderResponse = new CreateCommodityOrderResponse();

			createCommodityOrderResponse.HttpResponse = _ctx.HttpResponse;
			createCommodityOrderResponse.RequestId = _ctx.StringValue("CreateCommodityOrder.RequestId");

			List<string> createCommodityOrderResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateCommodityOrder.Data.Length"); i++) {
				createCommodityOrderResponse_data.Add(_ctx.StringValue("CreateCommodityOrder.Data["+ i +"]"));
			}
			createCommodityOrderResponse.Data = createCommodityOrderResponse_data;
        
			return createCommodityOrderResponse;
        }
    }
}
