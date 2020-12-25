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
    public class ListLibrariesResponseUnmarshaller
    {
        public static ListLibrariesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLibrariesResponse listLibrariesResponse = new ListLibrariesResponse();

			listLibrariesResponse.HttpResponse = _ctx.HttpResponse;
			listLibrariesResponse.RequestId = _ctx.StringValue("ListLibraries.RequestId");
			listLibrariesResponse.PageNumber = _ctx.IntegerValue("ListLibraries.PageNumber");
			listLibrariesResponse.PageSize = _ctx.IntegerValue("ListLibraries.PageSize");
			listLibrariesResponse.TotalCount = _ctx.IntegerValue("ListLibraries.TotalCount");
			listLibrariesResponse.NextToken = _ctx.StringValue("ListLibraries.NextToken");

			List<ListLibrariesResponse.ListLibraries_Item> listLibrariesResponse_items = new List<ListLibrariesResponse.ListLibraries_Item>();
			for (int i = 0; i < _ctx.Length("ListLibraries.Items.Length"); i++) {
				ListLibrariesResponse.ListLibraries_Item item = new ListLibrariesResponse.ListLibraries_Item();
				item.BizId = _ctx.StringValue("ListLibraries.Items["+ i +"].BizId");
				item.CreateTime = _ctx.LongValue("ListLibraries.Items["+ i +"].CreateTime");
				item.Type = _ctx.StringValue("ListLibraries.Items["+ i +"].Type");
				item.Name = _ctx.StringValue("ListLibraries.Items["+ i +"].Name");
				item.LibraryVersion = _ctx.StringValue("ListLibraries.Items["+ i +"].LibraryVersion");
				item.SourceType = _ctx.StringValue("ListLibraries.Items["+ i +"].SourceType");
				item.SourceLocation = _ctx.StringValue("ListLibraries.Items["+ i +"].SourceLocation");
				item.Scope = _ctx.StringValue("ListLibraries.Items["+ i +"].Scope");
				item.Properties = _ctx.StringValue("ListLibraries.Items["+ i +"].Properties");
				item.UserId = _ctx.StringValue("ListLibraries.Items["+ i +"].UserId");

				listLibrariesResponse_items.Add(item);
			}
			listLibrariesResponse.Items = listLibrariesResponse_items;
        
			return listLibrariesResponse;
        }
    }
}
