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
    public class DescribeMultiZoneAvailableResourceResponseUnmarshaller
    {
        public static DescribeMultiZoneAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMultiZoneAvailableResourceResponse describeMultiZoneAvailableResourceResponse = new DescribeMultiZoneAvailableResourceResponse();

			describeMultiZoneAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeMultiZoneAvailableResourceResponse.RequestId = _ctx.StringValue("DescribeMultiZoneAvailableResource.RequestId");

			List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone> describeMultiZoneAvailableResourceResponse_availableZones = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone>();
			for (int i = 0; i < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones.Length"); i++) {
				DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone availableZone = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone();
				availableZone.RegionId = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneCombination = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].ZoneCombination");

				List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_MasterResource> availableZone_masterResources = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_MasterResource>();
				for (int j = 0; j < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].MasterResources.Length"); j++) {
					DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_MasterResource masterResource = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_MasterResource();
					masterResource.InstanceType = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].MasterResources["+ j +"].InstanceType");

					DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_MasterResource.DescribeMultiZoneAvailableResource_InstanceTypeDetail instanceTypeDetail = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_MasterResource.DescribeMultiZoneAvailableResource_InstanceTypeDetail();
					instanceTypeDetail.Cpu = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].MasterResources["+ j +"].InstanceTypeDetail.Cpu");
					instanceTypeDetail.Mem = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].MasterResources["+ j +"].InstanceTypeDetail.Mem");
					masterResource.InstanceTypeDetail = instanceTypeDetail;

					availableZone_masterResources.Add(masterResource);
				}
				availableZone.MasterResources = availableZone_masterResources;

				List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine> availableZone_supportedEngines = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine supportedEngine = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine();
					supportedEngine.Engine = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion> supportedEngine_supportedEngineVersions = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion>();
					for (int k = 0; k < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions.Length"); k++) {
						DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion();
						supportedEngineVersion.Version = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].Version");

						List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem> supportedEngineVersion_supportedCategories = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem>();
						for (int l = 0; l < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories.Length"); l++) {
							DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem supportedCategoriesItem = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem();
							supportedCategoriesItem.Category = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].Category");

							List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType> supportedCategoriesItem_supportedStorageTypes = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType>();
							for (int m = 0; m < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes.Length"); m++) {
								DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType supportedStorageType = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType();
								supportedStorageType.StorageType = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].StorageType");

								List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource> supportedStorageType_coreResources = new List<DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource>();
								for (int n = 0; n < _ctx.Length("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources.Length"); n++) {
									DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource coreResource = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource();
									coreResource.InstanceType = _ctx.StringValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].InstanceType");
									coreResource.MaxCoreCount = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].MaxCoreCount");

									DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource.DescribeMultiZoneAvailableResource_DBInstanceStorageRange dBInstanceStorageRange = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource.DescribeMultiZoneAvailableResource_DBInstanceStorageRange();
									dBInstanceStorageRange.MaxSize = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].DBInstanceStorageRange.MaxSize");
									dBInstanceStorageRange.MinSize = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].DBInstanceStorageRange.MinSize");
									dBInstanceStorageRange.StepSize = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].DBInstanceStorageRange.StepSize");
									coreResource.DBInstanceStorageRange = dBInstanceStorageRange;

									DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource.DescribeMultiZoneAvailableResource_InstanceTypeDetail1 instanceTypeDetail1 = new DescribeMultiZoneAvailableResourceResponse.DescribeMultiZoneAvailableResource_AvailableZone.DescribeMultiZoneAvailableResource_SupportedEngine.DescribeMultiZoneAvailableResource_SupportedEngineVersion.DescribeMultiZoneAvailableResource_SupportedCategoriesItem.DescribeMultiZoneAvailableResource_SupportedStorageType.DescribeMultiZoneAvailableResource_CoreResource.DescribeMultiZoneAvailableResource_InstanceTypeDetail1();
									instanceTypeDetail1.Cpu = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].InstanceTypeDetail.Cpu");
									instanceTypeDetail1.Mem = _ctx.IntegerValue("DescribeMultiZoneAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategories["+ l +"].SupportedStorageTypes["+ m +"].CoreResources["+ n +"].InstanceTypeDetail.Mem");
									coreResource.InstanceTypeDetail1 = instanceTypeDetail1;

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

				describeMultiZoneAvailableResourceResponse_availableZones.Add(availableZone);
			}
			describeMultiZoneAvailableResourceResponse.AvailableZones = describeMultiZoneAvailableResourceResponse_availableZones;
        
			return describeMultiZoneAvailableResourceResponse;
        }
    }
}
