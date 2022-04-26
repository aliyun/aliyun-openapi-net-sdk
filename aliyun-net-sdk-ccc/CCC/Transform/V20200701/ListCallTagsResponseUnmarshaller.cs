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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListCallTagsResponseUnmarshaller
    {
        public static ListCallTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallTagsResponse listCallTagsResponse = new ListCallTagsResponse();

			listCallTagsResponse.HttpResponse = _ctx.HttpResponse;
			listCallTagsResponse.RequestId = _ctx.StringValue("ListCallTags.RequestId");
			listCallTagsResponse.HttpStatusCode = _ctx.IntegerValue("ListCallTags.HttpStatusCode");
			listCallTagsResponse.Code = _ctx.StringValue("ListCallTags.Code");
			listCallTagsResponse.Message = _ctx.StringValue("ListCallTags.Message");

			ListCallTagsResponse.ListCallTags_Data data = new ListCallTagsResponse.ListCallTags_Data();
			data.PageNumber = _ctx.IntegerValue("ListCallTags.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListCallTags.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListCallTags.Data.TotalCount");

			List<ListCallTagsResponse.ListCallTags_Data.ListCallTags_CallTag> data_list = new List<ListCallTagsResponse.ListCallTags_Data.ListCallTags_CallTag>();
			for (int i = 0; i < _ctx.Length("ListCallTags.Data.List.Length"); i++) {
				ListCallTagsResponse.ListCallTags_Data.ListCallTags_CallTag callTag = new ListCallTagsResponse.ListCallTags_Data.ListCallTags_CallTag();
				callTag.InstanceId = _ctx.StringValue("ListCallTags.Data.List["+ i +"].InstanceId");
				callTag.TagName = _ctx.StringValue("ListCallTags.Data.List["+ i +"].TagName");

				data_list.Add(callTag);
			}
			data.List = data_list;
			listCallTagsResponse.Data = data;
        
			return listCallTagsResponse;
        }
    }
}
