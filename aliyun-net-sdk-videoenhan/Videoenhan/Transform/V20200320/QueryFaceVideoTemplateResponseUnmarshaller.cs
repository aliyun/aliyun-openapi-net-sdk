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
using Aliyun.Acs.videoenhan.Model.V20200320;

namespace Aliyun.Acs.videoenhan.Transform.V20200320
{
    public class QueryFaceVideoTemplateResponseUnmarshaller
    {
        public static QueryFaceVideoTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceVideoTemplateResponse queryFaceVideoTemplateResponse = new QueryFaceVideoTemplateResponse();

			queryFaceVideoTemplateResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceVideoTemplateResponse.Message = _ctx.StringValue("QueryFaceVideoTemplate.Message");
			queryFaceVideoTemplateResponse.RequestId = _ctx.StringValue("QueryFaceVideoTemplate.RequestId");
			queryFaceVideoTemplateResponse.Code = _ctx.StringValue("QueryFaceVideoTemplate.Code");

			QueryFaceVideoTemplateResponse.QueryFaceVideoTemplate_Data data = new QueryFaceVideoTemplateResponse.QueryFaceVideoTemplate_Data();

			List<QueryFaceVideoTemplateResponse.QueryFaceVideoTemplate_Data.QueryFaceVideoTemplate_ElementsItem> data_elements = new List<QueryFaceVideoTemplateResponse.QueryFaceVideoTemplate_Data.QueryFaceVideoTemplate_ElementsItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceVideoTemplate.Data.Elements.Length"); i++) {
				QueryFaceVideoTemplateResponse.QueryFaceVideoTemplate_Data.QueryFaceVideoTemplate_ElementsItem elementsItem = new QueryFaceVideoTemplateResponse.QueryFaceVideoTemplate_Data.QueryFaceVideoTemplate_ElementsItem();
				elementsItem.TemplateURL = _ctx.StringValue("QueryFaceVideoTemplate.Data.Elements["+ i +"].TemplateURL");
				elementsItem.UserId = _ctx.StringValue("QueryFaceVideoTemplate.Data.Elements["+ i +"].UserId");
				elementsItem.CreateTime = _ctx.StringValue("QueryFaceVideoTemplate.Data.Elements["+ i +"].CreateTime");
				elementsItem.UpdateTime = _ctx.StringValue("QueryFaceVideoTemplate.Data.Elements["+ i +"].UpdateTime");
				elementsItem.TemplateId = _ctx.StringValue("QueryFaceVideoTemplate.Data.Elements["+ i +"].TemplateId");

				data_elements.Add(elementsItem);
			}
			data.Elements = data_elements;
			queryFaceVideoTemplateResponse.Data = data;
        
			return queryFaceVideoTemplateResponse;
        }
    }
}
