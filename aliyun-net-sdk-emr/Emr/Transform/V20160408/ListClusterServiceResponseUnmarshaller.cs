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
        public static ListClusterServiceResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterServiceResponse listClusterServiceResponse = new ListClusterServiceResponse();

			listClusterServiceResponse.HttpResponse = context.HttpResponse;
			listClusterServiceResponse.RequestId = context.StringValue("ListClusterService.RequestId");
			listClusterServiceResponse.TotalCount = context.IntegerValue("ListClusterService.TotalCount");
			listClusterServiceResponse.PageNumber = context.IntegerValue("ListClusterService.PageNumber");
			listClusterServiceResponse.PageSize = context.IntegerValue("ListClusterService.PageSize");

			List<ListClusterServiceResponse.ListClusterService_ClusterService> listClusterServiceResponse_clusterServiceList = new List<ListClusterServiceResponse.ListClusterService_ClusterService>();
			for (int i = 0; i < context.Length("ListClusterService.ClusterServiceList.Length"); i++) {
				ListClusterServiceResponse.ListClusterService_ClusterService clusterService = new ListClusterServiceResponse.ListClusterService_ClusterService();
				clusterService.ServiceName = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceName");
				clusterService.ServiceDisplayName = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceDisplayName");
				clusterService.ServiceVersion = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceVersion");
				clusterService.InstallStatus = context.BooleanValue("ListClusterService.ClusterServiceList["+ i +"].InstallStatus");
				clusterService.ClientType = context.BooleanValue("ListClusterService.ClusterServiceList["+ i +"].ClientType");
				clusterService.ServiceStatus = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceStatus");
				clusterService.HealthStatus = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].HealthStatus");
				clusterService.NeedRestartInfo = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].NeedRestartInfo");
				clusterService.NotStartInfo = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].NotStartInfo");
				clusterService.AbnormalNum = context.IntegerValue("ListClusterService.ClusterServiceList["+ i +"].AbnormalNum");
				clusterService.StoppedNum = context.IntegerValue("ListClusterService.ClusterServiceList["+ i +"].StoppedNum");
				clusterService.NeedRestartNum = context.IntegerValue("ListClusterService.ClusterServiceList["+ i +"].NeedRestartNum");

				List<ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction> clusterService_serviceActionList = new List<ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction>();
				for (int j = 0; j < context.Length("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList.Length"); j++) {
					ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction serviceAction = new ListClusterServiceResponse.ListClusterService_ClusterService.ListClusterService_ServiceAction();
					serviceAction.ServiceName = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].ServiceName");
					serviceAction.ComponentName = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].ComponentName");
					serviceAction.ActionName = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].ActionName");
					serviceAction.Command = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].Command");
					serviceAction.DisplayName = context.StringValue("ListClusterService.ClusterServiceList["+ i +"].ServiceActionList["+ j +"].DisplayName");

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
