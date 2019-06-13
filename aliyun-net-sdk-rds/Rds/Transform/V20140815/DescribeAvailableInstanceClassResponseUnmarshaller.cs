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
    public class DescribeAvailableInstanceClassResponseUnmarshaller
    {
        public static DescribeAvailableInstanceClassResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableInstanceClassResponse describeAvailableInstanceClassResponse = new DescribeAvailableInstanceClassResponse();

			describeAvailableInstanceClassResponse.HttpResponse = context.HttpResponse;
			describeAvailableInstanceClassResponse.RequestId = context.StringValue("DescribeAvailableInstanceClass.RequestId");

			List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone> describeAvailableInstanceClassResponse_availableZones = new List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone>();
			for (int i = 0; i < context.Length("DescribeAvailableInstanceClass.AvailableZones.Length"); i++) {
				DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone availableZone = new DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone();
				availableZone.RegionId = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].ZoneId");
				availableZone.Status = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].Status");
				availableZone.NetworkTypes = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].NetworkTypes");

				List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines> availableZone_supportedEngine = new List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines>();
				for (int j = 0; j < context.Length("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine.Length"); j++) {
					DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines supportedEngines = new DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines();
					supportedEngines.Engine = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].Engine");

					List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions> supportedEngines_supportedEngineVersion = new List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions>();
					for (int k = 0; k < context.Length("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion.Length"); k++) {
						DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions supportedEngineVersions = new DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions();
						supportedEngineVersions.Version = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].Version");

						List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys> supportedEngineVersions_supportedCategory = new List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys>();
						for (int l = 0; l < context.Length("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory.Length"); l++) {
							DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys supportedCategorys = new DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys();
							supportedCategorys.Category = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].Category");

							List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes> supportedCategorys_supportedStorageType = new List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes>();
							for (int m = 0; m < context.Length("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType.Length"); m++) {
								DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes supportedStorageTypes = new DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes();
								supportedStorageTypes.StorageType = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].StorageType");

								List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes.DescribeAvailableInstanceClass_AvailableResources> supportedStorageTypes_availableResource = new List<DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes.DescribeAvailableInstanceClass_AvailableResources>();
								for (int n = 0; n < context.Length("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].AvailableResource.Length"); n++) {
									DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes.DescribeAvailableInstanceClass_AvailableResources availableResources = new DescribeAvailableInstanceClassResponse.DescribeAvailableInstanceClass_AvailableZone.DescribeAvailableInstanceClass_SupportedEngines.DescribeAvailableInstanceClass_SupportedEngineVersions.DescribeAvailableInstanceClass_SupportedCategorys.DescribeAvailableInstanceClass_SupportedStorageTypes.DescribeAvailableInstanceClass_AvailableResources();
									availableResources.DBInstanceClass = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].AvailableResource["+ n +"].DBInstanceClass");
									availableResources.StorageRange = context.StringValue("DescribeAvailableInstanceClass.AvailableZones["+ i +"].SupportedEngine["+ j +"].SupportedEngineVersion["+ k +"].SupportedCategory["+ l +"].SupportedStorageType["+ m +"].AvailableResource["+ n +"].StorageRange");

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

				describeAvailableInstanceClassResponse_availableZones.Add(availableZone);
			}
			describeAvailableInstanceClassResponse.AvailableZones = describeAvailableInstanceClassResponse_availableZones;
        
			return describeAvailableInstanceClassResponse;
        }
    }
}
