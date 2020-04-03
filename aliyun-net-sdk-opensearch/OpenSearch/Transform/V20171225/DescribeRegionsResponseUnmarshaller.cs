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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.Request_id = context.StringValue("DescribeRegions.request_id");
			describeRegionsResponse.Status = context.StringValue("DescribeRegions.status");

			List<DescribeRegionsResponse.DescribeRegions_Error> describeRegionsResponse_errors = new List<DescribeRegionsResponse.DescribeRegions_Error>();
			for (int i = 0; i < context.Length("DescribeRegions.Errors.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Error error = new DescribeRegionsResponse.DescribeRegions_Error();
				error.Code = context.IntegerValue("DescribeRegions.Errors["+ i +"].code");
				error.Message = context.StringValue("DescribeRegions.Errors["+ i +"].message");

				describeRegionsResponse_errors.Add(error);
			}
			describeRegionsResponse.Errors = describeRegionsResponse_errors;
        
			return describeRegionsResponse;
        }
    }
}
