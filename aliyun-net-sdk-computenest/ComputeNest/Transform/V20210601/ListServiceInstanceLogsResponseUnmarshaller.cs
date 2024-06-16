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
using Aliyun.Acs.ComputeNest.Model.V20210601;

namespace Aliyun.Acs.ComputeNest.Transform.V20210601
{
    public class ListServiceInstanceLogsResponseUnmarshaller
    {
        public static ListServiceInstanceLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServiceInstanceLogsResponse listServiceInstanceLogsResponse = new ListServiceInstanceLogsResponse();

			listServiceInstanceLogsResponse.HttpResponse = _ctx.HttpResponse;
			listServiceInstanceLogsResponse.NextToken = _ctx.StringValue("ListServiceInstanceLogs.NextToken");
			listServiceInstanceLogsResponse.RequestId = _ctx.StringValue("ListServiceInstanceLogs.RequestId");
			listServiceInstanceLogsResponse.MaxResults = _ctx.IntegerValue("ListServiceInstanceLogs.MaxResults");

			List<ListServiceInstanceLogsResponse.ListServiceInstanceLogs_ServiceInstanceLogs> listServiceInstanceLogsResponse_serviceInstancesLogs = new List<ListServiceInstanceLogsResponse.ListServiceInstanceLogs_ServiceInstanceLogs>();
			for (int i = 0; i < _ctx.Length("ListServiceInstanceLogs.ServiceInstancesLogs.Length"); i++) {
				ListServiceInstanceLogsResponse.ListServiceInstanceLogs_ServiceInstanceLogs serviceInstanceLogs = new ListServiceInstanceLogsResponse.ListServiceInstanceLogs_ServiceInstanceLogs();
				serviceInstanceLogs.Timestamp = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].Timestamp");
				serviceInstanceLogs.Source = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].Source");
				serviceInstanceLogs.Content = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].Content");
				serviceInstanceLogs.LogType = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].LogType");
				serviceInstanceLogs.ResourceType = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].ResourceType");
				serviceInstanceLogs.ResourceId = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].ResourceId");
				serviceInstanceLogs.Status = _ctx.StringValue("ListServiceInstanceLogs.ServiceInstancesLogs["+ i +"].Status");

				listServiceInstanceLogsResponse_serviceInstancesLogs.Add(serviceInstanceLogs);
			}
			listServiceInstanceLogsResponse.ServiceInstancesLogs = listServiceInstanceLogsResponse_serviceInstancesLogs;
        
			return listServiceInstanceLogsResponse;
        }
    }
}
