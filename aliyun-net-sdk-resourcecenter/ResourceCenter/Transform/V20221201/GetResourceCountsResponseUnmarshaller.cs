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
    public class GetResourceCountsResponseUnmarshaller
    {
        public static GetResourceCountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResourceCountsResponse getResourceCountsResponse = new GetResourceCountsResponse();

			getResourceCountsResponse.HttpResponse = _ctx.HttpResponse;
			getResourceCountsResponse.GroupByKey = _ctx.StringValue("GetResourceCounts.GroupByKey");
			getResourceCountsResponse.RequestId = _ctx.StringValue("GetResourceCounts.RequestId");

			List<GetResourceCountsResponse.GetResourceCounts_Filter> getResourceCountsResponse_filters = new List<GetResourceCountsResponse.GetResourceCounts_Filter>();
			for (int i = 0; i < _ctx.Length("GetResourceCounts.Filters.Length"); i++) {
				GetResourceCountsResponse.GetResourceCounts_Filter filter = new GetResourceCountsResponse.GetResourceCounts_Filter();
				filter.Key = _ctx.StringValue("GetResourceCounts.Filters["+ i +"].Key");

				List<string> filter_values = new List<string>();
				for (int j = 0; j < _ctx.Length("GetResourceCounts.Filters["+ i +"].Values.Length"); j++) {
					filter_values.Add(_ctx.StringValue("GetResourceCounts.Filters["+ i +"].Values["+ j +"]"));
				}
				filter.Values = filter_values;

				getResourceCountsResponse_filters.Add(filter);
			}
			getResourceCountsResponse.Filters = getResourceCountsResponse_filters;

			List<GetResourceCountsResponse.GetResourceCounts_ResourceCount> getResourceCountsResponse_resourceCounts = new List<GetResourceCountsResponse.GetResourceCounts_ResourceCount>();
			for (int i = 0; i < _ctx.Length("GetResourceCounts.ResourceCounts.Length"); i++) {
				GetResourceCountsResponse.GetResourceCounts_ResourceCount resourceCount = new GetResourceCountsResponse.GetResourceCounts_ResourceCount();
				resourceCount.Count = _ctx.LongValue("GetResourceCounts.ResourceCounts["+ i +"].Count");
				resourceCount.GroupName = _ctx.StringValue("GetResourceCounts.ResourceCounts["+ i +"].GroupName");

				getResourceCountsResponse_resourceCounts.Add(resourceCount);
			}
			getResourceCountsResponse.ResourceCounts = getResourceCountsResponse_resourceCounts;
        
			return getResourceCountsResponse;
        }
    }
}
