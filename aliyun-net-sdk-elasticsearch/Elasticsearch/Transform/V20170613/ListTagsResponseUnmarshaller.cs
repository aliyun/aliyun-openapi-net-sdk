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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListTagsResponseUnmarshaller
    {
        public static ListTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagsResponse listTagsResponse = new ListTagsResponse();

			listTagsResponse.HttpResponse = _ctx.HttpResponse;
			listTagsResponse.RequestId = _ctx.StringValue("ListTags.RequestId");

			List<ListTagsResponse.ListTags_ResultItem> listTagsResponse_result = new List<ListTagsResponse.ListTags_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListTags.Result.Length"); i++) {
				ListTagsResponse.ListTags_ResultItem resultItem = new ListTagsResponse.ListTags_ResultItem();
				resultItem.TagKey = _ctx.StringValue("ListTags.Result["+ i +"].TagKey");
				resultItem.TagValue = _ctx.StringValue("ListTags.Result["+ i +"].TagValue");

				listTagsResponse_result.Add(resultItem);
			}
			listTagsResponse.Result = listTagsResponse_result;
        
			return listTagsResponse;
        }
    }
}
