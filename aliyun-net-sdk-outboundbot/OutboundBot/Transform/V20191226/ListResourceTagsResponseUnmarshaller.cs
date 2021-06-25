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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListResourceTagsResponseUnmarshaller
    {
        public static ListResourceTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceTagsResponse listResourceTagsResponse = new ListResourceTagsResponse();

			listResourceTagsResponse.HttpResponse = _ctx.HttpResponse;
			listResourceTagsResponse.RequestId = _ctx.StringValue("ListResourceTags.RequestId");
			listResourceTagsResponse.Success = _ctx.BooleanValue("ListResourceTags.Success");
			listResourceTagsResponse.Code = _ctx.StringValue("ListResourceTags.Code");
			listResourceTagsResponse.Message = _ctx.StringValue("ListResourceTags.Message");
			listResourceTagsResponse.HttpStatusCode = _ctx.IntegerValue("ListResourceTags.HttpStatusCode");

			ListResourceTagsResponse.ListResourceTags_ResourceTags resourceTags = new ListResourceTagsResponse.ListResourceTags_ResourceTags();
			resourceTags.TotalCount = _ctx.IntegerValue("ListResourceTags.ResourceTags.TotalCount");
			resourceTags.PageNumber = _ctx.IntegerValue("ListResourceTags.ResourceTags.PageNumber");
			resourceTags.PageSize = _ctx.IntegerValue("ListResourceTags.ResourceTags.PageSize");

			List<ListResourceTagsResponse.ListResourceTags_ResourceTags.ListResourceTags_ResourceTag> resourceTags_list = new List<ListResourceTagsResponse.ListResourceTags_ResourceTags.ListResourceTags_ResourceTag>();
			for (int i = 0; i < _ctx.Length("ListResourceTags.ResourceTags.List.Length"); i++) {
				ListResourceTagsResponse.ListResourceTags_ResourceTags.ListResourceTags_ResourceTag resourceTag = new ListResourceTagsResponse.ListResourceTags_ResourceTags.ListResourceTags_ResourceTag();
				resourceTag.Key = _ctx.StringValue("ListResourceTags.ResourceTags.List["+ i +"].Key");
				resourceTag._Value = _ctx.StringValue("ListResourceTags.ResourceTags.List["+ i +"].Value");

				resourceTags_list.Add(resourceTag);
			}
			resourceTags.List = resourceTags_list;
			listResourceTagsResponse.ResourceTags = resourceTags;
        
			return listResourceTagsResponse;
        }
    }
}
