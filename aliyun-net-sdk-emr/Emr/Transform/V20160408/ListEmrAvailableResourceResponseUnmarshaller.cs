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
    public class ListEmrAvailableResourceResponseUnmarshaller
    {
        public static ListEmrAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmrAvailableResourceResponse listEmrAvailableResourceResponse = new ListEmrAvailableResourceResponse();

			listEmrAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			listEmrAvailableResourceResponse.RequestId = _ctx.StringValue("ListEmrAvailableResource.RequestId");
			listEmrAvailableResourceResponse.RegionId = _ctx.StringValue("ListEmrAvailableResource.RegionId");

			List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo> listEmrAvailableResourceResponse_emrZoneInfoList = new List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo>();
			for (int i = 0; i < _ctx.Length("ListEmrAvailableResource.EmrZoneInfoList.Length"); i++) {
				ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo emrZoneInfo = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo();
				emrZoneInfo.ZoneId = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].ZoneId");

				List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo> emrZoneInfo_emrResourceInfoList = new List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo>();
				for (int j = 0; j < _ctx.Length("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList.Length"); j++) {
					ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo emrResourceInfo = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo();
					emrResourceInfo.Type = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].Type");

					List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource> emrResourceInfo_supportedResourceList = new List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource>();
					for (int k = 0; k < _ctx.Length("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList.Length"); k++) {
						ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource supportedResource = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource();
						supportedResource._Value = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Value");
						supportedResource.Min = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Min");
						supportedResource.Max = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Max");
						supportedResource.Unit = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Unit");

						List<string> supportedResource_supportNodeTypeList = new List<string>();
						for (int l = 0; l < _ctx.Length("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].SupportNodeTypeList.Length"); l++) {
							supportedResource_supportNodeTypeList.Add(_ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].SupportNodeTypeList["+ l +"]"));
						}
						supportedResource.SupportNodeTypeList = supportedResource_supportNodeTypeList;

						ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource.ListEmrAvailableResource_EmrInstanceType emrInstanceType = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource.ListEmrAvailableResource_EmrInstanceType();
						emrInstanceType.InstanceType = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceType");
						emrInstanceType.CpuCoreCount = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.CpuCoreCount");
						emrInstanceType.MemorySize = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.MemorySize");
						emrInstanceType.InstanceTypeFamily = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceTypeFamily");
						emrInstanceType.LocalStorageCapacity = _ctx.LongValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.LocalStorageCapacity");
						emrInstanceType.LocalStorageAmount = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.LocalStorageAmount");
						emrInstanceType.LocalStorageCategory = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.LocalStorageCategory");
						emrInstanceType.GPUAmount = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.GPUAmount");
						emrInstanceType.GPUSpec = _ctx.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.GPUSpec");
						emrInstanceType.InitialCredit = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InitialCredit");
						emrInstanceType.BaselineCredit = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.BaselineCredit");
						emrInstanceType.EniQuantity = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.EniQuantity");
						emrInstanceType.InstanceBandwidthRx = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceBandwidthRx");
						emrInstanceType.InstanceBandwidthTx = _ctx.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceBandwidthTx");
						emrInstanceType.InstancePpsRx = _ctx.LongValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstancePpsRx");
						emrInstanceType.InstancePpsTx = _ctx.LongValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstancePpsTx");
						supportedResource.EmrInstanceType = emrInstanceType;

						emrResourceInfo_supportedResourceList.Add(supportedResource);
					}
					emrResourceInfo.SupportedResourceList = emrResourceInfo_supportedResourceList;

					emrZoneInfo_emrResourceInfoList.Add(emrResourceInfo);
				}
				emrZoneInfo.EmrResourceInfoList = emrZoneInfo_emrResourceInfoList;

				listEmrAvailableResourceResponse_emrZoneInfoList.Add(emrZoneInfo);
			}
			listEmrAvailableResourceResponse.EmrZoneInfoList = listEmrAvailableResourceResponse_emrZoneInfoList;
        
			return listEmrAvailableResourceResponse;
        }
    }
}
