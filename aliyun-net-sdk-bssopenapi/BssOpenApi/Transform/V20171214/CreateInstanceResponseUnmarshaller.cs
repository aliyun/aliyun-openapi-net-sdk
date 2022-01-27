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
    public class CreateInstanceResponseUnmarshaller
    {
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createInstanceResponse.RequestId = _ctx.StringValue("CreateInstance.RequestId");
			createInstanceResponse.Success = _ctx.BooleanValue("CreateInstance.Success");
			createInstanceResponse.Code = _ctx.StringValue("CreateInstance.Code");
			createInstanceResponse.Message = _ctx.StringValue("CreateInstance.Message");

			CreateInstanceResponse.CreateInstance_Data data = new CreateInstanceResponse.CreateInstance_Data();
			data.InstanceId = _ctx.StringValue("CreateInstance.Data.InstanceId");
			data.OrderId = _ctx.StringValue("CreateInstance.Data.OrderId");
			createInstanceResponse.Data = data;
        
			return createInstanceResponse;
        }
    }
}
