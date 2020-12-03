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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListDataServiceApplicationsResponseUnmarshaller
    {
        public static ListDataServiceApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataServiceApplicationsResponse listDataServiceApplicationsResponse = new ListDataServiceApplicationsResponse();

			listDataServiceApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			listDataServiceApplicationsResponse.ErrorCode = _ctx.StringValue("ListDataServiceApplications.ErrorCode");
			listDataServiceApplicationsResponse.ErrorMessage = _ctx.StringValue("ListDataServiceApplications.ErrorMessage");
			listDataServiceApplicationsResponse.HttpStatusCode = _ctx.IntegerValue("ListDataServiceApplications.HttpStatusCode");
			listDataServiceApplicationsResponse.RequestId = _ctx.StringValue("ListDataServiceApplications.RequestId");
			listDataServiceApplicationsResponse.Success = _ctx.BooleanValue("ListDataServiceApplications.Success");

			ListDataServiceApplicationsResponse.ListDataServiceApplications_Data data = new ListDataServiceApplicationsResponse.ListDataServiceApplications_Data();
			data.PageNumber = _ctx.IntegerValue("ListDataServiceApplications.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListDataServiceApplications.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListDataServiceApplications.Data.TotalCount");

			List<ListDataServiceApplicationsResponse.ListDataServiceApplications_Data.ListDataServiceApplications_Application> data_applications = new List<ListDataServiceApplicationsResponse.ListDataServiceApplications_Data.ListDataServiceApplications_Application>();
			for (int i = 0; i < _ctx.Length("ListDataServiceApplications.Data.Applications.Length"); i++) {
				ListDataServiceApplicationsResponse.ListDataServiceApplications_Data.ListDataServiceApplications_Application application = new ListDataServiceApplicationsResponse.ListDataServiceApplications_Data.ListDataServiceApplications_Application();
				application.ApplicationId = _ctx.LongValue("ListDataServiceApplications.Data.Applications["+ i +"].ApplicationId");
				application.ApplicationName = _ctx.StringValue("ListDataServiceApplications.Data.Applications["+ i +"].ApplicationName");
				application.ProjectId = _ctx.LongValue("ListDataServiceApplications.Data.Applications["+ i +"].ProjectId");

				data_applications.Add(application);
			}
			data.Applications = data_applications;
			listDataServiceApplicationsResponse.Data = data;
        
			return listDataServiceApplicationsResponse;
        }
    }
}
