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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class ListResourceTypesResponseUnmarshaller
    {
        public static ListResourceTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceTypesResponse listResourceTypesResponse = new ListResourceTypesResponse();

			listResourceTypesResponse.HttpResponse = _ctx.HttpResponse;
			listResourceTypesResponse.DynamicCode = _ctx.StringValue("ListResourceTypes.DynamicCode");
			listResourceTypesResponse.DynamicMessage = _ctx.StringValue("ListResourceTypes.DynamicMessage");
			listResourceTypesResponse.ErrorCode = _ctx.StringValue("ListResourceTypes.ErrorCode");
			listResourceTypesResponse.ErrorMessage = _ctx.StringValue("ListResourceTypes.ErrorMessage");
			listResourceTypesResponse.RequestId = _ctx.StringValue("ListResourceTypes.RequestId");
			listResourceTypesResponse.Success = _ctx.BooleanValue("ListResourceTypes.Success");

			List<ListResourceTypesResponse.ListResourceTypes_ResourceType> listResourceTypesResponse_resourceTypes = new List<ListResourceTypesResponse.ListResourceTypes_ResourceType>();
			for (int i = 0; i < _ctx.Length("ListResourceTypes.ResourceTypes.Length"); i++) {
				ListResourceTypesResponse.ListResourceTypes_ResourceType resourceType = new ListResourceTypesResponse.ListResourceTypes_ResourceType();
				resourceType.Authorized = _ctx.BooleanValue("ListResourceTypes.ResourceTypes["+ i +"].Authorized");
				resourceType.ProductName = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].ProductName");
				resourceType.ResourceType = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].ResourceType");
				resourceType.ResourceTypeName = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].ResourceTypeName");

				List<string> resourceType_filterKeys = new List<string>();
				for (int j = 0; j < _ctx.Length("ListResourceTypes.ResourceTypes["+ i +"].FilterKeys.Length"); j++) {
					resourceType_filterKeys.Add(_ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].FilterKeys["+ j +"]"));
				}
				resourceType.FilterKeys = resourceType_filterKeys;

				ListResourceTypesResponse.ListResourceTypes_ResourceType.ListResourceTypes_CodeMapping codeMapping = new ListResourceTypesResponse.ListResourceTypes_ResourceType.ListResourceTypes_CodeMapping();
				codeMapping.ResourceGroup = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].CodeMapping.ResourceGroup");
				codeMapping.Tag = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].CodeMapping.Tag");
				resourceType.CodeMapping = codeMapping;

				ListResourceTypesResponse.ListResourceTypes_ResourceType.ListResourceTypes_Urls urls = new ListResourceTypesResponse.ListResourceTypes_ResourceType.ListResourceTypes_Urls();
				urls.ProductConsoleUrl = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].Urls.ProductConsoleUrl");
				urls.ResourceConsoleUrl = _ctx.StringValue("ListResourceTypes.ResourceTypes["+ i +"].Urls.ResourceConsoleUrl");
				resourceType.Urls = urls;

				listResourceTypesResponse_resourceTypes.Add(resourceType);
			}
			listResourceTypesResponse.ResourceTypes = listResourceTypesResponse_resourceTypes;
        
			return listResourceTypesResponse;
        }
    }
}
