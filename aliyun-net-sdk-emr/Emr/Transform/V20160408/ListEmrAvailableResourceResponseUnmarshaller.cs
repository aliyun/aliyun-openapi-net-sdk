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
        public static ListEmrAvailableResourceResponse Unmarshall(UnmarshallerContext context)
        {
			ListEmrAvailableResourceResponse listEmrAvailableResourceResponse = new ListEmrAvailableResourceResponse();

			listEmrAvailableResourceResponse.HttpResponse = context.HttpResponse;
			listEmrAvailableResourceResponse.RequestId = context.StringValue("ListEmrAvailableResource.RequestId");
			listEmrAvailableResourceResponse.RegionId = context.StringValue("ListEmrAvailableResource.RegionId");

			List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo> listEmrAvailableResourceResponse_emrZoneInfoList = new List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo>();
			for (int i = 0; i < context.Length("ListEmrAvailableResource.EmrZoneInfoList.Length"); i++) {
				ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo emrZoneInfo = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo();
				emrZoneInfo.ZoneId = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].ZoneId");

				List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo> emrZoneInfo_emrResourceInfoList = new List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo>();
				for (int j = 0; j < context.Length("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList.Length"); j++) {
					ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo emrResourceInfo = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo();
					emrResourceInfo.Type = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].Type");

					List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource> emrResourceInfo_supportedResourceList = new List<ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource>();
					for (int k = 0; k < context.Length("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList.Length"); k++) {
						ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource supportedResource = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource();
						supportedResource._Value = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Value");
						supportedResource.Min = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Min");
						supportedResource.Max = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Max");
						supportedResource.Unit = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Unit");
						supportedResource._Value1 = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].Value");

						List<string> supportedResource_supportNodeTypeList = new List<string>();
						for (int l = 0; l < context.Length("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].SupportNodeTypeList.Length"); l++) {
							supportedResource_supportNodeTypeList.Add(context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].SupportNodeTypeList["+ l +"]"));
						}
						supportedResource.SupportNodeTypeList = supportedResource_supportNodeTypeList;

						ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource.ListEmrAvailableResource_EmrInstanceType emrInstanceType = new ListEmrAvailableResourceResponse.ListEmrAvailableResource_EmrZoneInfo.ListEmrAvailableResource_EmrResourceInfo.ListEmrAvailableResource_SupportedResource.ListEmrAvailableResource_EmrInstanceType();
						emrInstanceType.InstanceType = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceType");
						emrInstanceType.CpuCoreCount = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.CpuCoreCount");
						emrInstanceType.MemorySize = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.MemorySize");
						emrInstanceType.InstanceTypeFamily = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceTypeFamily");
						emrInstanceType.LocalStorageCapacity = context.LongValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.LocalStorageCapacity");
						emrInstanceType.LocalStorageAmount = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.LocalStorageAmount");
						emrInstanceType.LocalStorageCategory = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.LocalStorageCategory");
						emrInstanceType.GPUAmount = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.GPUAmount");
						emrInstanceType.GPUSpec = context.StringValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.GPUSpec");
						emrInstanceType.InitialCredit = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InitialCredit");
						emrInstanceType.BaselineCredit = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.BaselineCredit");
						emrInstanceType.EniQuantity = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.EniQuantity");
						emrInstanceType.InstanceBandwidthRx = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceBandwidthRx");
						emrInstanceType.InstanceBandwidthTx = context.IntegerValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstanceBandwidthTx");
						emrInstanceType.InstancePpsRx = context.LongValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstancePpsRx");
						emrInstanceType.InstancePpsTx = context.LongValue("ListEmrAvailableResource.EmrZoneInfoList["+ i +"].EmrResourceInfoList["+ j +"].SupportedResourceList["+ k +"].EmrInstanceType.InstancePpsTx");
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
