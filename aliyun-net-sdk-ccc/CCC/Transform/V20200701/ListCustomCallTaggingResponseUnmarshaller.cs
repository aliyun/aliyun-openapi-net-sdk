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
    public class ListCustomCallTaggingResponseUnmarshaller
    {
        public static ListCustomCallTaggingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomCallTaggingResponse listCustomCallTaggingResponse = new ListCustomCallTaggingResponse();

			listCustomCallTaggingResponse.HttpResponse = _ctx.HttpResponse;
			listCustomCallTaggingResponse.RequestId = _ctx.StringValue("ListCustomCallTagging.RequestId");
			listCustomCallTaggingResponse.HttpStatusCode = _ctx.IntegerValue("ListCustomCallTagging.HttpStatusCode");
			listCustomCallTaggingResponse.Code = _ctx.StringValue("ListCustomCallTagging.Code");
			listCustomCallTaggingResponse.Message = _ctx.StringValue("ListCustomCallTagging.Message");

			ListCustomCallTaggingResponse.ListCustomCallTagging_Data data = new ListCustomCallTaggingResponse.ListCustomCallTagging_Data();
			data.PageNumber = _ctx.IntegerValue("ListCustomCallTagging.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListCustomCallTagging.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListCustomCallTagging.Data.TotalCount");

			List<ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging> data_list = new List<ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging>();
			for (int i = 0; i < _ctx.Length("ListCustomCallTagging.Data.List.Length"); i++) {
				ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging customCallTagging = new ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging();
				customCallTagging.InstanceId = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].InstanceId");
				customCallTagging.Number = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].Number");
				customCallTagging.Description = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].Description");
				customCallTagging.Creator = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].Creator");
				customCallTagging.UpdateTime = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].UpdateTime");

				List<ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging.ListCustomCallTagging_CallTag> customCallTagging_callTagList = new List<ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging.ListCustomCallTagging_CallTag>();
				for (int j = 0; j < _ctx.Length("ListCustomCallTagging.Data.List["+ i +"].CallTagList.Length"); j++) {
					ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging.ListCustomCallTagging_CallTag callTag = new ListCustomCallTaggingResponse.ListCustomCallTagging_Data.ListCustomCallTagging_CustomCallTagging.ListCustomCallTagging_CallTag();
					callTag.InstanceId = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].CallTagList["+ j +"].InstanceId");
					callTag.TagName = _ctx.StringValue("ListCustomCallTagging.Data.List["+ i +"].CallTagList["+ j +"].TagName");

					customCallTagging_callTagList.Add(callTag);
				}
				customCallTagging.CallTagList = customCallTagging_callTagList;

				data_list.Add(customCallTagging);
			}
			data.List = data_list;
			listCustomCallTaggingResponse.Data = data;
        
			return listCustomCallTaggingResponse;
        }
    }
}
