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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class ListProductDimensionGroupsResponseUnmarshaller
    {
        public static ListProductDimensionGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProductDimensionGroupsResponse listProductDimensionGroupsResponse = new ListProductDimensionGroupsResponse();

			listProductDimensionGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listProductDimensionGroupsResponse.TotalCount = _ctx.IntegerValue("ListProductDimensionGroups.TotalCount");
			listProductDimensionGroupsResponse.RequestId = _ctx.StringValue("ListProductDimensionGroups.RequestId");
			listProductDimensionGroupsResponse.NextToken = _ctx.StringValue("ListProductDimensionGroups.NextToken");
			listProductDimensionGroupsResponse.MaxResults = _ctx.IntegerValue("ListProductDimensionGroups.MaxResults");

			List<ListProductDimensionGroupsResponse.ListProductDimensionGroups_DimensionGroupsItem> listProductDimensionGroupsResponse_dimensionGroups = new List<ListProductDimensionGroupsResponse.ListProductDimensionGroups_DimensionGroupsItem>();
			for (int i = 0; i < _ctx.Length("ListProductDimensionGroups.DimensionGroups.Length"); i++) {
				ListProductDimensionGroupsResponse.ListProductDimensionGroups_DimensionGroupsItem dimensionGroupsItem = new ListProductDimensionGroupsResponse.ListProductDimensionGroups_DimensionGroupsItem();
				dimensionGroupsItem.GroupName = _ctx.StringValue("ListProductDimensionGroups.DimensionGroups["+ i +"].GroupName");
				dimensionGroupsItem.ProductCode = _ctx.StringValue("ListProductDimensionGroups.DimensionGroups["+ i +"].ProductCode");
				dimensionGroupsItem.GroupCode = _ctx.StringValue("ListProductDimensionGroups.DimensionGroups["+ i +"].GroupCode");

				List<string> dimensionGroupsItem_dimensionKeys = new List<string>();
				for (int j = 0; j < _ctx.Length("ListProductDimensionGroups.DimensionGroups["+ i +"].DimensionKeys.Length"); j++) {
					dimensionGroupsItem_dimensionKeys.Add(_ctx.StringValue("ListProductDimensionGroups.DimensionGroups["+ i +"].DimensionKeys["+ j +"]"));
				}
				dimensionGroupsItem.DimensionKeys = dimensionGroupsItem_dimensionKeys;

				listProductDimensionGroupsResponse_dimensionGroups.Add(dimensionGroupsItem);
			}
			listProductDimensionGroupsResponse.DimensionGroups = listProductDimensionGroupsResponse_dimensionGroups;
        
			return listProductDimensionGroupsResponse;
        }
    }
}
