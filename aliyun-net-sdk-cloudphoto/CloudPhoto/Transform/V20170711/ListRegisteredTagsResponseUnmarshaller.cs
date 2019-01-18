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
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class ListRegisteredTagsResponseUnmarshaller
    {
        public static ListRegisteredTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListRegisteredTagsResponse listRegisteredTagsResponse = new ListRegisteredTagsResponse();

			listRegisteredTagsResponse.HttpResponse = context.HttpResponse;
			listRegisteredTagsResponse.Code = context.StringValue("ListRegisteredTags.Code");
			listRegisteredTagsResponse.Message = context.StringValue("ListRegisteredTags.Message");
			listRegisteredTagsResponse.RequestId = context.StringValue("ListRegisteredTags.RequestId");
			listRegisteredTagsResponse.Action = context.StringValue("ListRegisteredTags.Action");

			List<ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag> listRegisteredTagsResponse_registeredTags = new List<ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag>();
			for (int i = 0; i < context.Length("ListRegisteredTags.RegisteredTags.Length"); i++) {
				ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag registeredTag = new ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag();
				registeredTag.TagKey = context.StringValue("ListRegisteredTags.RegisteredTags["+ i +"].TagKey");

				List<ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag.ListRegisteredTags_TagValue> registeredTag_tagValues = new List<ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag.ListRegisteredTags_TagValue>();
				for (int j = 0; j < context.Length("ListRegisteredTags.RegisteredTags["+ i +"].TagValues.Length"); j++) {
					ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag.ListRegisteredTags_TagValue tagValue = new ListRegisteredTagsResponse.ListRegisteredTags_RegisteredTag.ListRegisteredTags_TagValue();
					tagValue.Lang = context.StringValue("ListRegisteredTags.RegisteredTags["+ i +"].TagValues["+ j +"].Lang");
					tagValue.Text = context.StringValue("ListRegisteredTags.RegisteredTags["+ i +"].TagValues["+ j +"].Text");

					registeredTag_tagValues.Add(tagValue);
				}
				registeredTag.TagValues = registeredTag_tagValues;

				listRegisteredTagsResponse_registeredTags.Add(registeredTag);
			}
			listRegisteredTagsResponse.RegisteredTags = listRegisteredTagsResponse_registeredTags;
        
			return listRegisteredTagsResponse;
        }
    }
}