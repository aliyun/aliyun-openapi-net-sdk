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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeDedicatedClusterInstanceListResponseUnmarshaller
    {
        public static DescribeDedicatedClusterInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedClusterInstanceListResponse describeDedicatedClusterInstanceListResponse = new DescribeDedicatedClusterInstanceListResponse();

			describeDedicatedClusterInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedClusterInstanceListResponse.TotalCount = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.TotalCount");
			describeDedicatedClusterInstanceListResponse.RequestId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.RequestId");
			describeDedicatedClusterInstanceListResponse.PageSize = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.PageSize");
			describeDedicatedClusterInstanceListResponse.PageNumber = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.PageNumber");

			List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance> describeDedicatedClusterInstanceListResponse_instances = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedClusterInstanceList.Instances.Length"); i++) {
				DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance dbInstance = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance();
				dbInstance.VpcId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VpcId");
				dbInstance.CharacterType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CharacterType");
				dbInstance.VswitchId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VswitchId");
				dbInstance.MaintainStartTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainStartTime");
				dbInstance.InstanceClass = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceClass");
				dbInstance.ConnectionDomain = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ConnectionDomain");
				dbInstance.CreateTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CreateTime");
				dbInstance.MaintainEndTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainEndTime");
				dbInstance.StorageType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].StorageType");
				dbInstance.InstanceId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceId");
				dbInstance.EngineVersion = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].EngineVersion");
				dbInstance.RegionId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].RegionId");
				dbInstance.InstanceName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceName");
				dbInstance.Region = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].Region");
				dbInstance.ZoneId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ZoneId");
				dbInstance.ClusterName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterName");
				dbInstance.InstanceStatus = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceStatus");
				dbInstance.Engine = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].Engine");
				dbInstance.CustomId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CustomId");
				dbInstance.ClusterId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterId");

				List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes> dbInstance_instanceNodeList = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList.Length"); j++) {
					DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes instanceNodes = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes();
					instanceNodes.NodeIp = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeIp");
					instanceNodes.DedicatedHostName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].DedicatedHostName");
					instanceNodes.InsName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].InsName");
					instanceNodes.NodeType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeType");
					instanceNodes.ZoneId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].ZoneId");
					instanceNodes.Role = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Role");
					instanceNodes.Port = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Port");
					instanceNodes.NodeId = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeId");

					dbInstance_instanceNodeList.Add(instanceNodes);
				}
				dbInstance.InstanceNodeList = dbInstance_instanceNodeList;

				describeDedicatedClusterInstanceListResponse_instances.Add(dbInstance);
			}
			describeDedicatedClusterInstanceListResponse.Instances = describeDedicatedClusterInstanceListResponse_instances;
        
			return describeDedicatedClusterInstanceListResponse;
        }
    }
}
