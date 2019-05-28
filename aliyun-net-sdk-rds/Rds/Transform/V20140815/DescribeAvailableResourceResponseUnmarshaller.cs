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
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = context.HttpResponse;
			describeAvailableResourceResponse.RequestId = context.StringValue("DescribeAvailableResource.RequestId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone> describeAvailableResourceResponse_availableZones = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone>();
			for (int i = 0; i < context.Length("DescribeAvailableResource.AvailableZones.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone();
				availableZone.RegionId = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].ZoneId");
				availableZone.Status = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].Status");
				availableZone.NetworkTypes = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].NetworkTypes");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines> availableZone_supportedEngine = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines>();
				for (int j = 0; j < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines supportedEngines = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines();
					supportedEngines.Engine = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].Engine");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions> supportedEngines_supportedEngineVersion = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions>();
					for (int k = 0; k < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions supportedEngineVersions = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions();
						supportedEngineVersions.Version = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].Version");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys> supportedEngineVersions_supportedCategory = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys>();
						for (int l = 0; l < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys supportedCategorys = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys();
							supportedCategorys.Category = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].Category");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes> supportedCategorys_supportedStorageType = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes>();
							for (int m = 0; m < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes supportedStorageTypes = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes();
								supportedStorageTypes.StorageType = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].StorageType");

								List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes.DescribeAvailableResource_AvailableResources> supportedStorageTypes_availableResource = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes.DescribeAvailableResource_AvailableResources>();
								for (int n = 0; n < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].AvailableResource.Length"); n++) {
									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes.DescribeAvailableResource_AvailableResources availableResources = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngines.DescribeAvailableResource_SupportedEngineVersions.DescribeAvailableResource_SupportedCategorys.DescribeAvailableResource_SupportedStorageTypes.DescribeAvailableResource_AvailableResources();
									availableResources.DBInstanceClass = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].AvailableResource["+ n +"].DBInstanceClass");
									availableResources.StorageRange = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].AvailableResource["+ n +"].StorageRange");

									supportedStorageTypes_availableResource.Add(availableResources);
								}
								supportedStorageTypes.AvailableResource = supportedStorageTypes_availableResource;

								supportedCategorys_supportedStorageType.Add(supportedStorageTypes);
							}
							supportedCategorys.SupportedStorageType = supportedCategorys_supportedStorageType;

							supportedEngineVersions_supportedCategory.Add(supportedCategorys);
						}
						supportedEngineVersions.SupportedCategory = supportedEngineVersions_supportedCategory;

						supportedEngines_supportedEngineVersion.Add(supportedEngineVersions);
					}
					supportedEngines.SupportedEngineVersion = supportedEngines_supportedEngineVersion;

					availableZone_supportedEngine.Add(supportedEngines);
				}
				availableZone.SupportedEngine = availableZone_supportedEngine;

				describeAvailableResourceResponse_availableZones.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZones = describeAvailableResourceResponse_availableZones;
        
			return describeAvailableResourceResponse;
        }
    }
}
