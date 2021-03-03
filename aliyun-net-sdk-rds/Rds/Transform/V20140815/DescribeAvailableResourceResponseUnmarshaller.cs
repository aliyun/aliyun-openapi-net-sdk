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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
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
				availableZone.NetworkTypes = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].NetworkTypes");
				availableZone.RegionId = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].RegionId");
				availableZone.Status = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].Status");
				availableZone.ZoneId = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].ZoneId");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine> availableZone_supportedEngines = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine supportedEngine = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine();
					supportedEngine.Engine = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion> supportedEngine_supportedEngineVersions = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion();
						supportedEngineVersion.Version = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].Version");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory> supportedEngineVersion_supportedCategorys = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory supportedCategory = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory();
							supportedCategory.Category = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].Category");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType> supportedCategory_supportedStorageTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType supportedStorageType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType();
								supportedStorageType.StorageType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].StorageType");

								List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_AvailableResource> supportedStorageType_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_AvailableResource>();
								for (int n = 0; n < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].AvailableResources.Length"); n++) {
									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_AvailableResource();
									availableResource.DBInstanceClass = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].AvailableResources["+ n +"].DBInstanceClass");
									availableResource.StorageRange = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].AvailableResources["+ n +"].StorageRange");

									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_DBInstanceStorageRange dBInstanceStorageRange = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedCategory.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_DBInstanceStorageRange();
									dBInstanceStorageRange.Max = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].AvailableResources["+ n +"].DBInstanceStorageRange.Max");
									dBInstanceStorageRange.Min = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].AvailableResources["+ n +"].DBInstanceStorageRange.Min");
									dBInstanceStorageRange.Step = _ctx.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].AvailableResources["+ n +"].DBInstanceStorageRange.Step");
									availableResource.DBInstanceStorageRange = dBInstanceStorageRange;

									supportedStorageType_availableResources.Add(availableResource);
								}
								supportedStorageType.AvailableResources = supportedStorageType_availableResources;

								supportedCategory_supportedStorageTypes.Add(supportedStorageType);
							}
							supportedCategory.SupportedStorageTypes = supportedCategory_supportedStorageTypes;

							supportedEngineVersion_supportedCategorys.Add(supportedCategory);
						}
						supportedEngineVersion.SupportedCategorys = supportedEngineVersion_supportedCategorys;

						supportedEngine_supportedEngineVersions.Add(supportedEngineVersion);
					}
					supportedEngine.SupportedEngineVersions = supportedEngine_supportedEngineVersions;

					availableZone_supportedEngines.Add(supportedEngine);
				}
				availableZone.SupportedEngines = availableZone_supportedEngines;

				describeAvailableResourceResponse_availableZones.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZones = describeAvailableResourceResponse_availableZones;
        
			return describeAvailableResourceResponse;
        }
    }
}
