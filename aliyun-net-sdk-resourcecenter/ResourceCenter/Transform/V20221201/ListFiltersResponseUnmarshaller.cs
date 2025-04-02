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
    public class ListFiltersResponseUnmarshaller
    {
        public static ListFiltersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFiltersResponse listFiltersResponse = new ListFiltersResponse();

			listFiltersResponse.HttpResponse = _ctx.HttpResponse;
			listFiltersResponse.DefaultFilterName = _ctx.StringValue("ListFilters.DefaultFilterName");
			listFiltersResponse.RequestId = _ctx.StringValue("ListFilters.RequestId");

			List<ListFiltersResponse.ListFilters_Filter> listFiltersResponse_filters = new List<ListFiltersResponse.ListFilters_Filter>();
			for (int i = 0; i < _ctx.Length("ListFilters.Filters.Length"); i++) {
				ListFiltersResponse.ListFilters_Filter filter = new ListFiltersResponse.ListFilters_Filter();
				filter.FilterConfiguration = _ctx.StringValue("ListFilters.Filters["+ i +"].FilterConfiguration");
				filter.FilterName = _ctx.StringValue("ListFilters.Filters["+ i +"].FilterName");

				listFiltersResponse_filters.Add(filter);
			}
			listFiltersResponse.Filters = listFiltersResponse_filters;
        
			return listFiltersResponse;
        }
    }
}
