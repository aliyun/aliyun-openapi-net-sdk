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
        public static DescribeFlowProjectClusterSettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowProjectClusterSettingResponse describeFlowProjectClusterSettingResponse = new DescribeFlowProjectClusterSettingResponse();

			describeFlowProjectClusterSettingResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowProjectClusterSettingResponse.RequestId = _ctx.StringValue("DescribeFlowProjectClusterSetting.RequestId");
			describeFlowProjectClusterSettingResponse.GmtCreate = _ctx.LongValue("DescribeFlowProjectClusterSetting.GmtCreate");
			describeFlowProjectClusterSettingResponse.GmtModified = _ctx.LongValue("DescribeFlowProjectClusterSetting.GmtModified");
			describeFlowProjectClusterSettingResponse.ProjectId = _ctx.StringValue("DescribeFlowProjectClusterSetting.ProjectId");
			describeFlowProjectClusterSettingResponse.ClusterId = _ctx.StringValue("DescribeFlowProjectClusterSetting.ClusterId");
			describeFlowProjectClusterSettingResponse.K8sClusterId = _ctx.StringValue("DescribeFlowProjectClusterSetting.K8sClusterId");
			describeFlowProjectClusterSettingResponse.DefaultUser = _ctx.StringValue("DescribeFlowProjectClusterSetting.DefaultUser");
			describeFlowProjectClusterSettingResponse.DefaultQueue = _ctx.StringValue("DescribeFlowProjectClusterSetting.DefaultQueue");

			List<string> describeFlowProjectClusterSettingResponse_userList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeFlowProjectClusterSetting.UserList.Length"); i++) {
				describeFlowProjectClusterSettingResponse_userList.Add(_ctx.StringValue("DescribeFlowProjectClusterSetting.UserList["+ i +"]"));
			}
			describeFlowProjectClusterSettingResponse.UserList = describeFlowProjectClusterSettingResponse_userList;

			List<string> describeFlowProjectClusterSettingResponse_queueList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeFlowProjectClusterSetting.QueueList.Length"); i++) {
				describeFlowProjectClusterSettingResponse_queueList.Add(_ctx.StringValue("DescribeFlowProjectClusterSetting.QueueList["+ i +"]"));
			}
			describeFlowProjectClusterSettingResponse.QueueList = describeFlowProjectClusterSettingResponse_queueList;

			List<string> describeFlowProjectClusterSettingResponse_hostList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeFlowProjectClusterSetting.HostList.Length"); i++) {
				describeFlowProjectClusterSettingResponse_hostList.Add(_ctx.StringValue("DescribeFlowProjectClusterSetting.HostList["+ i +"]"));
			}
			describeFlowProjectClusterSettingResponse.HostList = describeFlowProjectClusterSettingResponse_hostList;
        
			return describeFlowProjectClusterSettingResponse;
        }
    }
}
