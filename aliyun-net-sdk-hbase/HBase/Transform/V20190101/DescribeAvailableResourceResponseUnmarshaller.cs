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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableResourceResponse.RequestId = _ctx.StringValue("DescribeAvailableResource.RequestId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone> describeAvailableResourceResponse_availableZones = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableResource.AvailableZones.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone();
				availableZone.RegionId = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].ZoneId");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine> availableZone_supportedEngines = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine supportedEngine = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine();
					supportedEngine.Engine = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion> supportedEngine_supportedEngineVersions = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion();
						supportedEngineVersion.Version = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].Version");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem> supportedEngineVersion_supportedCategories = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem supportedCategoriesItem = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem();
							supportedCategoriesItem.Category = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].Category");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType> supportedCategoriesItem_supportedStorageTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType supportedStorageType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType();
								supportedStorageType.StorageType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].StorageType");

								List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource> supportedStorageType_coreResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource>();
								for (int n = 0; n < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources.Length"); n++) {
									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource coreResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource();
									coreResource.InstanceType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].InstanceType");
									coreResource.MaxCoreCount = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].MaxCoreCount");

									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource.DescribeAvailableResource_DBInstanceStorageRange dBInstanceStorageRange = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource.DescribeAvailableResource_DBInstanceStorageRange();
									dBInstanceStorageRange.MaxSize = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].DBInstanceStorageRange.MaxSize");
									dBInstanceStorageRange.MinSize = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].DBInstanceStorageRange.MinSize");
									dBInstanceStorageRange.StepSize = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].DBInstanceStorageRange.StepSize");
									coreResource.DBInstanceStorageRange = dBInstanceStorageRange;

									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource.DescribeAvailableResource_InstanceTypeDetail instanceTypeDetail = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategoriesItem.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_CoreResource.DescribeAvailableResource_InstanceTypeDetail();
									instanceTypeDetail.Cpu = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].InstanceTypeDetail.Cpu");
									instanceTypeDetail.Mem = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].InstanceTypeDetail.Mem");
									coreResource.InstanceTypeDetail = instanceTypeDetail;

									supportedStorageType_coreResources.Add(coreResource);
								}
								supportedStorageType.CoreResources = supportedStorageType_coreResources;

								supportedCategoriesItem_supportedStorageTypes.Add(supportedStorageType);
							}
							supportedCategoriesItem.SupportedStorageTypes = supportedCategoriesItem_supportedStorageTypes;

							supportedEngineVersion_supportedCategories.Add(supportedCategoriesItem);
						}
						supportedEngineVersion.SupportedCategories = supportedEngineVersion_supportedCategories;

						supportedEngine_supportedEngineVersions.Add(supportedEngineVersion);
					}
					supportedEngine.SupportedEngineVersions = supportedEngine_supportedEngineVersions;

					availableZone_supportedEngines.Add(supportedEngine);
				}
				availableZone.SupportedEngines = availableZone_supportedEngines;

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_MasterResource> availableZone_masterResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_MasterResource>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].MasterResources.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_MasterResource masterResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_MasterResource();
					masterResource.InstanceType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].MasterResources["+ j +"].InstanceType");

					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_MasterResource.DescribeAvailableResource_InstanceTypeDetail1 instanceTypeDetail1 = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_MasterResource.DescribeAvailableResource_InstanceTypeDetail1();
					instanceTypeDetail1.Cpu = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].MasterResources["+ j +"].InstanceTypeDetail.Cpu");
					instanceTypeDetail1.Mem = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].MasterResources["+ j +"].InstanceTypeDetail.Mem");
					masterResource.InstanceTypeDetail1 = instanceTypeDetail1;

					availableZone_masterResources.Add(masterResource);
				}
				availableZone.MasterResources = availableZone_masterResources;

				describeAvailableResourceResponse_availableZones.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZones = describeAvailableResourceResponse_availableZones;
        
			return describeAvailableResourceResponse;
        }
    }
}
