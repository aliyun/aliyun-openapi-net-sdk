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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class ListIcpApplicationsResponseUnmarshaller
    {
        public static ListIcpApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIcpApplicationsResponse listIcpApplicationsResponse = new ListIcpApplicationsResponse();

			listIcpApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			listIcpApplicationsResponse.RequestId = _ctx.StringValue("ListIcpApplications.RequestId");
			listIcpApplicationsResponse.TotalCount = _ctx.IntegerValue("ListIcpApplications.TotalCount");
			listIcpApplicationsResponse.PageSize = _ctx.IntegerValue("ListIcpApplications.PageSize");
			listIcpApplicationsResponse.PageNumber = _ctx.IntegerValue("ListIcpApplications.PageNumber");
			listIcpApplicationsResponse.Source = _ctx.StringValue("ListIcpApplications.Source");

			List<ListIcpApplicationsResponse.ListIcpApplications_Application> listIcpApplicationsResponse_applications = new List<ListIcpApplicationsResponse.ListIcpApplications_Application>();
			for (int i = 0; i < _ctx.Length("ListIcpApplications.Applications.Length"); i++) {
				ListIcpApplicationsResponse.ListIcpApplications_Application application = new ListIcpApplicationsResponse.ListIcpApplications_Application();
				application.OrderId = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].OrderId");
				application.OrderPrice = _ctx.FloatValue("ListIcpApplications.Applications["+ i +"].OrderPrice");
				application.ApplicationStatus = _ctx.IntegerValue("ListIcpApplications.Applications["+ i +"].ApplicationStatus");
				application.CompanyName = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].CompanyName");
				application.LegalPersonName = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].LegalPersonName");
				application.ApplicationType = _ctx.IntegerValue("ListIcpApplications.Applications["+ i +"].ApplicationType");
				application.CompanyAddress = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].CompanyAddress");
				application.Domain = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].Domain");
				application.IncludeForeignInvestment = _ctx.BooleanValue("ListIcpApplications.Applications["+ i +"].IncludeForeignInvestment");
				application.PartnerCode = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].PartnerCode");
				application.UserId = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].UserId");
				application.BizId = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].BizId");
				application.IntentionBizId = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].IntentionBizId");
				application.CompanyArea = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].CompanyArea");
				application.UpdateTime = _ctx.LongValue("ListIcpApplications.Applications["+ i +"].UpdateTime");
				application.Type = _ctx.IntegerValue("ListIcpApplications.Applications["+ i +"].Type");
				application.ActionType = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].ActionType");
				application.Version = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].Version");
				application.ProduceVersion = _ctx.StringValue("ListIcpApplications.Applications["+ i +"].ProduceVersion");

				listIcpApplicationsResponse_applications.Add(application);
			}
			listIcpApplicationsResponse.Applications = listIcpApplicationsResponse_applications;
        
			return listIcpApplicationsResponse;
        }
    }
}
