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
using Aliyun.Acs.cloudgame.Model.V20200429;

namespace Aliyun.Acs.cloudgame.Transform.V20200429
{
    public class ListProjectsResponseUnmarshaller
    {
        public static ListProjectsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectsResponse listProjectsResponse = new ListProjectsResponse();

			listProjectsResponse.HttpResponse = context.HttpResponse;
			listProjectsResponse.Count = context.IntegerValue("ListProjects.Count");
			listProjectsResponse.CurrentPage = context.IntegerValue("ListProjects.CurrentPage");
			listProjectsResponse.PageSize = context.IntegerValue("ListProjects.PageSize");
			listProjectsResponse.RequestId = context.StringValue("ListProjects.RequestId");

			List<ListProjectsResponse.ListProjects_DataListItem> listProjectsResponse_dataList = new List<ListProjectsResponse.ListProjects_DataListItem>();
			for (int i = 0; i < context.Length("ListProjects.DataList.Length"); i++) {
				ListProjectsResponse.ListProjects_DataListItem dataListItem = new ListProjectsResponse.ListProjects_DataListItem();
				dataListItem.StandardCodeRate = context.StringValue("ListProjects.DataList["+ i +"].StandardCodeRate");
				dataListItem.HighDefinitionResolution = context.StringValue("ListProjects.DataList["+ i +"].HighDefinitionResolution");
				dataListItem.HighDefinitionCodeRate = context.StringValue("ListProjects.DataList["+ i +"].HighDefinitionCodeRate");
				dataListItem.StandardResolution = context.StringValue("ListProjects.DataList["+ i +"].StandardResolution");
				dataListItem.ProjectId = context.StringValue("ListProjects.DataList["+ i +"].ProjectId");
				dataListItem.ConcurrencyLimitNumber = context.IntegerValue("ListProjects.DataList["+ i +"].ConcurrencyLimitNumber");
				dataListItem.HighestCodeRate = context.StringValue("ListProjects.DataList["+ i +"].HighestCodeRate");
				dataListItem.ProjectName = context.StringValue("ListProjects.DataList["+ i +"].ProjectName");
				dataListItem.HighestResolution = context.StringValue("ListProjects.DataList["+ i +"].HighestResolution");

				listProjectsResponse_dataList.Add(dataListItem);
			}
			listProjectsResponse.DataList = listProjectsResponse_dataList;
        
			return listProjectsResponse;
        }
    }
}
