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
    public class ListClusterHostGroupResponseUnmarshaller
    {
        public static ListClusterHostGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterHostGroupResponse listClusterHostGroupResponse = new ListClusterHostGroupResponse();

			listClusterHostGroupResponse.HttpResponse = context.HttpResponse;
			listClusterHostGroupResponse.RequestId = context.StringValue("ListClusterHostGroup.RequestId");
			listClusterHostGroupResponse.PageNumber = context.IntegerValue("ListClusterHostGroup.PageNumber");
			listClusterHostGroupResponse.PageSize = context.IntegerValue("ListClusterHostGroup.PageSize");
			listClusterHostGroupResponse.Total = context.IntegerValue("ListClusterHostGroup.Total");
			listClusterHostGroupResponse.ClusterId = context.StringValue("ListClusterHostGroup.ClusterId");

			List<ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup> listClusterHostGroupResponse_hostGroupList = new List<ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup>();
			for (int i = 0; i < context.Length("ListClusterHostGroup.HostGroupList.Length"); i++) {
				ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup hostGroup = new ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup();
				hostGroup.HostGroupId = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupId");
				hostGroup.HostGroupName = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupName");
				hostGroup.HostGroupType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupType");
				hostGroup.HostGroupSubType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupSubType");
				hostGroup.InstanceType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].InstanceType");
				hostGroup.SystemDiskType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].SystemDiskType");
				hostGroup.SystemDiskSize = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].SystemDiskSize");
				hostGroup.SystemDiskCount = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].SystemDiskCount");
				hostGroup.DataDiskType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].DataDiskType");
				hostGroup.DataDiskSize = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].DataDiskSize");
				hostGroup.DataDiskCount = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].DataDiskCount");
				hostGroup.Cpu = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].Cpu");
				hostGroup.Memory = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].Memory");
				hostGroup.Status = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].Status");
				hostGroup.LockType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].LockType");
				hostGroup.LockReason = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].LockReason");
				hostGroup.PayType = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].PayType");
				hostGroup.NodeCount = context.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].NodeCount");
				hostGroup.VswitchId = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].VswitchId");
				hostGroup.Comment = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].Comment");
				hostGroup.SecurityGroupId = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].SecurityGroupId");
				hostGroup.GmtCreate = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].GmtCreate");
				hostGroup.GmtModified = context.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].GmtModified");

				listClusterHostGroupResponse_hostGroupList.Add(hostGroup);
			}
			listClusterHostGroupResponse.HostGroupList = listClusterHostGroupResponse_hostGroupList;
        
			return listClusterHostGroupResponse;
        }
    }
}
