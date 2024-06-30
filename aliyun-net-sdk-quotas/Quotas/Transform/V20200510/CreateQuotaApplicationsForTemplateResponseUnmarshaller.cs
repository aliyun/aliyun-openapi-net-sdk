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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class CreateQuotaApplicationsForTemplateResponseUnmarshaller
    {
        public static CreateQuotaApplicationsForTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateQuotaApplicationsForTemplateResponse createQuotaApplicationsForTemplateResponse = new CreateQuotaApplicationsForTemplateResponse();

			createQuotaApplicationsForTemplateResponse.HttpResponse = _ctx.HttpResponse;
			createQuotaApplicationsForTemplateResponse.RequestId = _ctx.StringValue("CreateQuotaApplicationsForTemplate.RequestId");
			createQuotaApplicationsForTemplateResponse.BatchQuotaApplicationId = _ctx.StringValue("CreateQuotaApplicationsForTemplate.BatchQuotaApplicationId");

			List<string> createQuotaApplicationsForTemplateResponse_aliyunUids = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateQuotaApplicationsForTemplate.AliyunUids.Length"); i++) {
				createQuotaApplicationsForTemplateResponse_aliyunUids.Add(_ctx.StringValue("CreateQuotaApplicationsForTemplate.AliyunUids["+ i +"]"));
			}
			createQuotaApplicationsForTemplateResponse.AliyunUids = createQuotaApplicationsForTemplateResponse_aliyunUids;

			List<CreateQuotaApplicationsForTemplateResponse.CreateQuotaApplicationsForTemplate_FailResultsItem> createQuotaApplicationsForTemplateResponse_failResults = new List<CreateQuotaApplicationsForTemplateResponse.CreateQuotaApplicationsForTemplate_FailResultsItem>();
			for (int i = 0; i < _ctx.Length("CreateQuotaApplicationsForTemplate.FailResults.Length"); i++) {
				CreateQuotaApplicationsForTemplateResponse.CreateQuotaApplicationsForTemplate_FailResultsItem failResultsItem = new CreateQuotaApplicationsForTemplateResponse.CreateQuotaApplicationsForTemplate_FailResultsItem();
				failResultsItem.AliyunUid = _ctx.StringValue("CreateQuotaApplicationsForTemplate.FailResults["+ i +"].AliyunUid");
				failResultsItem.Reason = _ctx.StringValue("CreateQuotaApplicationsForTemplate.FailResults["+ i +"].Reason");

				createQuotaApplicationsForTemplateResponse_failResults.Add(failResultsItem);
			}
			createQuotaApplicationsForTemplateResponse.FailResults = createQuotaApplicationsForTemplateResponse_failResults;
        
			return createQuotaApplicationsForTemplateResponse;
        }
    }
}
