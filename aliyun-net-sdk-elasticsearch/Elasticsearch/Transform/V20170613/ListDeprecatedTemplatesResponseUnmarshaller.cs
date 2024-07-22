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
    public class ListDeprecatedTemplatesResponseUnmarshaller
    {
        public static ListDeprecatedTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeprecatedTemplatesResponse listDeprecatedTemplatesResponse = new ListDeprecatedTemplatesResponse();

			listDeprecatedTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listDeprecatedTemplatesResponse.RequestId = _ctx.StringValue("ListDeprecatedTemplates.RequestId");

			ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_Headers headers = new ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_Headers();
			headers.XTotalCount = _ctx.LongValue("ListDeprecatedTemplates.Headers.X-Total-Count");
			listDeprecatedTemplatesResponse.Headers = headers;

			List<ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_ResultItem> listDeprecatedTemplatesResponse_result = new List<ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDeprecatedTemplates.Result.Length"); i++) {
				ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_ResultItem resultItem = new ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_ResultItem();
				resultItem.DataStream = _ctx.BooleanValue("ListDeprecatedTemplates.Result["+ i +"].dataStream");
				resultItem.IndexTemplate = _ctx.StringValue("ListDeprecatedTemplates.Result["+ i +"].indexTemplate");
				resultItem.Order = _ctx.LongValue("ListDeprecatedTemplates.Result["+ i +"].order");
				resultItem.Version = _ctx.StringValue("ListDeprecatedTemplates.Result["+ i +"].version");

				List<string> resultItem_indexPatterns = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDeprecatedTemplates.Result["+ i +"].IndexPatterns.Length"); j++) {
					resultItem_indexPatterns.Add(_ctx.StringValue("ListDeprecatedTemplates.Result["+ i +"].IndexPatterns["+ j +"]"));
				}
				resultItem.IndexPatterns = resultItem_indexPatterns;

				ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_ResultItem.ListDeprecatedTemplates_Template template = new ListDeprecatedTemplatesResponse.ListDeprecatedTemplates_ResultItem.ListDeprecatedTemplates_Template();
				template.Aliases = _ctx.StringValue("ListDeprecatedTemplates.Result["+ i +"].Template.aliases");
				template.Mappings = _ctx.StringValue("ListDeprecatedTemplates.Result["+ i +"].Template.mappings");
				template.Settings = _ctx.StringValue("ListDeprecatedTemplates.Result["+ i +"].Template.settings");
				resultItem.Template = template;

				listDeprecatedTemplatesResponse_result.Add(resultItem);
			}
			listDeprecatedTemplatesResponse.Result = listDeprecatedTemplatesResponse_result;
        
			return listDeprecatedTemplatesResponse;
        }
    }
}
