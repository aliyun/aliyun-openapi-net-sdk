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
    public class ListClusterInstalledServiceResponseUnmarshaller
    {
        public static ListClusterInstalledServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterInstalledServiceResponse listClusterInstalledServiceResponse = new ListClusterInstalledServiceResponse();

			listClusterInstalledServiceResponse.HttpResponse = _ctx.HttpResponse;
			listClusterInstalledServiceResponse.RequestId = _ctx.StringValue("ListClusterInstalledService.RequestId");

			List<ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService> listClusterInstalledServiceResponse_clusterInstalledServiceList = new List<ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService>();
			for (int i = 0; i < _ctx.Length("ListClusterInstalledService.ClusterInstalledServiceList.Length"); i++) {
				ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService clusterInstalledService = new ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService();
				clusterInstalledService.ServiceName = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceName");
				clusterInstalledService.ServiceDisplayName = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceDisplayName");
				clusterInstalledService.ServiceVersion = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceVersion");
				clusterInstalledService.ServiceEcmVersion = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceEcmVersion");
				clusterInstalledService.ServiceStatus = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].serviceStatus");
				clusterInstalledService.OnlyClient = _ctx.BooleanValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].onlyClient");
				clusterInstalledService.NotStartedNum = _ctx.IntegerValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].notStartedNum");
				clusterInstalledService.NeedRestartNum = _ctx.IntegerValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].needRestartNum");
				clusterInstalledService.AbnormalNum = _ctx.IntegerValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].abnormalNum");
				clusterInstalledService.Comment = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].comment");

				List<ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService.ListClusterInstalledService_ServiceAction> clusterInstalledService_serviceActionList = new List<ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService.ListClusterInstalledService_ServiceAction>();
				for (int j = 0; j < _ctx.Length("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceActionList.Length"); j++) {
					ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService.ListClusterInstalledService_ServiceAction serviceAction = new ListClusterInstalledServiceResponse.ListClusterInstalledService_ClusterInstalledService.ListClusterInstalledService_ServiceAction();
					serviceAction.ServiceName = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceActionList["+ j +"].ServiceName");
					serviceAction.ComponentName = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceActionList["+ j +"].ComponentName");
					serviceAction.ActionName = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceActionList["+ j +"].ActionName");
					serviceAction.Command = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceActionList["+ j +"].Command");
					serviceAction.DisplayName = _ctx.StringValue("ListClusterInstalledService.ClusterInstalledServiceList["+ i +"].ServiceActionList["+ j +"].DisplayName");

					clusterInstalledService_serviceActionList.Add(serviceAction);
				}
				clusterInstalledService.ServiceActionList = clusterInstalledService_serviceActionList;

				listClusterInstalledServiceResponse_clusterInstalledServiceList.Add(clusterInstalledService);
			}
			listClusterInstalledServiceResponse.ClusterInstalledServiceList = listClusterInstalledServiceResponse_clusterInstalledServiceList;
        
			return listClusterInstalledServiceResponse;
        }
    }
}
