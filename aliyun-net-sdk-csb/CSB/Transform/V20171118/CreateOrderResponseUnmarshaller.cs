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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class CreateOrderResponseUnmarshaller
    {
        public static CreateOrderResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOrderResponse createOrderResponse = new CreateOrderResponse();

			createOrderResponse.HttpResponse = context.HttpResponse;
			createOrderResponse.Code = context.IntegerValue("CreateOrder.Code");
			createOrderResponse.Message = context.StringValue("CreateOrder.Message");
			createOrderResponse.RequestId = context.StringValue("CreateOrder.RequestId");

			CreateOrderResponse.CreateOrder_Data data = new CreateOrderResponse.CreateOrder_Data();
			data.Id = context.LongValue("CreateOrder.Data.Id");
			createOrderResponse.Data = data;
        
			return createOrderResponse;
        }
    }
}