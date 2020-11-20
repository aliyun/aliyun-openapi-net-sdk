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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOpenApiUsageResponseUnmarshaller
    {
        public static DescribeOpenApiUsageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOpenApiUsageResponse describeOpenApiUsageResponse = new DescribeOpenApiUsageResponse();

			describeOpenApiUsageResponse.HttpResponse = _ctx.HttpResponse;
			describeOpenApiUsageResponse.RequestId = _ctx.StringValue("DescribeOpenApiUsage.RequestId");
			describeOpenApiUsageResponse.TotalCount = _ctx.IntegerValue("DescribeOpenApiUsage.TotalCount");

			List<DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage> describeOpenApiUsageResponse_openApiUsageList = new List<DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage>();
			for (int i = 0; i < _ctx.Length("DescribeOpenApiUsage.OpenApiUsageList.Length"); i++) {
				DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage openApiUsage = new DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage();
				openApiUsage.Date = _ctx.StringValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].Date");
				openApiUsage.ResourceType = _ctx.StringValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].ResourceType");
				openApiUsage.Scene = _ctx.StringValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].Scene");
				openApiUsage.TotalCount = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].TotalCount");
				openApiUsage.PassCount = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].PassCount");
				openApiUsage.ReviewCount = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].ReviewCount");
				openApiUsage.BlockCount = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].BlockCount");
				openApiUsage.InnerTotalCount = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].InnerTotalCount");
				openApiUsage.OuterTotalCount = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].OuterTotalCount");
				openApiUsage.TotalDuration = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].TotalDuration");
				openApiUsage.PassDuration = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].PassDuration");
				openApiUsage.ReviewDuration = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].ReviewDuration");
				openApiUsage.BlockDuration = _ctx.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].BlockDuration");

				describeOpenApiUsageResponse_openApiUsageList.Add(openApiUsage);
			}
			describeOpenApiUsageResponse.OpenApiUsageList = describeOpenApiUsageResponse_openApiUsageList;
        
			return describeOpenApiUsageResponse;
        }
    }
}
