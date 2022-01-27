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
    public class DescribeAvailableZonesResponseUnmarshaller
    {
        public static DescribeAvailableZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableZonesResponse describeAvailableZonesResponse = new DescribeAvailableZonesResponse();

			describeAvailableZonesResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableZonesResponse.RequestId = _ctx.StringValue("DescribeAvailableZones.RequestId");

			List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone> describeAvailableZonesResponse_availableZones = new List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableZones.AvailableZones.Length"); i++) {
				DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone availableZone = new DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone();
				availableZone.NetworkTypes = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].NetworkTypes");
				availableZone.RegionId = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].ZoneId");

				List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine> availableZone_supportedEngines = new List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine supportedEngine = new DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine();
					supportedEngine.Engine = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion> supportedEngine_supportedEngineVersions = new List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions.Length"); k++) {
						DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion();
						supportedEngineVersion.Version = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].Version");

						List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory> supportedEngineVersion_supportedCategorys = new List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys.Length"); l++) {
							DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory supportedCategory = new DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory();
							supportedCategory.Category = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].Category");

							List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory.DescribeAvailableZones_SupportedStorageType> supportedCategory_supportedStorageTypes = new List<DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory.DescribeAvailableZones_SupportedStorageType>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes.Length"); m++) {
								DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory.DescribeAvailableZones_SupportedStorageType supportedStorageType = new DescribeAvailableZonesResponse.DescribeAvailableZones_AvailableZone.DescribeAvailableZones_SupportedEngine.DescribeAvailableZones_SupportedEngineVersion.DescribeAvailableZones_SupportedCategory.DescribeAvailableZones_SupportedStorageType();
								supportedStorageType.StorageType = _ctx.StringValue("DescribeAvailableZones.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedCategorys["+ l +"].SupportedStorageTypes["+ m +"].StorageType");

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

				describeAvailableZonesResponse_availableZones.Add(availableZone);
			}
			describeAvailableZonesResponse.AvailableZones = describeAvailableZonesResponse_availableZones;
        
			return describeAvailableZonesResponse;
        }
    }
}
