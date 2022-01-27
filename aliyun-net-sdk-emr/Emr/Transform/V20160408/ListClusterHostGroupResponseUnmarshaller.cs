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
        public static ListClusterHostGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterHostGroupResponse listClusterHostGroupResponse = new ListClusterHostGroupResponse();

			listClusterHostGroupResponse.HttpResponse = _ctx.HttpResponse;
			listClusterHostGroupResponse.RequestId = _ctx.StringValue("ListClusterHostGroup.RequestId");
			listClusterHostGroupResponse.PageNumber = _ctx.IntegerValue("ListClusterHostGroup.PageNumber");
			listClusterHostGroupResponse.PageSize = _ctx.IntegerValue("ListClusterHostGroup.PageSize");
			listClusterHostGroupResponse.Total = _ctx.IntegerValue("ListClusterHostGroup.Total");
			listClusterHostGroupResponse.ClusterId = _ctx.StringValue("ListClusterHostGroup.ClusterId");

			List<ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup> listClusterHostGroupResponse_hostGroupList = new List<ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup>();
			for (int i = 0; i < _ctx.Length("ListClusterHostGroup.HostGroupList.Length"); i++) {
				ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup hostGroup = new ListClusterHostGroupResponse.ListClusterHostGroup_HostGroup();
				hostGroup.HostGroupId = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupId");
				hostGroup.HostGroupName = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupName");
				hostGroup.HostGroupType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupType");
				hostGroup.HostGroupSubType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupSubType");
				hostGroup.InstanceType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].InstanceType");
				hostGroup.SystemDiskType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].SystemDiskType");
				hostGroup.SystemDiskSize = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].SystemDiskSize");
				hostGroup.SystemDiskCount = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].SystemDiskCount");
				hostGroup.DataDiskType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].DataDiskType");
				hostGroup.DataDiskSize = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].DataDiskSize");
				hostGroup.DataDiskCount = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].DataDiskCount");
				hostGroup.Cpu = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].Cpu");
				hostGroup.Memory = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].Memory");
				hostGroup.Status = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].Status");
				hostGroup.LockType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].LockType");
				hostGroup.LockReason = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].LockReason");
				hostGroup.PayType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].PayType");
				hostGroup.ChargeType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].ChargeType");
				hostGroup.NodeCount = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].NodeCount");
				hostGroup.VswitchId = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].VswitchId");
				hostGroup.Comment = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].Comment");
				hostGroup.SecurityGroupId = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].SecurityGroupId");
				hostGroup.GmtCreate = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].gmtCreate");
				hostGroup.GmtModified = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].gmtModified");
				hostGroup.HostGroupChangeType = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupChangeType");
				hostGroup.HostGroupChangeStatus = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].HostGroupChangeStatus");
				hostGroup.ScalingGroupBizId = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].ScalingGroupBizId");
				hostGroup.ScalingGroupActiveStatus = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].ScalingGroupActiveStatus");
				hostGroup.ScalingInMode = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].ScalingInMode");
				hostGroup.ScalingGroupMinNode = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].ScalingGroupMinNode");
				hostGroup.ScalingGroupMaxNode = _ctx.IntegerValue("ListClusterHostGroup.HostGroupList["+ i +"].ScalingGroupMaxNode");
				hostGroup.ScalingGroupConfigState = _ctx.StringValue("ListClusterHostGroup.HostGroupList["+ i +"].ScalingGroupConfigState");
				hostGroup.CostSavingPercent = _ctx.FloatValue("ListClusterHostGroup.HostGroupList["+ i +"].CostSavingPercent");

				listClusterHostGroupResponse_hostGroupList.Add(hostGroup);
			}
			listClusterHostGroupResponse.HostGroupList = listClusterHostGroupResponse_hostGroupList;
        
			return listClusterHostGroupResponse;
        }
    }
}
