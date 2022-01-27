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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeAvailableResourcesResponseUnmarshaller
    {
        public static DescribeAvailableResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableResourcesResponse describeAvailableResourcesResponse = new DescribeAvailableResourcesResponse();

			describeAvailableResourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableResourcesResponse.RequestId = _ctx.StringValue("DescribeAvailableResources.RequestId");
			describeAvailableResourcesResponse.RegionId = _ctx.StringValue("DescribeAvailableResources.RegionId");

			List<DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource> describeAvailableResourcesResponse_resources = new List<DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableResources.Resources.Length"); i++) {
				DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource resource = new DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource();
				resource.ZoneId = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].ZoneId");

				List<DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine> resource_supportedEngines = new List<DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableResources.Resources["+ i +"].SupportedEngines.Length"); j++) {
					DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine supportedEngine = new DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine();
					supportedEngine.SupportedEngineVersion = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedEngineVersion");
					supportedEngine.Mode = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].Mode");

					List<DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass> supportedEngine_supportedInstanceClasses = new List<DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses.Length"); k++) {
						DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass supportedInstanceClass = new DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass();
						supportedInstanceClass.Description = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].Description");
						supportedInstanceClass.DisplayClass = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].DisplayClass");
						supportedInstanceClass.InstanceClass = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].InstanceClass");
						supportedInstanceClass.StorageType = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].StorageType");

						DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass.DescribeAvailableResources_NodeCount nodeCount = new DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass.DescribeAvailableResources_NodeCount();
						nodeCount.Step = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].NodeCount.Step");
						nodeCount.MinCount = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].NodeCount.MinCount");
						nodeCount.MaxCount = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].NodeCount.MaxCount");
						supportedInstanceClass.NodeCount = nodeCount;

						DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass.DescribeAvailableResources_StorageSize storageSize = new DescribeAvailableResourcesResponse.DescribeAvailableResources_Resource.DescribeAvailableResources_SupportedEngine.DescribeAvailableResources_SupportedInstanceClass.DescribeAvailableResources_StorageSize();
						storageSize.Step = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].StorageSize.Step");
						storageSize.MinCount = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].StorageSize.MinCount");
						storageSize.MaxCount = _ctx.StringValue("DescribeAvailableResources.Resources["+ i +"].SupportedEngines["+ j +"].SupportedInstanceClasses["+ k +"].StorageSize.MaxCount");
						supportedInstanceClass.StorageSize = storageSize;

						supportedEngine_supportedInstanceClasses.Add(supportedInstanceClass);
					}
					supportedEngine.SupportedInstanceClasses = supportedEngine_supportedInstanceClasses;

					resource_supportedEngines.Add(supportedEngine);
				}
				resource.SupportedEngines = resource_supportedEngines;

				describeAvailableResourcesResponse_resources.Add(resource);
			}
			describeAvailableResourcesResponse.Resources = describeAvailableResourcesResponse_resources;
        
			return describeAvailableResourcesResponse;
        }
    }
}
