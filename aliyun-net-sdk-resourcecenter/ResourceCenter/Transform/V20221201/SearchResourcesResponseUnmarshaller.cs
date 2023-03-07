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
    public class SearchResourcesResponseUnmarshaller
    {
        public static SearchResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchResourcesResponse searchResourcesResponse = new SearchResourcesResponse();

			searchResourcesResponse.HttpResponse = _ctx.HttpResponse;
			searchResourcesResponse.NextToken = _ctx.StringValue("SearchResources.NextToken");
			searchResourcesResponse.RequestId = _ctx.StringValue("SearchResources.RequestId");
			searchResourcesResponse.MaxResults = _ctx.IntegerValue("SearchResources.MaxResults");

			List<SearchResourcesResponse.SearchResources_Filter> searchResourcesResponse_filters = new List<SearchResourcesResponse.SearchResources_Filter>();
			for (int i = 0; i < _ctx.Length("SearchResources.Filters.Length"); i++) {
				SearchResourcesResponse.SearchResources_Filter filter = new SearchResourcesResponse.SearchResources_Filter();
				filter.Key = _ctx.StringValue("SearchResources.Filters["+ i +"].Key");
				filter.MatchType = _ctx.StringValue("SearchResources.Filters["+ i +"].MatchType");

				List<string> filter_values = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchResources.Filters["+ i +"].Values.Length"); j++) {
					filter_values.Add(_ctx.StringValue("SearchResources.Filters["+ i +"].Values["+ j +"]"));
				}
				filter.Values = filter_values;

				searchResourcesResponse_filters.Add(filter);
			}
			searchResourcesResponse.Filters = searchResourcesResponse_filters;

			List<SearchResourcesResponse.SearchResources_Resource> searchResourcesResponse_resources = new List<SearchResourcesResponse.SearchResources_Resource>();
			for (int i = 0; i < _ctx.Length("SearchResources.Resources.Length"); i++) {
				SearchResourcesResponse.SearchResources_Resource resource = new SearchResourcesResponse.SearchResources_Resource();
				resource.ResourceType = _ctx.StringValue("SearchResources.Resources["+ i +"].ResourceType");
				resource.CreateTime = _ctx.StringValue("SearchResources.Resources["+ i +"].CreateTime");
				resource.ResourceGroupId = _ctx.StringValue("SearchResources.Resources["+ i +"].ResourceGroupId");
				resource.ZoneId = _ctx.StringValue("SearchResources.Resources["+ i +"].ZoneId");
				resource.AccountId = _ctx.StringValue("SearchResources.Resources["+ i +"].AccountId");
				resource.ResourceId = _ctx.StringValue("SearchResources.Resources["+ i +"].ResourceId");
				resource.ResourceName = _ctx.StringValue("SearchResources.Resources["+ i +"].ResourceName");
				resource.RegionId = _ctx.StringValue("SearchResources.Resources["+ i +"].RegionId");

				List<string> resource_ipAddresses = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchResources.Resources["+ i +"].IpAddresses.Length"); j++) {
					resource_ipAddresses.Add(_ctx.StringValue("SearchResources.Resources["+ i +"].IpAddresses["+ j +"]"));
				}
				resource.IpAddresses = resource_ipAddresses;

				List<SearchResourcesResponse.SearchResources_Resource.SearchResources_Tag> resource_tags = new List<SearchResourcesResponse.SearchResources_Resource.SearchResources_Tag>();
				for (int j = 0; j < _ctx.Length("SearchResources.Resources["+ i +"].Tags.Length"); j++) {
					SearchResourcesResponse.SearchResources_Resource.SearchResources_Tag tag = new SearchResourcesResponse.SearchResources_Resource.SearchResources_Tag();
					tag.Key = _ctx.StringValue("SearchResources.Resources["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("SearchResources.Resources["+ i +"].Tags["+ j +"].Value");

					resource_tags.Add(tag);
				}
				resource.Tags = resource_tags;

				searchResourcesResponse_resources.Add(resource);
			}
			searchResourcesResponse.Resources = searchResourcesResponse_resources;
        
			return searchResourcesResponse;
        }
    }
}
