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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class RefundInstanceResponseUnmarshaller
    {
        public static RefundInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RefundInstanceResponse refundInstanceResponse = new RefundInstanceResponse();

			refundInstanceResponse.HttpResponse = _ctx.HttpResponse;
			refundInstanceResponse.Message = _ctx.StringValue("RefundInstance.Message");
			refundInstanceResponse.RequestId = _ctx.StringValue("RefundInstance.RequestId");
			refundInstanceResponse.Code = _ctx.StringValue("RefundInstance.Code");
			refundInstanceResponse.Success = _ctx.BooleanValue("RefundInstance.Success");

			RefundInstanceResponse.RefundInstance_Data data = new RefundInstanceResponse.RefundInstance_Data();
			data.HostId = _ctx.StringValue("RefundInstance.Data.HostId");
			data.OrderId = _ctx.LongValue("RefundInstance.Data.OrderId");
			refundInstanceResponse.Data = data;
        
			return refundInstanceResponse;
        }
    }
}
