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
    public class CreateApplicationResponseUnmarshaller
    {
        public static CreateApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationResponse createApplicationResponse = new CreateApplicationResponse();

			createApplicationResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationResponse.Message = _ctx.StringValue("CreateApplication.Message");
			createApplicationResponse.RequestId = _ctx.StringValue("CreateApplication.RequestId");
			createApplicationResponse.TraceId = _ctx.StringValue("CreateApplication.TraceId");
			createApplicationResponse.ErrorCode = _ctx.StringValue("CreateApplication.ErrorCode");
			createApplicationResponse.Code = _ctx.StringValue("CreateApplication.Code");
			createApplicationResponse.Success = _ctx.BooleanValue("CreateApplication.Success");

			CreateApplicationResponse.CreateApplication_Data data = new CreateApplicationResponse.CreateApplication_Data();
			data.AppId = _ctx.StringValue("CreateApplication.Data.AppId");
			data.ChangeOrderId = _ctx.StringValue("CreateApplication.Data.ChangeOrderId");
			createApplicationResponse.Data = data;
        
			return createApplicationResponse;
        }
    }
}
