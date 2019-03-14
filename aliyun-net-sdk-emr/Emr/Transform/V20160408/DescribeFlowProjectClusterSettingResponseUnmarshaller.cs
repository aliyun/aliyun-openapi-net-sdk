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
    public class DescribeFlowProjectClusterSettingResponseUnmarshaller
    {
        public static DescribeFlowProjectClusterSettingResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowProjectClusterSettingResponse describeFlowProjectClusterSettingResponse = new DescribeFlowProjectClusterSettingResponse();

			describeFlowProjectClusterSettingResponse.HttpResponse = context.HttpResponse;
			describeFlowProjectClusterSettingResponse.RequestId = context.StringValue("DescribeFlowProjectClusterSetting.RequestId");
			describeFlowProjectClusterSettingResponse.GmtCreate = context.LongValue("DescribeFlowProjectClusterSetting.GmtCreate");
			describeFlowProjectClusterSettingResponse.GmtModified = context.LongValue("DescribeFlowProjectClusterSetting.GmtModified");
			describeFlowProjectClusterSettingResponse.ProjectId = context.StringValue("DescribeFlowProjectClusterSetting.ProjectId");
			describeFlowProjectClusterSettingResponse.ClusterId = context.StringValue("DescribeFlowProjectClusterSetting.ClusterId");
			describeFlowProjectClusterSettingResponse.DefaultUser = context.StringValue("DescribeFlowProjectClusterSetting.DefaultUser");
			describeFlowProjectClusterSettingResponse.DefaultQueue = context.StringValue("DescribeFlowProjectClusterSetting.DefaultQueue");

			List<string> describeFlowProjectClusterSettingResponse_userList = new List<string>();
			for (int i = 0; i < context.Length("DescribeFlowProjectClusterSetting.UserList.Length"); i++) {
				describeFlowProjectClusterSettingResponse_userList.Add(context.StringValue("DescribeFlowProjectClusterSetting.UserList["+ i +"]"));
			}
			describeFlowProjectClusterSettingResponse.UserList = describeFlowProjectClusterSettingResponse_userList;

			List<string> describeFlowProjectClusterSettingResponse_queueList = new List<string>();
			for (int i = 0; i < context.Length("DescribeFlowProjectClusterSetting.QueueList.Length"); i++) {
				describeFlowProjectClusterSettingResponse_queueList.Add(context.StringValue("DescribeFlowProjectClusterSetting.QueueList["+ i +"]"));
			}
			describeFlowProjectClusterSettingResponse.QueueList = describeFlowProjectClusterSettingResponse_queueList;

			List<string> describeFlowProjectClusterSettingResponse_hostList = new List<string>();
			for (int i = 0; i < context.Length("DescribeFlowProjectClusterSetting.HostList.Length"); i++) {
				describeFlowProjectClusterSettingResponse_hostList.Add(context.StringValue("DescribeFlowProjectClusterSetting.HostList["+ i +"]"));
			}
			describeFlowProjectClusterSettingResponse.HostList = describeFlowProjectClusterSettingResponse_hostList;
        
			return describeFlowProjectClusterSettingResponse;
        }
    }
}
