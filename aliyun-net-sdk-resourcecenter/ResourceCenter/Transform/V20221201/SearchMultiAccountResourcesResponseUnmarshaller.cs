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
    public class SearchMultiAccountResourcesResponseUnmarshaller
    {
        public static SearchMultiAccountResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchMultiAccountResourcesResponse searchMultiAccountResourcesResponse = new SearchMultiAccountResourcesResponse();

			searchMultiAccountResourcesResponse.HttpResponse = _ctx.HttpResponse;
			searchMultiAccountResourcesResponse.RequestId = _ctx.StringValue("SearchMultiAccountResources.RequestId");
			searchMultiAccountResourcesResponse.NextToken = _ctx.StringValue("SearchMultiAccountResources.NextToken");
			searchMultiAccountResourcesResponse.Scope = _ctx.StringValue("SearchMultiAccountResources.Scope");
			searchMultiAccountResourcesResponse.MaxResults = _ctx.IntegerValue("SearchMultiAccountResources.MaxResults");

			List<SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Filter> searchMultiAccountResourcesResponse_filters = new List<SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Filter>();
			for (int i = 0; i < _ctx.Length("SearchMultiAccountResources.Filters.Length"); i++) {
				SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Filter filter = new SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Filter();
				filter.Key = _ctx.StringValue("SearchMultiAccountResources.Filters["+ i +"].Key");
				filter.MatchType = _ctx.StringValue("SearchMultiAccountResources.Filters["+ i +"].MatchType");

				List<string> filter_values = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMultiAccountResources.Filters["+ i +"].Values.Length"); j++) {
					filter_values.Add(_ctx.StringValue("SearchMultiAccountResources.Filters["+ i +"].Values["+ j +"]"));
				}
				filter.Values = filter_values;

				searchMultiAccountResourcesResponse_filters.Add(filter);
			}
			searchMultiAccountResourcesResponse.Filters = searchMultiAccountResourcesResponse_filters;

			List<SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource> searchMultiAccountResourcesResponse_resources = new List<SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource>();
			for (int i = 0; i < _ctx.Length("SearchMultiAccountResources.Resources.Length"); i++) {
				SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource resource = new SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource();
				resource.ResourceType = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].ResourceType");
				resource.CreateTime = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].CreateTime");
				resource.ResourceGroupId = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].ResourceGroupId");
				resource.ZoneId = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].ZoneId");
				resource.AccountId = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].AccountId");
				resource.ResourceId = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].ResourceId");
				resource.ResourceName = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].ResourceName");
				resource.RegionId = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].RegionId");

				List<string> resource_ipAddresses = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchMultiAccountResources.Resources["+ i +"].IpAddresses.Length"); j++) {
					resource_ipAddresses.Add(_ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].IpAddresses["+ j +"]"));
				}
				resource.IpAddresses = resource_ipAddresses;

				List<SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource.SearchMultiAccountResources_Tag> resource_tags = new List<SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource.SearchMultiAccountResources_Tag>();
				for (int j = 0; j < _ctx.Length("SearchMultiAccountResources.Resources["+ i +"].Tags.Length"); j++) {
					SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource.SearchMultiAccountResources_Tag tag = new SearchMultiAccountResourcesResponse.SearchMultiAccountResources_Resource.SearchMultiAccountResources_Tag();
					tag.Key = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("SearchMultiAccountResources.Resources["+ i +"].Tags["+ j +"].Value");

					resource_tags.Add(tag);
				}
				resource.Tags = resource_tags;

				searchMultiAccountResourcesResponse_resources.Add(resource);
			}
			searchMultiAccountResourcesResponse.Resources = searchMultiAccountResourcesResponse_resources;
        
			return searchMultiAccountResourcesResponse;
        }
    }
}
