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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeDedicatedClusterInstanceListResponseUnmarshaller
    {
        public static DescribeDedicatedClusterInstanceListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedClusterInstanceListResponse describeDedicatedClusterInstanceListResponse = new DescribeDedicatedClusterInstanceListResponse();

			describeDedicatedClusterInstanceListResponse.HttpResponse = context.HttpResponse;
			describeDedicatedClusterInstanceListResponse.PageNumber = context.IntegerValue("DescribeDedicatedClusterInstanceList.PageNumber");
			describeDedicatedClusterInstanceListResponse.PageSize = context.IntegerValue("DescribeDedicatedClusterInstanceList.PageSize");
			describeDedicatedClusterInstanceListResponse.RequestId = context.StringValue("DescribeDedicatedClusterInstanceList.RequestId");
			describeDedicatedClusterInstanceListResponse.TotalCount = context.IntegerValue("DescribeDedicatedClusterInstanceList.TotalCount");

			List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem> describeDedicatedClusterInstanceListResponse_instances = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem>();
			for (int i = 0; i < context.Length("DescribeDedicatedClusterInstanceList.Instances.Length"); i++) {
				DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem instancesItem = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem();
				instancesItem.CharacterType = context.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CharacterType");
				instancesItem.ClusterId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterId");
				instancesItem.ClusterName = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterName");
				instancesItem.EngineVersion = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].EngineVersion");
				instancesItem.InstanceId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceId");
				instancesItem.InstanceStatus = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceStatus");
				instancesItem.MaintainEndTime = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainEndTime");
				instancesItem.MaintainStartTime = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainStartTime");
				instancesItem.RegionId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].RegionId");
				instancesItem.VpcId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VpcId");
				instancesItem.VswitchId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VswitchId");
				instancesItem.ZoneId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ZoneId");
				instancesItem.InstanceName = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceName");
				instancesItem.CustomId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CustomId");
				instancesItem.InstanceClass = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceClass");
				instancesItem.Engine = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].Engine");
				instancesItem.StorageType = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].StorageType");
				instancesItem.ConnectionDomain = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ConnectionDomain");
				instancesItem.CreateTime = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CreateTime");

				List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes> instancesItem_instanceNodeList = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes>();
				for (int j = 0; j < context.Length("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList.Length"); j++) {
					DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes instanceNodes = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes();
					instanceNodes.NodeId = context.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeId");
					instanceNodes.NodeIp = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeIp");
					instanceNodes.NodeType = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeType");
					instanceNodes.Port = context.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Port");
					instanceNodes.Role = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Role");
					instanceNodes.ZoneId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].ZoneId");
					instanceNodes.InstanceId = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].InstanceId");
					instanceNodes.DedicatedHostName = context.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].DedicatedHostName");

					instancesItem_instanceNodeList.Add(instanceNodes);
				}
				instancesItem.InstanceNodeList = instancesItem_instanceNodeList;

				describeDedicatedClusterInstanceListResponse_instances.Add(instancesItem);
			}
			describeDedicatedClusterInstanceListResponse.Instances = describeDedicatedClusterInstanceListResponse_instances;
        
			return describeDedicatedClusterInstanceListResponse;
        }
    }
}
