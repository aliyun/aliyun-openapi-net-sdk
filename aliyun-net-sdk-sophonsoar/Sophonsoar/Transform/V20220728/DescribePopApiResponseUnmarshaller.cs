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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribePopApiResponseUnmarshaller
    {
        public static DescribePopApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePopApiResponse describePopApiResponse = new DescribePopApiResponse();

			describePopApiResponse.HttpResponse = _ctx.HttpResponse;
			describePopApiResponse.RequestId = _ctx.StringValue("DescribePopApi.RequestId");
			describePopApiResponse.PopCode = _ctx.StringValue("DescribePopApi.PopCode");
			describePopApiResponse.Version = _ctx.StringValue("DescribePopApi.Version");
			describePopApiResponse.ApiName = _ctx.StringValue("DescribePopApi.ApiName");
			describePopApiResponse.ApiMeta = _ctx.StringValue("DescribePopApi.ApiMeta");

			List<DescribePopApiResponse.DescribePopApi_OpenApiMetaListItem> describePopApiResponse_openApiMetaList = new List<DescribePopApiResponse.DescribePopApi_OpenApiMetaListItem>();
			for (int i = 0; i < _ctx.Length("DescribePopApi.OpenApiMetaList.Length"); i++) {
				DescribePopApiResponse.DescribePopApi_OpenApiMetaListItem openApiMetaListItem = new DescribePopApiResponse.DescribePopApi_OpenApiMetaListItem();
				openApiMetaListItem.Name = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].Name");
				openApiMetaListItem.Required = _ctx.BooleanValue("DescribePopApi.OpenApiMetaList["+ i +"].Required");
				openApiMetaListItem.ExampleValue = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].ExampleValue");
				openApiMetaListItem.Description = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].Description");
				openApiMetaListItem._In = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].In");
				openApiMetaListItem.Visibility = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].Visibility");
				openApiMetaListItem.Type = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].Type");
				openApiMetaListItem.IsRequired = _ctx.BooleanValue("DescribePopApi.OpenApiMetaList["+ i +"].IsRequired");
				openApiMetaListItem.Style = _ctx.StringValue("DescribePopApi.OpenApiMetaList["+ i +"].Style");

				describePopApiResponse_openApiMetaList.Add(openApiMetaListItem);
			}
			describePopApiResponse.OpenApiMetaList = describePopApiResponse_openApiMetaList;
        
			return describePopApiResponse;
        }
    }
}
