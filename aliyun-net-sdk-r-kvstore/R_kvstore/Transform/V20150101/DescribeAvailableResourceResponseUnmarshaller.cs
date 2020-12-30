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
				availableZone.Status = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].Status");
				availableZone.NetworkTypes = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].NetworkTypes");
				availableZone.ZoneName = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].ZoneName");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine> availableZone_supportedEngines = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine supportedEngine = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine();
					supportedEngine.Engine = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType> supportedEngine_supportedEditionTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType supportedEditionType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType();
						supportedEditionType.EditionType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].EditionType");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType> supportedEditionType_supportedSeriesTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType supportedSeriesType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType();
							supportedSeriesType.SeriesType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SeriesType");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion> supportedSeriesType_supportedEngineVersions = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion();
								supportedEngineVersion.Version = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].Version");

								List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType> supportedEngineVersion_supportedArchitectureTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType>();
								for (int n = 0; n < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes.Length"); n++) {
									DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType supportedArchitectureType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType();
									supportedArchitectureType.Architecture = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].Architecture");

									List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber> supportedArchitectureType_supportedShardNumbers = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber>();
									for (int o = 0; o < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers.Length"); o++) {
										DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber supportedShardNumber = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber();
										supportedShardNumber.ShardNumber = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers["+ o +"].ShardNumber");

										List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType> supportedShardNumber_supportedNodeTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType>();
										for (int p = 0; p < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers["+ o +"].SupportedNodeTypes.Length"); p++) {
											DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType supportedNodeType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType();
											supportedNodeType.SupportedNodeType = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers["+ o +"].SupportedNodeTypes["+ p +"].SupportedNodeType");

											List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource> supportedNodeType_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource>();
											for (int q = 0; q < _ctx.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers["+ o +"].SupportedNodeTypes["+ p +"].AvailableResources.Length"); q++) {
												DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedEditionType.DescribeAvailableResource_SupportedSeriesType.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedArchitectureType.DescribeAvailableResource_SupportedShardNumber.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource();
												availableResource.InstanceClass = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers["+ o +"].SupportedNodeTypes["+ p +"].AvailableResources["+ q +"].InstanceClass");
												availableResource.InstanceClassRemark = _ctx.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngines["+ j +"].SupportedEditionTypes["+ k +"].SupportedSeriesTypes["+ l +"].SupportedEngineVersions["+ m +"].SupportedArchitectureTypes["+ n +"].SupportedShardNumbers["+ o +"].SupportedNodeTypes["+ p +"].AvailableResources["+ q +"].InstanceClassRemark");

												supportedNodeType_availableResources.Add(availableResource);
											}
											supportedNodeType.AvailableResources = supportedNodeType_availableResources;

											supportedShardNumber_supportedNodeTypes.Add(supportedNodeType);
										}
										supportedShardNumber.SupportedNodeTypes = supportedShardNumber_supportedNodeTypes;

										supportedArchitectureType_supportedShardNumbers.Add(supportedShardNumber);
									}
									supportedArchitectureType.SupportedShardNumbers = supportedArchitectureType_supportedShardNumbers;

									supportedEngineVersion_supportedArchitectureTypes.Add(supportedArchitectureType);
								}
								supportedEngineVersion.SupportedArchitectureTypes = supportedEngineVersion_supportedArchitectureTypes;

								supportedSeriesType_supportedEngineVersions.Add(supportedEngineVersion);
							}
							supportedSeriesType.SupportedEngineVersions = supportedSeriesType_supportedEngineVersions;

							supportedEditionType_supportedSeriesTypes.Add(supportedSeriesType);
						}
						supportedEditionType.SupportedSeriesTypes = supportedEditionType_supportedSeriesTypes;

						supportedEngine_supportedEditionTypes.Add(supportedEditionType);
					}
					supportedEngine.SupportedEditionTypes = supportedEngine_supportedEditionTypes;

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
