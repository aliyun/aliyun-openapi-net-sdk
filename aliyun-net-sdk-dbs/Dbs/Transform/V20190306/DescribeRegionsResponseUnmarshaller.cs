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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.Success = _ctx.BooleanValue("DescribeRegions.Success");
			describeRegionsResponse.ErrCode = _ctx.StringValue("DescribeRegions.ErrCode");
			describeRegionsResponse.ErrMessage = _ctx.StringValue("DescribeRegions.ErrMessage");
			describeRegionsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeRegions.HttpStatusCode");
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");

			List<string> describeRegionsResponse_regions = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Regions.Length"); i++) {
				describeRegionsResponse_regions.Add(_ctx.StringValue("DescribeRegions.Regions["+ i +"]"));
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
