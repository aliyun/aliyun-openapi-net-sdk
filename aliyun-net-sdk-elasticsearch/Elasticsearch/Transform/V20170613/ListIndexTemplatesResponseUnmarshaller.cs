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
    public class ListIndexTemplatesResponseUnmarshaller
    {
        public static ListIndexTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIndexTemplatesResponse listIndexTemplatesResponse = new ListIndexTemplatesResponse();

			listIndexTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listIndexTemplatesResponse.RequestId = _ctx.StringValue("ListIndexTemplates.RequestId");

			List<ListIndexTemplatesResponse.ListIndexTemplates_ResultItem> listIndexTemplatesResponse_result = new List<ListIndexTemplatesResponse.ListIndexTemplates_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListIndexTemplates.Result.Length"); i++) {
				ListIndexTemplatesResponse.ListIndexTemplates_ResultItem resultItem = new ListIndexTemplatesResponse.ListIndexTemplates_ResultItem();
				resultItem.IndexTemplate = _ctx.StringValue("ListIndexTemplates.Result["+ i +"].indexTemplate");
				resultItem.DataStream = _ctx.BooleanValue("ListIndexTemplates.Result["+ i +"].dataStream");
				resultItem.Priority = _ctx.IntegerValue("ListIndexTemplates.Result["+ i +"].priority");
				resultItem.IlmPolicy = _ctx.StringValue("ListIndexTemplates.Result["+ i +"].ilmPolicy");

				List<string> resultItem_indexPatterns = new List<string>();
				for (int j = 0; j < _ctx.Length("ListIndexTemplates.Result["+ i +"].IndexPatterns.Length"); j++) {
					resultItem_indexPatterns.Add(_ctx.StringValue("ListIndexTemplates.Result["+ i +"].IndexPatterns["+ j +"]"));
				}
				resultItem.IndexPatterns = resultItem_indexPatterns;

				ListIndexTemplatesResponse.ListIndexTemplates_ResultItem.ListIndexTemplates_Template template = new ListIndexTemplatesResponse.ListIndexTemplates_ResultItem.ListIndexTemplates_Template();
				template.Settings = _ctx.StringValue("ListIndexTemplates.Result["+ i +"].Template.settings");
				template.Mappings = _ctx.StringValue("ListIndexTemplates.Result["+ i +"].Template.mappings");
				template.Aliases = _ctx.StringValue("ListIndexTemplates.Result["+ i +"].Template.aliases");
				resultItem.Template = template;

				listIndexTemplatesResponse_result.Add(resultItem);
			}
			listIndexTemplatesResponse.Result = listIndexTemplatesResponse_result;
        
			return listIndexTemplatesResponse;
        }
    }
}
