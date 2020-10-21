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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListApplicationsResponseUnmarshaller
    {
        public static ListApplicationsResponse Unmarshall(UnmarshallerContext context)
        {
			ListApplicationsResponse listApplicationsResponse = new ListApplicationsResponse();

			listApplicationsResponse.HttpResponse = context.HttpResponse;
			listApplicationsResponse.RequestId = context.StringValue("ListApplications.RequestId");
			listApplicationsResponse.Code = context.StringValue("ListApplications.Code");
			listApplicationsResponse.Message = context.StringValue("ListApplications.Message");
			listApplicationsResponse.Success = context.BooleanValue("ListApplications.Success");
			listApplicationsResponse.ErrorCode = context.StringValue("ListApplications.ErrorCode");

			ListApplicationsResponse.ListApplications_Data data = new ListApplicationsResponse.ListApplications_Data();
			data.CurrentPage = context.IntegerValue("ListApplications.Data.CurrentPage");
			data.PageSize = context.IntegerValue("ListApplications.Data.PageSize");
			data.TotalSize = context.IntegerValue("ListApplications.Data.TotalSize");

			List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application> data_applications = new List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application>();
			for (int i = 0; i < context.Length("ListApplications.Data.Applications.Length"); i++) {
				ListApplicationsResponse.ListApplications_Data.ListApplications_Application application = new ListApplicationsResponse.ListApplications_Data.ListApplications_Application();
				application.AppDeletingStatus = context.BooleanValue("ListApplications.Data.Applications["+ i +"].AppDeletingStatus");
				application.AppId = context.StringValue("ListApplications.Data.Applications["+ i +"].AppId");
				application.AppName = context.StringValue("ListApplications.Data.Applications["+ i +"].AppName");
				application.RegionId = context.StringValue("ListApplications.Data.Applications["+ i +"].RegionId");
				application.RunningInstances = context.IntegerValue("ListApplications.Data.Applications["+ i +"].RunningInstances");
				application.Instances = context.IntegerValue("ListApplications.Data.Applications["+ i +"].Instances");
				application.NamespaceId = context.StringValue("ListApplications.Data.Applications["+ i +"].NamespaceId");
				application.ScaleRuleType = context.StringValue("ListApplications.Data.Applications["+ i +"].ScaleRuleType");
				application.ScaleRuleEnabled = context.BooleanValue("ListApplications.Data.Applications["+ i +"].ScaleRuleEnabled");

				List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem> application_tags = new List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem>();
				for (int j = 0; j < context.Length("ListApplications.Data.Applications["+ i +"].Tags.Length"); j++) {
					ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem tagsItem = new ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem();
					tagsItem.Key = context.StringValue("ListApplications.Data.Applications["+ i +"].Tags["+ j +"].Key");
					tagsItem._Value = context.StringValue("ListApplications.Data.Applications["+ i +"].Tags["+ j +"].Value");

					application_tags.Add(tagsItem);
				}
				application.Tags = application_tags;

				data_applications.Add(application);
			}
			data.Applications = data_applications;
			listApplicationsResponse.Data = data;
        
			return listApplicationsResponse;
        }
    }
}
