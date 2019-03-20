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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListMonitoringTemplatesResponseUnmarshaller
    {
        public static ListMonitoringTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListMonitoringTemplatesResponse listMonitoringTemplatesResponse = new ListMonitoringTemplatesResponse();

			listMonitoringTemplatesResponse.HttpResponse = context.HttpResponse;
			listMonitoringTemplatesResponse.RequestId = context.StringValue("ListMonitoringTemplates.RequestId");
			listMonitoringTemplatesResponse.Success = context.BooleanValue("ListMonitoringTemplates.Success");
			listMonitoringTemplatesResponse.ErrorCode = context.IntegerValue("ListMonitoringTemplates.ErrorCode");
			listMonitoringTemplatesResponse.ErrorMessage = context.StringValue("ListMonitoringTemplates.ErrorMessage");
			listMonitoringTemplatesResponse.PageSize = context.LongValue("ListMonitoringTemplates.PageSize");
			listMonitoringTemplatesResponse.PageNumber = context.LongValue("ListMonitoringTemplates.PageNumber");
			listMonitoringTemplatesResponse.Total = context.LongValue("ListMonitoringTemplates.Total");

			List<ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource> listMonitoringTemplatesResponse_resources = new List<ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource>();
			for (int i = 0; i < context.Length("ListMonitoringTemplates.Resources.Length"); i++) {
				ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource resource = new ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource();
				resource.Name = context.StringValue("ListMonitoringTemplates.Resources["+ i +"].Name");
				resource._Namespace = context.StringValue("ListMonitoringTemplates.Resources["+ i +"].Namespace");
				resource.Description = context.StringValue("ListMonitoringTemplates.Resources["+ i +"].Description");
				resource.AlertTemplatesJson = context.StringValue("ListMonitoringTemplates.Resources["+ i +"].AlertTemplatesJson");
				resource.RestVersion = context.LongValue("ListMonitoringTemplates.Resources["+ i +"].RestVersion");
				resource.Id = context.LongValue("ListMonitoringTemplates.Resources["+ i +"].Id");
				resource.GmtCreate = context.LongValue("ListMonitoringTemplates.Resources["+ i +"].GmtCreate");
				resource.GmtModified = context.LongValue("ListMonitoringTemplates.Resources["+ i +"].GmtModified");
				resource.EventRuleTemplatesJson = context.StringValue("ListMonitoringTemplates.Resources["+ i +"].EventRuleTemplatesJson");

				List<ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource.ListMonitoringTemplates_ApplyHistory> resource_applyHistories = new List<ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource.ListMonitoringTemplates_ApplyHistory>();
				for (int j = 0; j < context.Length("ListMonitoringTemplates.Resources["+ i +"].ApplyHistories.Length"); j++) {
					ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource.ListMonitoringTemplates_ApplyHistory applyHistory = new ListMonitoringTemplatesResponse.ListMonitoringTemplates_Resource.ListMonitoringTemplates_ApplyHistory();
					applyHistory.GroupId = context.LongValue("ListMonitoringTemplates.Resources["+ i +"].ApplyHistories["+ j +"].GroupId");
					applyHistory.GroupName = context.StringValue("ListMonitoringTemplates.Resources["+ i +"].ApplyHistories["+ j +"].GroupName");
					applyHistory.ApplyTime = context.LongValue("ListMonitoringTemplates.Resources["+ i +"].ApplyHistories["+ j +"].ApplyTime");

					resource_applyHistories.Add(applyHistory);
				}
				resource.ApplyHistories = resource_applyHistories;

				listMonitoringTemplatesResponse_resources.Add(resource);
			}
			listMonitoringTemplatesResponse.Resources = listMonitoringTemplatesResponse_resources;
        
			return listMonitoringTemplatesResponse;
        }
    }
}
