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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterServiceResponseUnmarshaller
    {
        public static ListClusterServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterServiceResponse listClusterServiceResponse = new ListClusterServiceResponse();

			listClusterServiceResponse.HttpResponse = _ctx.HttpResponse;
			listClusterServiceResponse.RequestId = _ctx.StringValue("ListClusterService.RequestId");
			listClusterServiceResponse.TotalCount = _ctx.IntegerValue("ListClusterService.TotalCount");
			listClusterServiceResponse.PageNumber = _ctx.IntegerValue("ListClusterService.PageNumber");
			listClusterServiceResponse.PageSize = _ctx.IntegerValue("ListClusterService.PageSize");

			List<ListClusterServiceResponse.ListClusterService_ClusterService> listClusterServiceResponse_clusterServiceList = new List<ListClusterServiceResponse.ListClusterService_ClusterService>();
			for (int i = 0; i < _ctx.Length("ListClusterService.ClusterServiceList.Length"); i++) {
				ListClusterServiceResponse.ListClusterService_ClusterService clusterService = new ListClusterServiceResponse.ListClusterService_ClusterService();
				clusterService.ServiceName = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceName");
				clusterService.ServiceDisplayName = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceDisplayName");
				clusterService.ServiceVersion = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceVersion");
				clusterService.InstallStatus = _ctx.BooleanValue("ListClusterService.ClusterServiceList["+ i +"].InstallStatus");
				clusterService.ClientType = _ctx.BooleanValue("ListClusterService.ClusterServiceList["+ i +"].ClientType");
				clusterService.ServiceStatus = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceStatus");
				clusterService.HealthStatus = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].HealthStatus");
				clusterService.NeedRestartInfo = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].NeedRestartInfo");
				clusterService.NotStartInfo = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].NotStartInfo");
				clusterService.AbnormalNum = _ctx.IntegerValue("ListClusterService.ClusterServiceList["+ i +"].AbnormalNum");
				clusterService.StoppedNum = _ctx.IntegerValue("ListClusterService.ClusterServiceList["+ i +"].StoppedNum");
				clusterService.NeedRestartNum = _ctx.IntegerValue("ListClusterService.ClusterServiceList["+ i +"].NeedRestartNum");

				List<ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction> clusterService_serviceActionList = new List<ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction>();
				for (int j = 0; j < _ctx.Length("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList.Length"); j++) {
					ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction serviceAction = new ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction();
					serviceAction.ServiceName = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].ServiceName");
					serviceAction.ComponentName = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].ComponentName");
					serviceAction.ActionName = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].ActionName");
					serviceAction.Command = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].Command");
					serviceAction.DisplayName = _ctx.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].DisplayName");

					clusterService_serviceActionList.Add(serviceAction);
				}
				clusterService.ServiceActionList = clusterService_serviceActionList;

				listClusterServiceResponse_clusterServiceList.Add(clusterService);
			}
			listClusterServiceResponse.ClusterServiceList = listClusterServiceResponse_clusterServiceList;
        
			return listClusterServiceResponse;
        }
    }
}
