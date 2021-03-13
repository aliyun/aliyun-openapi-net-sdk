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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableResourceResponse.RequestId = _ctx.StringValue("DescribeAvailableResource.RequestId");
			describeAvailableResourceResponse.RegionId = _ctx.StringValue("DescribeAvailableResource.RegionId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone> describeAvailableResourceResponse_availableZoneList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableResource.AvailableZoneList.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone();
				availableZone.ZoneId = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].ZoneId");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem> availableZone_supportedMode = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem supportedModeItem = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem();
					supportedModeItem.Mode = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].Mode");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem> supportedModeItem_supportedSerialList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem supportedSerialListItem = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem();
						supportedSerialListItem.Serial = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].Serial");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedFlexibleResourceItem> supportedSerialListItem_supportedFlexibleResource = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedFlexibleResourceItem>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedFlexibleResourceItem supportedFlexibleResourceItem = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedFlexibleResourceItem();
							supportedFlexibleResourceItem.StorageType = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].StorageType");

							List<string> supportedFlexibleResourceItem_supportedStorageResource = new List<string>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedStorageResource.Length"); m++) {
								supportedFlexibleResourceItem_supportedStorageResource.Add(_ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedStorageResource["+ m +"]"));
							}
							supportedFlexibleResourceItem.SupportedStorageResource = supportedFlexibleResourceItem_supportedStorageResource;

							List<string> supportedFlexibleResourceItem_supportedComputeResource = new List<string>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedComputeResource.Length"); m++) {
								supportedFlexibleResourceItem_supportedComputeResource.Add(_ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedComputeResource["+ m +"]"));
							}
							supportedFlexibleResourceItem.SupportedComputeResource = supportedFlexibleResourceItem_supportedComputeResource;

							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedFlexibleResourceItem.DescribeAvailableResource_SupportedElasticIOResource supportedElasticIOResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedFlexibleResourceItem.DescribeAvailableResource_SupportedElasticIOResource();
							supportedElasticIOResource.MinCount = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedElasticIOResource.MinCount");
							supportedElasticIOResource.MaxCount = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedElasticIOResource.MaxCount");
							supportedElasticIOResource.Step = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedFlexibleResource["+ l +"].SupportedElasticIOResource.Step");
							supportedFlexibleResourceItem.SupportedElasticIOResource = supportedElasticIOResource;

							supportedSerialListItem_supportedFlexibleResource.Add(supportedFlexibleResourceItem);
						}
						supportedSerialListItem.SupportedFlexibleResource = supportedSerialListItem_supportedFlexibleResource;

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass> supportedSerialListItem_supportedInstanceClassList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass supportedInstanceClass = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass();
							supportedInstanceClass.InstanceClass = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].InstanceClass");
							supportedInstanceClass.Tips = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].Tips");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount> supportedInstanceClass_supportedNodeCountList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedNodeCountList.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount supportedNodeCount = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount();

								List<string> supportedNodeCount_storageSize = new List<string>();
								for (int n = 0; n < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedNodeCountList["+ m +"].StorageSize.Length"); n++) {
									supportedNodeCount_storageSize.Add(_ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedNodeCountList["+ m +"].StorageSize["+ n +"]"));
								}
								supportedNodeCount.StorageSize = supportedNodeCount_storageSize;

								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount.DescribeAvailableResource_NodeCount nodeCount = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount.DescribeAvailableResource_NodeCount();
								nodeCount.MinCount = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedNodeCountList["+ m +"].NodeCount.MinCount");
								nodeCount.MaxCount = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedNodeCountList["+ m +"].NodeCount.MaxCount");
								nodeCount.Step = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedNodeCountList["+ m +"].NodeCount.Step");
								supportedNodeCount.NodeCount = nodeCount;

								supportedInstanceClass_supportedNodeCountList.Add(supportedNodeCount);
							}
							supportedInstanceClass.SupportedNodeCountList = supportedInstanceClass_supportedNodeCountList;

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedExecutor> supportedInstanceClass_supportedExecutorList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedExecutor>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedExecutorList.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedExecutor supportedExecutor = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedExecutor();

								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedExecutor.DescribeAvailableResource_NodeCount1 nodeCount1 = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedModeItem.DescribeAvailableResource_SupportedSerialListItem.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedExecutor.DescribeAvailableResource_NodeCount1();
								nodeCount1.MinCount = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedExecutorList["+ m +"].NodeCount.MinCount");
								nodeCount1.MaxCount = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedExecutorList["+ m +"].NodeCount.MaxCount");
								nodeCount1.Step = _ctx.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedMode["+ j +"].SupportedSerialList["+ k +"].SupportedInstanceClassList["+ l +"].SupportedExecutorList["+ m +"].NodeCount.Step");
								supportedExecutor.NodeCount1 = nodeCount1;

								supportedInstanceClass_supportedExecutorList.Add(supportedExecutor);
							}
							supportedInstanceClass.SupportedExecutorList = supportedInstanceClass_supportedExecutorList;

							supportedSerialListItem_supportedInstanceClassList.Add(supportedInstanceClass);
						}
						supportedSerialListItem.SupportedInstanceClassList = supportedSerialListItem_supportedInstanceClassList;

						supportedModeItem_supportedSerialList.Add(supportedSerialListItem);
					}
					supportedModeItem.SupportedSerialList = supportedModeItem_supportedSerialList;

					availableZone_supportedMode.Add(supportedModeItem);
				}
				availableZone.SupportedMode = availableZone_supportedMode;

				describeAvailableResourceResponse_availableZoneList.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZoneList = describeAvailableResourceResponse_availableZoneList;
        
			return describeAvailableResourceResponse;
        }
    }
}
