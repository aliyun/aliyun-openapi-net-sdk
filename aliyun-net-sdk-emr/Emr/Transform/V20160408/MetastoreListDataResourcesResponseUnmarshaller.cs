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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreListDataResourcesResponseUnmarshaller
    {
        public static MetastoreListDataResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListDataResourcesResponse metastoreListDataResourcesResponse = new MetastoreListDataResourcesResponse();

			metastoreListDataResourcesResponse.HttpResponse = context.HttpResponse;
			metastoreListDataResourcesResponse.RequestId = context.StringValue("MetastoreListDataResources.RequestId");

			List<MetastoreListDataResourcesResponse.MetastoreListDataResources_DataResourceInfo> metastoreListDataResourcesResponse_dataResources = new List<MetastoreListDataResourcesResponse.MetastoreListDataResources_DataResourceInfo>();
			for (int i = 0; i < context.Length("MetastoreListDataResources.DataResources.Length"); i++) {
				MetastoreListDataResourcesResponse.MetastoreListDataResources_DataResourceInfo dataResourceInfo = new MetastoreListDataResourcesResponse.MetastoreListDataResources_DataResourceInfo();
				dataResourceInfo.Id = context.StringValue("MetastoreListDataResources.DataResources["+ i +"].Id");
				dataResourceInfo.RegionId = context.StringValue("MetastoreListDataResources.DataResources["+ i +"].RegionId");
				dataResourceInfo.Name = context.StringValue("MetastoreListDataResources.DataResources["+ i +"].Name");
				dataResourceInfo.MetaType = context.StringValue("MetastoreListDataResources.DataResources["+ i +"].MetaType");
				dataResourceInfo.ClusterId = context.LongValue("MetastoreListDataResources.DataResources["+ i +"].ClusterId");
				dataResourceInfo.AccessType = context.StringValue("MetastoreListDataResources.DataResources["+ i +"].AccessType");
				dataResourceInfo._Default = context.BooleanValue("MetastoreListDataResources.DataResources["+ i +"].Default");
				dataResourceInfo.Description = context.StringValue("MetastoreListDataResources.DataResources["+ i +"].Description");

				metastoreListDataResourcesResponse_dataResources.Add(dataResourceInfo);
			}
			metastoreListDataResourcesResponse.DataResources = metastoreListDataResourcesResponse_dataResources;
        
			return metastoreListDataResourcesResponse;
        }
    }
}
