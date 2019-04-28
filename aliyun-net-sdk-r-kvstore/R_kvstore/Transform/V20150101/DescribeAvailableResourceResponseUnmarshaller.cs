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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
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

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine> availableZone_supportedEngines = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine>();
				for (int j = 0; j < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine supportedEngine = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine();
					supportedEngine.Engine = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion> supportedEngine_supportedEngineVersions = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion>();
					for (int k = 0; k < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion();
						supportedEngineVersion.Version = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].Version");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType> supportedEngineVersion_supportedArchitectureTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType>();
						for (int l = 0; l < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType supportedArchitectureType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType();
							supportedArchitectureType.Architecture = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].Architecture");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType> supportedArchitectureType_supportedPerformanceTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType>();
							for (int m = 0; m < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType supportedPerformanceType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType();
								supportedPerformanceType.PerformanceType = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].PerformanceType");

								List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType> supportedPerformanceType_supportedStorageTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType>();
								for (int n = 0; n < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes.Length"); n++) {
									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType supportedStorageType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType();
									supportedStorageType.StorageType = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].StorageType");

									List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType> supportedStorageType_supportedNodeTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType>();
									for (int o = 0; o < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].SupportedNodeTypes.Length"); o++) {
										DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType supportedNodeType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType();
										supportedNodeType.NodeType = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].SupportedNodeTypes["+ o +"].NodeType");

										List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType> supportedNodeType_supportedPackageTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType>();
										for (int p = 0; p < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].SupportedNodeTypes["+ o +"].SupportedPackageTypes.Length"); p++) {
											DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType supportedPackageType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType();
											supportedPackageType.PackageType = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].SupportedNodeTypes["+ o +"].SupportedPackageTypes["+ p +"].PackageType");

											List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType.DescribeAvailableResource_AvailableResource> supportedPackageType_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType.DescribeAvailableResource_AvailableResource>();
											for (int q = 0; q < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].SupportedNodeTypes["+ o +"].SupportedPackageTypes["+ p +"].AvailableResources.Length"); q++) {
												DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedPerformanceType.DescribeAvailableResource_SupportedStorageType.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_SupportedPackageType.DescribeAvailableResource_AvailableResource();
												availableResource.InstanceClass = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersions["+ k +"].SupportedArchitectureTypes["+ l +"].SupportedPerformanceTypes["+ m +"].SupportedStorageTypes["+ n +"].SupportedNodeTypes["+ o +"].SupportedPackageTypes["+ p +"].AvailableResources["+ q +"].InstanceClass");

												supportedPackageType_availableResources.Add(availableResource);
											}
											supportedPackageType.AvailableResources = supportedPackageType_availableResources;

											supportedNodeType_supportedPackageTypes.Add(supportedPackageType);
										}
										supportedNodeType.SupportedPackageTypes = supportedNodeType_supportedPackageTypes;

										supportedStorageType_supportedNodeTypes.Add(supportedNodeType);
									}
									supportedStorageType.SupportedNodeTypes = supportedStorageType_supportedNodeTypes;

									supportedPerformanceType_supportedStorageTypes.Add(supportedStorageType);
								}
								supportedPerformanceType.SupportedStorageTypes = supportedPerformanceType_supportedStorageTypes;

								supportedArchitectureType_supportedPerformanceTypes.Add(supportedPerformanceType);
							}
							supportedArchitectureType.SupportedPerformanceTypes = supportedArchitectureType_supportedPerformanceTypes;

							supportedEngineVersion_supportedArchitectureTypes.Add(supportedArchitectureType);
						}
						supportedEngineVersion.SupportedArchitectureTypes = supportedEngineVersion_supportedArchitectureTypes;

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
