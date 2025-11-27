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
    public class ListComponentIndicesResponseUnmarshaller
    {
        public static ListComponentIndicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListComponentIndicesResponse listComponentIndicesResponse = new ListComponentIndicesResponse();

			listComponentIndicesResponse.HttpResponse = _ctx.HttpResponse;
			listComponentIndicesResponse.RequestId = _ctx.StringValue("ListComponentIndices.RequestId");

			ListComponentIndicesResponse.ListComponentIndices_Headers headers = new ListComponentIndicesResponse.ListComponentIndices_Headers();
			headers.XTotalCount = _ctx.LongValue("ListComponentIndices.Headers.X-Total-Count");
			listComponentIndicesResponse.Headers = headers;

			List<ListComponentIndicesResponse.ListComponentIndices_ResultItem> listComponentIndicesResponse_result = new List<ListComponentIndicesResponse.ListComponentIndices_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListComponentIndices.Result.Length"); i++) {
				ListComponentIndicesResponse.ListComponentIndices_ResultItem resultItem = new ListComponentIndicesResponse.ListComponentIndices_ResultItem();
				resultItem.Name = _ctx.StringValue("ListComponentIndices.Result["+ i +"].name");

				List<string> resultItem_composed = new List<string>();
				for (int j = 0; j < _ctx.Length("ListComponentIndices.Result["+ i +"].Composed.Length"); j++) {
					resultItem_composed.Add(_ctx.StringValue("ListComponentIndices.Result["+ i +"].Composed["+ j +"]"));
				}
				resultItem.Composed = resultItem_composed;

				ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content content = new ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content();
				content.Version = _ctx.LongValue("ListComponentIndices.Result["+ i +"].Content.version");
				content._Meta = _ctx.StringValue("ListComponentIndices.Result["+ i +"].Content._meta");

				ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template template = new ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template();

				ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template.ListComponentIndices_Settings settings = new ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template.ListComponentIndices_Settings();

				ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template.ListComponentIndices_Settings.ListComponentIndices_Index index = new ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template.ListComponentIndices_Settings.ListComponentIndices_Index();
				index.Codec = _ctx.StringValue("ListComponentIndices.Result["+ i +"].Content.Template.Settings.Index.codec");

				ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template.ListComponentIndices_Settings.ListComponentIndices_Index.ListComponentIndices_Lifecycle lifecycle = new ListComponentIndicesResponse.ListComponentIndices_ResultItem.ListComponentIndices_Content.ListComponentIndices_Template.ListComponentIndices_Settings.ListComponentIndices_Index.ListComponentIndices_Lifecycle();
				lifecycle.Name = _ctx.StringValue("ListComponentIndices.Result["+ i +"].Content.Template.Settings.Index.Lifecycle.name");
				index.Lifecycle = lifecycle;
				settings.Index = index;
				template.Settings = settings;
				content.Template = template;
				resultItem.Content = content;

				listComponentIndicesResponse_result.Add(resultItem);
			}
			listComponentIndicesResponse.Result = listComponentIndicesResponse_result;
        
			return listComponentIndicesResponse;
        }
    }
}
