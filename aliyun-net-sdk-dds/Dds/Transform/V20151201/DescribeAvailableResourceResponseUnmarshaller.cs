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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableResourceResponse.RequestId = _ctx.StringValue("DescribeAvailableResource.RequestId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType> describeAvailableResourceResponse_supportedDBTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableResource.SupportedDBTypes.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType supportedDBType = new DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType();
				supportedDBType.DbType = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].DbType");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone> supportedDBType_availableZones = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone();
					availableZone.RegionId = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].RegionId");
					availableZone.ZoneId = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].ZoneId");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion> availableZone_supportedEngineVersions = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion();
						supportedEngineVersion.Version = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].Version");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine> supportedEngineVersion_supportedEngines = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine supportedEngine = new DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine();
							supportedEngine.Engine = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].Engine");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType> supportedEngine_supportedNodeTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType>();
							for (int m = 0; m < _ctx.Length("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].SupportedNodeTypes.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType supportedNodeType = new DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType();
								supportedNodeType.NodeType = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].SupportedNodeTypes["+ m +"].NodeType");
								supportedNodeType.NetworkTypes = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].SupportedNodeTypes["+ m +"].NetworkTypes");

								List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource> supportedNodeType_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource>();
								for (int n = 0; n < _ctx.Length("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].SupportedNodeTypes["+ m +"].AvailableResources.Length"); n++) {
									DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_SupportedDBType.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource();
									availableResource.InstanceClass = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].SupportedNodeTypes["+ m +"].AvailableResources["+ n +"].InstanceClass");
									availableResource.InstanceClassRemark = _ctx.StringValue("DescribeAvailableResource.SupportedDBTypes["+ i +"].AvailableZones["+ j +"].SupportedEngineVersions["+ k +"].SupportedEngines["+ l +"].SupportedNodeTypes["+ m +"].AvailableResources["+ n +"].InstanceClassRemark");

									supportedNodeType_availableResources.Add(availableResource);
								}
								supportedNodeType.AvailableResources = supportedNodeType_availableResources;

								supportedEngine_supportedNodeTypes.Add(supportedNodeType);
							}
							supportedEngine.SupportedNodeTypes = supportedEngine_supportedNodeTypes;

							supportedEngineVersion_supportedEngines.Add(supportedEngine);
						}
						supportedEngineVersion.SupportedEngines = supportedEngineVersion_supportedEngines;

						availableZone_supportedEngineVersions.Add(supportedEngineVersion);
					}
					availableZone.SupportedEngineVersions = availableZone_supportedEngineVersions;

					supportedDBType_availableZones.Add(availableZone);
				}
				supportedDBType.AvailableZones = supportedDBType_availableZones;

				describeAvailableResourceResponse_supportedDBTypes.Add(supportedDBType);
			}
			describeAvailableResourceResponse.SupportedDBTypes = describeAvailableResourceResponse_supportedDBTypes;
        
			return describeAvailableResourceResponse;
        }
    }
}
