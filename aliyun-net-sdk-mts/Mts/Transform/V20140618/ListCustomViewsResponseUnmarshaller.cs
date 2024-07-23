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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListCustomViewsResponseUnmarshaller
    {
        public static ListCustomViewsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomViewsResponse listCustomViewsResponse = new ListCustomViewsResponse();

			listCustomViewsResponse.HttpResponse = _ctx.HttpResponse;
			listCustomViewsResponse.RequestId = _ctx.StringValue("ListCustomViews.RequestId");
			listCustomViewsResponse.PageNumber = _ctx.IntegerValue("ListCustomViews.PageNumber");
			listCustomViewsResponse.PageSize = _ctx.IntegerValue("ListCustomViews.PageSize");
			listCustomViewsResponse.TotalCount = _ctx.LongValue("ListCustomViews.TotalCount");

			List<ListCustomViewsResponse.ListCustomViews_CustomView> listCustomViewsResponse_customViews = new List<ListCustomViewsResponse.ListCustomViews_CustomView>();
			for (int i = 0; i < _ctx.Length("ListCustomViews.CustomViews.Length"); i++) {
				ListCustomViewsResponse.ListCustomViews_CustomView customView = new ListCustomViewsResponse.ListCustomViews_CustomView();
				customView.CustomViewId = _ctx.StringValue("ListCustomViews.CustomViews["+ i +"].CustomViewId");
				customView.ImageUrl = _ctx.StringValue("ListCustomViews.CustomViews["+ i +"].ImageUrl");

				listCustomViewsResponse_customViews.Add(customView);
			}
			listCustomViewsResponse.CustomViews = listCustomViewsResponse_customViews;
        
			return listCustomViewsResponse;
        }
    }
}
