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
    public class RenewInstanceResponseUnmarshaller
    {
        public static RenewInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RenewInstanceResponse renewInstanceResponse = new RenewInstanceResponse();

			renewInstanceResponse.HttpResponse = _ctx.HttpResponse;
			renewInstanceResponse.RequestId = _ctx.StringValue("RenewInstance.RequestId");
			renewInstanceResponse.Success = _ctx.BooleanValue("RenewInstance.Success");
			renewInstanceResponse.Code = _ctx.StringValue("RenewInstance.Code");
			renewInstanceResponse.Message = _ctx.StringValue("RenewInstance.Message");

			RenewInstanceResponse.RenewInstance_Data data = new RenewInstanceResponse.RenewInstance_Data();
			data.OrderId = _ctx.StringValue("RenewInstance.Data.OrderId");
			renewInstanceResponse.Data = data;
        
			return renewInstanceResponse;
        }
    }
}
