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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class CreateDataCorrectOrderResponseUnmarshaller
    {
        public static CreateDataCorrectOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDataCorrectOrderResponse createDataCorrectOrderResponse = new CreateDataCorrectOrderResponse();

			createDataCorrectOrderResponse.HttpResponse = _ctx.HttpResponse;
			createDataCorrectOrderResponse.RequestId = _ctx.StringValue("CreateDataCorrectOrder.RequestId");
			createDataCorrectOrderResponse.Success = _ctx.BooleanValue("CreateDataCorrectOrder.Success");
			createDataCorrectOrderResponse.ErrorMessage = _ctx.StringValue("CreateDataCorrectOrder.ErrorMessage");
			createDataCorrectOrderResponse.ErrorCode = _ctx.StringValue("CreateDataCorrectOrder.ErrorCode");

			List<string> createDataCorrectOrderResponse_createOrderResult = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateDataCorrectOrder.CreateOrderResult.Length"); i++) {
				createDataCorrectOrderResponse_createOrderResult.Add(_ctx.StringValue("CreateDataCorrectOrder.CreateOrderResult["+ i +"]"));
			}
			createDataCorrectOrderResponse.CreateOrderResult = createDataCorrectOrderResponse_createOrderResult;
        
			return createDataCorrectOrderResponse;
        }
    }
}
