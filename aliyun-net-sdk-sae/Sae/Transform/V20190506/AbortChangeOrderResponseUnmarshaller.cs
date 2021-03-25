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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class AbortChangeOrderResponseUnmarshaller
    {
        public static AbortChangeOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AbortChangeOrderResponse abortChangeOrderResponse = new AbortChangeOrderResponse();

			abortChangeOrderResponse.HttpResponse = _ctx.HttpResponse;
			abortChangeOrderResponse.Code = _ctx.StringValue("AbortChangeOrder.Code");
			abortChangeOrderResponse.ErrorCode = _ctx.StringValue("AbortChangeOrder.ErrorCode");
			abortChangeOrderResponse.Message = _ctx.StringValue("AbortChangeOrder.Message");
			abortChangeOrderResponse.Success = _ctx.BooleanValue("AbortChangeOrder.Success");
			abortChangeOrderResponse.TraceId = _ctx.StringValue("AbortChangeOrder.TraceId");
			abortChangeOrderResponse.RequestId = _ctx.StringValue("AbortChangeOrder.RequestId");

			AbortChangeOrderResponse.AbortChangeOrder_Data data = new AbortChangeOrderResponse.AbortChangeOrder_Data();
			data.ChangeOrderId = _ctx.StringValue("AbortChangeOrder.Data.ChangeOrderId");
			abortChangeOrderResponse.Data = data;
        
			return abortChangeOrderResponse;
        }
    }
}
