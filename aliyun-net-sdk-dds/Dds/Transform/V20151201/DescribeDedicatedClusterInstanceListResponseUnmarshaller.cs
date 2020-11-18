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
			describeDedicatedClusterInstanceListResponse.RequestId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.RequestId");
			describeDedicatedClusterInstanceListResponse.PageNumber = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.PageNumber");
			describeDedicatedClusterInstanceListResponse.PageSize = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.PageSize");
			describeDedicatedClusterInstanceListResponse.TotalCount = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.TotalCount");

			List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance> describeDedicatedClusterInstanceListResponse_instances = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedClusterInstanceList.Instances.Length"); i++) {
				DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance dbInstance = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance();
				dbInstance.Region = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].Region");
				dbInstance.ClusterId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterId");
				dbInstance.ClusterName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ClusterName");
				dbInstance.InstanceId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceId");
				dbInstance.InstanceName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceName");
				dbInstance.InstanceStatus = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceStatus");
				dbInstance.EngineVersion = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].EngineVersion");
				dbInstance.CharacterType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CharacterType");
				dbInstance.MaintainStartTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainStartTime");
				dbInstance.MaintainEndTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].MaintainEndTime");
				dbInstance.RegionId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].RegionId");
				dbInstance.VpcId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VpcId");
				dbInstance.VswitchId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].VswitchId");
				dbInstance.ZoneId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ZoneId");
				dbInstance.CustomId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CustomId");
				dbInstance.InstanceClass = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceClass");
				dbInstance.Engine = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].Engine");
				dbInstance.StorageType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].StorageType");
				dbInstance.ConnectionDomain = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].ConnectionDomain");
				dbInstance.CreateTime = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].CreateTime");

				List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes> dbInstance_instanceNodeList = new List<DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList.Length"); j++) {
					DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes instanceNodes = new DescribeDedicatedClusterInstanceListResponse.DescribeDedicatedClusterInstanceList_DbInstance.DescribeDedicatedClusterInstanceList_InstanceNodes();
					instanceNodes.InsName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].InsName");
					instanceNodes.Role = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Role");
					instanceNodes.NodeId = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeId");
					instanceNodes.NodeType = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeType");
					instanceNodes.NodeIp = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].NodeIp");
					instanceNodes.Port = _ctx.IntegerValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].Port");
					instanceNodes.ZoneId = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].ZoneId");
					instanceNodes.DedicatedHostName = _ctx.StringValue("DescribeDedicatedClusterInstanceList.Instances["+ i +"].InstanceNodeList["+ j +"].DedicatedHostName");

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
