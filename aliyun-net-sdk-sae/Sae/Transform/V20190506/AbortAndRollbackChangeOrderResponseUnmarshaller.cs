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
    public class AbortAndRollbackChangeOrderResponseUnmarshaller
    {
        public static AbortAndRollbackChangeOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AbortAndRollbackChangeOrderResponse abortAndRollbackChangeOrderResponse = new AbortAndRollbackChangeOrderResponse();

			abortAndRollbackChangeOrderResponse.HttpResponse = _ctx.HttpResponse;
			abortAndRollbackChangeOrderResponse.Code = _ctx.StringValue("AbortAndRollbackChangeOrder.Code");
			abortAndRollbackChangeOrderResponse.ErrorCode = _ctx.StringValue("AbortAndRollbackChangeOrder.ErrorCode");
			abortAndRollbackChangeOrderResponse.Message = _ctx.StringValue("AbortAndRollbackChangeOrder.Message");
			abortAndRollbackChangeOrderResponse.Success = _ctx.BooleanValue("AbortAndRollbackChangeOrder.Success");
			abortAndRollbackChangeOrderResponse.TraceId = _ctx.StringValue("AbortAndRollbackChangeOrder.TraceId");
			abortAndRollbackChangeOrderResponse.RequestId = _ctx.StringValue("AbortAndRollbackChangeOrder.RequestId");

			AbortAndRollbackChangeOrderResponse.AbortAndRollbackChangeOrder_Data data = new AbortAndRollbackChangeOrderResponse.AbortAndRollbackChangeOrder_Data();
			data.ChangeOrderId = _ctx.StringValue("AbortAndRollbackChangeOrder.Data.ChangeOrderId");
			abortAndRollbackChangeOrderResponse.Data = data;
        
			return abortAndRollbackChangeOrderResponse;
        }
    }
}
