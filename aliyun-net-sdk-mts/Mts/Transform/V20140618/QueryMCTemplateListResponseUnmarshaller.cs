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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryMCTemplateListResponseUnmarshaller
    {
        public static QueryMCTemplateListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMCTemplateListResponse queryMCTemplateListResponse = new QueryMCTemplateListResponse();

			queryMCTemplateListResponse.HttpResponse = context.HttpResponse;
			queryMCTemplateListResponse.RequestId = context.StringValue("QueryMCTemplateList.RequestId");

			List<string> queryMCTemplateListResponse_nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("QueryMCTemplateList.NonExistTids.Length"); i++) {
				queryMCTemplateListResponse_nonExistTids.Add(context.StringValue("QueryMCTemplateList.NonExistTids["+ i +"]"));
			}
			queryMCTemplateListResponse.NonExistTids = queryMCTemplateListResponse_nonExistTids;

			List<QueryMCTemplateListResponse.QueryMCTemplateList_Template> queryMCTemplateListResponse_templateList = new List<QueryMCTemplateListResponse.QueryMCTemplateList_Template>();
			for (int i = 0; i < context.Length("QueryMCTemplateList.TemplateList.Length"); i++) {
				QueryMCTemplateListResponse.QueryMCTemplateList_Template template = new QueryMCTemplateListResponse.QueryMCTemplateList_Template();
				template.TemplateId = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].TemplateId");
				template.Name = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Name");
				template.State = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].State");
				template.Porn = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Porn");
				template.Terrorism = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Terrorism");
				template.Politics = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Politics");
				template.Ad = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Ad");
				template.Qrcode = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Qrcode");
				template.Live = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Live");
				template.Logo = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Logo");
				template.Abuse = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Abuse");
				template.Contraband = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Contraband");
				template.Spam = context.StringValue("QueryMCTemplateList.TemplateList["+ i +"].Spam");

				queryMCTemplateListResponse_templateList.Add(template);
			}
			queryMCTemplateListResponse.TemplateList = queryMCTemplateListResponse_templateList;
        
			return queryMCTemplateListResponse;
        }
    }
}
