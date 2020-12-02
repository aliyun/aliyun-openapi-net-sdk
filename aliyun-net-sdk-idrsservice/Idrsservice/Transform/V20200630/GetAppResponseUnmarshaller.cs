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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetAppResponseUnmarshaller
    {
        public static GetAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAppResponse getAppResponse = new GetAppResponse();

			getAppResponse.HttpResponse = _ctx.HttpResponse;
			getAppResponse.Code = _ctx.StringValue("GetApp.Code");
			getAppResponse.Message = _ctx.StringValue("GetApp.Message");
			getAppResponse.RequestId = _ctx.StringValue("GetApp.RequestId");

			GetAppResponse.GetApp_Data data = new GetAppResponse.GetApp_Data();
			data.CreatedAt = _ctx.IntegerValue("GetApp.Data.CreatedAt");
			data.Disabled = _ctx.StringValue("GetApp.Data.Disabled");
			data.Name = _ctx.StringValue("GetApp.Data.Name");
			getAppResponse.Data = data;
        
			return getAppResponse;
        }
    }
}
