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
        public static DescribeDedicatedClusterInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedClusterInstanceListResponse describeDedicatedClusterInstanceListResponse = new DescribeDedicatedClusterInstanceListResponse();

			describeDedicatedClusterInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedClusterInstanceListResponse.PageNumber = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.PageNumber");
			describeDedicatedClusterInstanceListResponse.PageSize = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.PageSize");
			describeDedicatedClusterInstanceListResponse.RequestId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.RequestId");
			describeDedicatedClusterInstanceListResponse.TotalCount = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.TotalCount");

			List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem> describeDedicatedClusterInstanceListResponse_instances = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedClusterInstanceList.Instances.Length"); i++) {
				DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem instancesItem = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem();
				instancesItem.VpcId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VpcId");
				instancesItem.CharacterType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CharacterType");
				instancesItem.VswitchId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VswitchId");
				instancesItem.InstanceClass = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceClass");
				instancesItem.MaintainStartTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainStartTime");
				instancesItem.CreateTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CreateTime");
				instancesItem.ConnectionDomain = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ConnectionDomain");
				instancesItem.MaintainEndTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainEndTime");
				instancesItem.StorageType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].StorageType");
				instancesItem.InstanceId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceId");
				instancesItem.BandWidth = _ctx.LongValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].BandWidth");
				instancesItem.CurrentBandWidth = _ctx.LongValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CurrentBandWidth");
				instancesItem.EngineVersion = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].EngineVersion");
				instancesItem.RegionId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].RegionId");
				instancesItem.InstanceName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceName");
				instancesItem.ZoneId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ZoneId");
				instancesItem.ClusterName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterName");
				instancesItem.InstanceStatus = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceStatus");
				instancesItem.Engine = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].Engine");
				instancesItem.ShardCount = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ShardCount");
				instancesItem.CustomId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CustomId");
				instancesItem.ProxyCount = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ProxyCount");
				instancesItem.ClusterId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterId");

				List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes> instancesItem_instanceNodeList = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList.Length"); j++) {
					DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes instanceNodes = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_InstancesItem.DescribeDedicatedClusterInstanceList_InstanceNodes();
					instanceNodes.NodeIp = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeIp");
					instanceNodes.DedicatedHostName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].DedicatedHostName");
					instanceNodes.NodeType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeType");
					instanceNodes.ZoneId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].ZoneId");
					instanceNodes.InstanceId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].InstanceId");
					instanceNodes.Port = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Port");
					instanceNodes.Role = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Role");
					instanceNodes.NodeId = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeId");

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
