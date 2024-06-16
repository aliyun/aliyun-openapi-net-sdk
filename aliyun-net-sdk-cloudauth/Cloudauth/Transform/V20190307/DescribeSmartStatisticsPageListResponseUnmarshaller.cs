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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeSmartStatisticsPageListResponseUnmarshaller
    {
        public static DescribeSmartStatisticsPageListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSmartStatisticsPageListResponse describeSmartStatisticsPageListResponse = new DescribeSmartStatisticsPageListResponse();

			describeSmartStatisticsPageListResponse.HttpResponse = _ctx.HttpResponse;
			describeSmartStatisticsPageListResponse.CurrentPage = _ctx.IntegerValue("DescribeSmartStatisticsPageList.CurrentPage");
			describeSmartStatisticsPageListResponse.TotalPage = _ctx.IntegerValue("DescribeSmartStatisticsPageList.TotalPage");
			describeSmartStatisticsPageListResponse.PageSize = _ctx.IntegerValue("DescribeSmartStatisticsPageList.PageSize");
			describeSmartStatisticsPageListResponse.RequestId = _ctx.StringValue("DescribeSmartStatisticsPageList.RequestId");
			describeSmartStatisticsPageListResponse.TotalCount = _ctx.IntegerValue("DescribeSmartStatisticsPageList.TotalCount");

			List<DescribeSmartStatisticsPageListResponse.DescribeSmartStatisticsPageList_ItemsItem> describeSmartStatisticsPageListResponse_items = new List<DescribeSmartStatisticsPageListResponse.DescribeSmartStatisticsPageList_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeSmartStatisticsPageList.Items.Length"); i++) {
				DescribeSmartStatisticsPageListResponse.DescribeSmartStatisticsPageList_ItemsItem itemsItem = new DescribeSmartStatisticsPageListResponse.DescribeSmartStatisticsPageList_ItemsItem();
				itemsItem.Date = _ctx.StringValue("DescribeSmartStatisticsPageList.Items["+ i +"].Date");
				itemsItem.SceneId = _ctx.LongValue("DescribeSmartStatisticsPageList.Items["+ i +"].SceneId");
				itemsItem.SceneName = _ctx.StringValue("DescribeSmartStatisticsPageList.Items["+ i +"].SceneName");
				itemsItem.TotalCount = _ctx.IntegerValue("DescribeSmartStatisticsPageList.Items["+ i +"].TotalCount");
				itemsItem.SuccessCount = _ctx.IntegerValue("DescribeSmartStatisticsPageList.Items["+ i +"].SuccessCount");
				itemsItem.PassRate = _ctx.StringValue("DescribeSmartStatisticsPageList.Items["+ i +"].PassRate");
				itemsItem.ProductCode = _ctx.StringValue("DescribeSmartStatisticsPageList.Items["+ i +"].ProductCode");

				describeSmartStatisticsPageListResponse_items.Add(itemsItem);
			}
			describeSmartStatisticsPageListResponse.Items = describeSmartStatisticsPageListResponse_items;
        
			return describeSmartStatisticsPageListResponse;
        }
    }
}
