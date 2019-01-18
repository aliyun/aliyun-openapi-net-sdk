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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListTagNamesResponseUnmarshaller
    {
        public static ListTagNamesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagNamesResponse listTagNamesResponse = new ListTagNamesResponse();

			listTagNamesResponse.HttpResponse = context.HttpResponse;
			listTagNamesResponse.RequestId = context.StringValue("ListTagNames.RequestId");
			listTagNamesResponse.NextMarker = context.StringValue("ListTagNames.NextMarker");

			List<ListTagNamesResponse.ListTagNames_TagsItem> listTagNamesResponse_tags = new List<ListTagNamesResponse.ListTagNames_TagsItem>();
			for (int i = 0; i < context.Length("ListTagNames.Tags.Length"); i++) {
				ListTagNamesResponse.ListTagNames_TagsItem tagsItem = new ListTagNamesResponse.ListTagNames_TagsItem();
				tagsItem.TagName = context.StringValue("ListTagNames.Tags["+ i +"].TagName");
				tagsItem.Num = context.IntegerValue("ListTagNames.Tags["+ i +"].Num");

				listTagNamesResponse_tags.Add(tagsItem);
			}
			listTagNamesResponse.Tags = listTagNamesResponse_tags;
        
			return listTagNamesResponse;
        }
    }
}