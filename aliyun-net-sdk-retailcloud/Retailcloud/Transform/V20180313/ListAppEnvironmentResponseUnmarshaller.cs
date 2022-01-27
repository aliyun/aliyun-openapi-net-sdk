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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListAppEnvironmentResponseUnmarshaller
    {
        public static ListAppEnvironmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppEnvironmentResponse listAppEnvironmentResponse = new ListAppEnvironmentResponse();

			listAppEnvironmentResponse.HttpResponse = _ctx.HttpResponse;
			listAppEnvironmentResponse.Code = _ctx.IntegerValue("ListAppEnvironment.Code");
			listAppEnvironmentResponse.PageNumber = _ctx.IntegerValue("ListAppEnvironment.PageNumber");
			listAppEnvironmentResponse.RequestId = _ctx.StringValue("ListAppEnvironment.RequestId");
			listAppEnvironmentResponse.PageSize = _ctx.IntegerValue("ListAppEnvironment.PageSize");
			listAppEnvironmentResponse.TotalCount = _ctx.LongValue("ListAppEnvironment.TotalCount");
			listAppEnvironmentResponse.ErrorMsg = _ctx.StringValue("ListAppEnvironment.ErrorMsg");

			List<ListAppEnvironmentResponse.ListAppEnvironment_AppEnvironmentResponse> listAppEnvironmentResponse_data = new List<ListAppEnvironmentResponse.ListAppEnvironment_AppEnvironmentResponse>();
			for (int i = 0; i < _ctx.Length("ListAppEnvironment.Data.Length"); i++) {
				ListAppEnvironmentResponse.ListAppEnvironment_AppEnvironmentResponse appEnvironmentResponse = new ListAppEnvironmentResponse.ListAppEnvironment_AppEnvironmentResponse();
				appEnvironmentResponse.AppId = _ctx.LongValue("ListAppEnvironment.Data["+ i +"].AppId");
				appEnvironmentResponse.EnvId = _ctx.LongValue("ListAppEnvironment.Data["+ i +"].EnvId");
				appEnvironmentResponse.EnvName = _ctx.StringValue("ListAppEnvironment.Data["+ i +"].EnvName");
				appEnvironmentResponse.EnvType = _ctx.IntegerValue("ListAppEnvironment.Data["+ i +"].EnvType");
				appEnvironmentResponse.EnvTypeName = _ctx.StringValue("ListAppEnvironment.Data["+ i +"].EnvTypeName");
				appEnvironmentResponse.AppSchemaId = _ctx.LongValue("ListAppEnvironment.Data["+ i +"].AppSchemaId");
				appEnvironmentResponse.Region = _ctx.StringValue("ListAppEnvironment.Data["+ i +"].Region");

				listAppEnvironmentResponse_data.Add(appEnvironmentResponse);
			}
			listAppEnvironmentResponse.Data = listAppEnvironmentResponse_data;
        
			return listAppEnvironmentResponse;
        }
    }
}
