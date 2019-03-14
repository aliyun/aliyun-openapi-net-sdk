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
    public class ListFlowProjectClusterSettingResponseUnmarshaller
    {
        public static ListFlowProjectClusterSettingResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowProjectClusterSettingResponse listFlowProjectClusterSettingResponse = new ListFlowProjectClusterSettingResponse();

			listFlowProjectClusterSettingResponse.HttpResponse = context.HttpResponse;
			listFlowProjectClusterSettingResponse.RequestId = context.StringValue("ListFlowProjectClusterSetting.RequestId");
			listFlowProjectClusterSettingResponse.PageNumber = context.IntegerValue("ListFlowProjectClusterSetting.PageNumber");
			listFlowProjectClusterSettingResponse.PageSize = context.IntegerValue("ListFlowProjectClusterSetting.PageSize");
			listFlowProjectClusterSettingResponse.Total = context.IntegerValue("ListFlowProjectClusterSetting.Total");

			List<ListFlowProjectClusterSettingResponse.ListFlowProjectClusterSetting_ClusterSetting> listFlowProjectClusterSettingResponse_clusterSettings = new List<ListFlowProjectClusterSettingResponse.ListFlowProjectClusterSetting_ClusterSetting>();
			for (int i = 0; i < context.Length("ListFlowProjectClusterSetting.ClusterSettings.Length"); i++) {
				ListFlowProjectClusterSettingResponse.ListFlowProjectClusterSetting_ClusterSetting clusterSetting = new ListFlowProjectClusterSettingResponse.ListFlowProjectClusterSetting_ClusterSetting();
				clusterSetting.GmtCreate = context.LongValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].GmtCreate");
				clusterSetting.GmtModified = context.LongValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].GmtModified");
				clusterSetting.ProjectId = context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].ProjectId");
				clusterSetting.ClusterId = context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].ClusterId");
				clusterSetting.ClusterName = context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].ClusterName");
				clusterSetting.DefaultUser = context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].DefaultUser");
				clusterSetting.DefaultQueue = context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].DefaultQueue");

				List<string> clusterSetting_userList = new List<string>();
				for (int j = 0; j < context.Length("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].UserList.Length"); j++) {
					clusterSetting_userList.Add(context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].UserList["+ j +"]"));
				}
				clusterSetting.UserList = clusterSetting_userList;

				List<string> clusterSetting_queueList = new List<string>();
				for (int j = 0; j < context.Length("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].QueueList.Length"); j++) {
					clusterSetting_queueList.Add(context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].QueueList["+ j +"]"));
				}
				clusterSetting.QueueList = clusterSetting_queueList;

				List<string> clusterSetting_hostList = new List<string>();
				for (int j = 0; j < context.Length("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].HostList.Length"); j++) {
					clusterSetting_hostList.Add(context.StringValue("ListFlowProjectClusterSetting.ClusterSettings["+ i +"].HostList["+ j +"]"));
				}
				clusterSetting.HostList = clusterSetting_hostList;

				listFlowProjectClusterSettingResponse_clusterSettings.Add(clusterSetting);
			}
			listFlowProjectClusterSettingResponse.ClusterSettings = listFlowProjectClusterSettingResponse_clusterSettings;
        
			return listFlowProjectClusterSettingResponse;
        }
    }
}
