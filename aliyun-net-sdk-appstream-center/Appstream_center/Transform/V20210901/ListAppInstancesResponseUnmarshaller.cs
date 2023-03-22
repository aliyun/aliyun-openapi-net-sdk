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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class ListAppInstancesResponseUnmarshaller
    {
        public static ListAppInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppInstancesResponse listAppInstancesResponse = new ListAppInstancesResponse();

			listAppInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listAppInstancesResponse.RequestId = _ctx.StringValue("ListAppInstances.RequestId");
			listAppInstancesResponse.TotalCount = _ctx.IntegerValue("ListAppInstances.TotalCount");
			listAppInstancesResponse.PageSize = _ctx.IntegerValue("ListAppInstances.PageSize");
			listAppInstancesResponse.PageNumber = _ctx.IntegerValue("ListAppInstances.PageNumber");

			List<ListAppInstancesResponse.ListAppInstances_Data> listAppInstancesResponse_appInstanceModels = new List<ListAppInstancesResponse.ListAppInstances_Data>();
			for (int i = 0; i < _ctx.Length("ListAppInstances.AppInstanceModels.Length"); i++) {
				ListAppInstancesResponse.ListAppInstances_Data data = new ListAppInstancesResponse.ListAppInstances_Data();
				data.AppInstanceId = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].AppInstanceId");
				data.AppInstanceGroupId = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].AppInstanceGroupId");
				data.Status = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].Status");
				data.MainEthPublicIp = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].MainEthPublicIp");
				data.GmtCreate = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].GmtCreate");
				data.GmtModified = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].GmtModified");
				data.SessionStatus = _ctx.StringValue("ListAppInstances.AppInstanceModels["+ i +"].SessionStatus");

				listAppInstancesResponse_appInstanceModels.Add(data);
			}
			listAppInstancesResponse.AppInstanceModels = listAppInstancesResponse_appInstanceModels;
        
			return listAppInstancesResponse;
        }
    }
}
