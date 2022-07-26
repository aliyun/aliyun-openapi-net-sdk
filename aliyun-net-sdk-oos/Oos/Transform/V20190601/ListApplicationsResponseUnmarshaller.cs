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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListApplicationsResponseUnmarshaller
    {
        public static ListApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationsResponse listApplicationsResponse = new ListApplicationsResponse();

			listApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationsResponse.NextToken = _ctx.StringValue("ListApplications.NextToken");
			listApplicationsResponse.RequestId = _ctx.StringValue("ListApplications.RequestId");
			listApplicationsResponse.MaxResults = _ctx.IntegerValue("ListApplications.MaxResults");

			List<ListApplicationsResponse.ListApplications_Application> listApplicationsResponse_applications = new List<ListApplicationsResponse.ListApplications_Application>();
			for (int i = 0; i < _ctx.Length("ListApplications.Applications.Length"); i++) {
				ListApplicationsResponse.ListApplications_Application application = new ListApplicationsResponse.ListApplications_Application();
				application.Description = _ctx.StringValue("ListApplications.Applications["+ i +"].Description");
				application.UpdateDate = _ctx.StringValue("ListApplications.Applications["+ i +"].UpdateDate");
				application.ResourceGroupId = _ctx.StringValue("ListApplications.Applications["+ i +"].ResourceGroupId");
				application.Tags = _ctx.StringValue("ListApplications.Applications["+ i +"].Tags");
				application.Name = _ctx.StringValue("ListApplications.Applications["+ i +"].Name");
				application.CreateDate = _ctx.StringValue("ListApplications.Applications["+ i +"].CreateDate");

				listApplicationsResponse_applications.Add(application);
			}
			listApplicationsResponse.Applications = listApplicationsResponse_applications;
        
			return listApplicationsResponse;
        }
    }
}
