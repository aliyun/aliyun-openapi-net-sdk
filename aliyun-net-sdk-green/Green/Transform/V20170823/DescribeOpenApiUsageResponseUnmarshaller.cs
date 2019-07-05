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
        public static DescribeOpenApiUsageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOpenApiUsageResponse describeOpenApiUsageResponse = new DescribeOpenApiUsageResponse();

			describeOpenApiUsageResponse.HttpResponse = context.HttpResponse;
			describeOpenApiUsageResponse.RequestId = context.StringValue("DescribeOpenApiUsage.RequestId");
			describeOpenApiUsageResponse.TotalCount = context.IntegerValue("DescribeOpenApiUsage.TotalCount");

			List<DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage> describeOpenApiUsageResponse_openApiUsageList = new List<DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage>();
			for (int i = 0; i < context.Length("DescribeOpenApiUsage.OpenApiUsageList.Length"); i++) {
				DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage openApiUsage = new DescribeOpenApiUsageResponse.DescribeOpenApiUsage_OpenApiUsage();
				openApiUsage.Date = context.StringValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].Date");
				openApiUsage.ResourceType = context.StringValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].ResourceType");
				openApiUsage.Scene = context.StringValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].Scene");
				openApiUsage.TotalCount = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].TotalCount");
				openApiUsage.PassCount = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].PassCount");
				openApiUsage.ReviewCount = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].ReviewCount");
				openApiUsage.BlockCount = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].BlockCount");
				openApiUsage.InnerTotalCount = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].InnerTotalCount");
				openApiUsage.OuterTotalCount = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].OuterTotalCount");
				openApiUsage.TotalDuration = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].TotalDuration");
				openApiUsage.PassDuration = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].PassDuration");
				openApiUsage.ReviewDuration = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].ReviewDuration");
				openApiUsage.BlockDuration = context.IntegerValue("DescribeOpenApiUsage.OpenApiUsageList["+ i +"].BlockDuration");

				describeOpenApiUsageResponse_openApiUsageList.Add(openApiUsage);
			}
			describeOpenApiUsageResponse.OpenApiUsageList = describeOpenApiUsageResponse_openApiUsageList;
        
			return describeOpenApiUsageResponse;
        }
    }
}
