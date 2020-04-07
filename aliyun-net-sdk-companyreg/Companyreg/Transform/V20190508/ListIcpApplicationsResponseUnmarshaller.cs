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
        public static ListIcpApplicationsResponse Unmarshall(UnmarshallerContext context)
        {
			ListIcpApplicationsResponse listIcpApplicationsResponse = new ListIcpApplicationsResponse();

			listIcpApplicationsResponse.HttpResponse = context.HttpResponse;
			listIcpApplicationsResponse.RequestId = context.StringValue("ListIcpApplications.RequestId");
			listIcpApplicationsResponse.TotalCount = context.IntegerValue("ListIcpApplications.TotalCount");
			listIcpApplicationsResponse.PageSize = context.IntegerValue("ListIcpApplications.PageSize");
			listIcpApplicationsResponse.PageNumber = context.IntegerValue("ListIcpApplications.PageNumber");

			List<ListIcpApplicationsResponse.ListIcpApplications_Application> listIcpApplicationsResponse_applications = new List<ListIcpApplicationsResponse.ListIcpApplications_Application>();
			for (int i = 0; i < context.Length("ListIcpApplications.Applications.Length"); i++) {
				ListIcpApplicationsResponse.ListIcpApplications_Application application = new ListIcpApplicationsResponse.ListIcpApplications_Application();
				application.OrderId = context.StringValue("ListIcpApplications.Applications["+ i +"].OrderId");
				application.OrderPrice = context.FloatValue("ListIcpApplications.Applications["+ i +"].OrderPrice");
				application.ApplicationStatus = context.IntegerValue("ListIcpApplications.Applications["+ i +"].ApplicationStatus");
				application.CompanyName = context.StringValue("ListIcpApplications.Applications["+ i +"].CompanyName");
				application.LegalPersonName = context.StringValue("ListIcpApplications.Applications["+ i +"].LegalPersonName");
				application.ApplicationType = context.IntegerValue("ListIcpApplications.Applications["+ i +"].ApplicationType");
				application.CompanyAddress = context.StringValue("ListIcpApplications.Applications["+ i +"].CompanyAddress");
				application.Domain = context.StringValue("ListIcpApplications.Applications["+ i +"].Domain");
				application.IncludeForeignInvestment = context.BooleanValue("ListIcpApplications.Applications["+ i +"].IncludeForeignInvestment");
				application.PartnerCode = context.StringValue("ListIcpApplications.Applications["+ i +"].PartnerCode");
				application.UserId = context.StringValue("ListIcpApplications.Applications["+ i +"].UserId");
				application.BizId = context.StringValue("ListIcpApplications.Applications["+ i +"].BizId");
				application.IntentionBizId = context.StringValue("ListIcpApplications.Applications["+ i +"].IntentionBizId");
				application.CompanyArea = context.StringValue("ListIcpApplications.Applications["+ i +"].CompanyArea");
				application.UpdateTime = context.LongValue("ListIcpApplications.Applications["+ i +"].UpdateTime");
				application.Type = context.IntegerValue("ListIcpApplications.Applications["+ i +"].Type");

				listIcpApplicationsResponse_applications.Add(application);
			}
			listIcpApplicationsResponse.Applications = listIcpApplicationsResponse_applications;
        
			return listIcpApplicationsResponse;
        }
    }
}
