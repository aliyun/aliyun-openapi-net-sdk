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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListLibraryStatusResponseUnmarshaller
    {
        public static ListLibraryStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLibraryStatusResponse listLibraryStatusResponse = new ListLibraryStatusResponse();

			listLibraryStatusResponse.HttpResponse = _ctx.HttpResponse;
			listLibraryStatusResponse.RequestId = _ctx.StringValue("ListLibraryStatus.RequestId");
			listLibraryStatusResponse.PageNumber = _ctx.IntegerValue("ListLibraryStatus.PageNumber");
			listLibraryStatusResponse.PageSize = _ctx.IntegerValue("ListLibraryStatus.PageSize");
			listLibraryStatusResponse.TotalCount = _ctx.IntegerValue("ListLibraryStatus.TotalCount");
			listLibraryStatusResponse.NextToken = _ctx.StringValue("ListLibraryStatus.NextToken");

			List<ListLibraryStatusResponse.ListLibraryStatus_Item> listLibraryStatusResponse_items = new List<ListLibraryStatusResponse.ListLibraryStatus_Item>();
			for (int i = 0; i < _ctx.Length("ListLibraryStatus.Items.Length"); i++) {
				ListLibraryStatusResponse.ListLibraryStatus_Item item = new ListLibraryStatusResponse.ListLibraryStatus_Item();
				item.LibraryBizId = _ctx.StringValue("ListLibraryStatus.Items["+ i +"].LibraryBizId");
				item.LibraryName = _ctx.StringValue("ListLibraryStatus.Items["+ i +"].LibraryName");
				item.ClusterBizId = _ctx.StringValue("ListLibraryStatus.Items["+ i +"].ClusterBizId");
				item.ClusterName = _ctx.StringValue("ListLibraryStatus.Items["+ i +"].ClusterName");
				item.Status = _ctx.StringValue("ListLibraryStatus.Items["+ i +"].Status");

				listLibraryStatusResponse_items.Add(item);
			}
			listLibraryStatusResponse.Items = listLibraryStatusResponse_items;
        
			return listLibraryStatusResponse;
        }
    }
}
