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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class ListWorkspacesResponseUnmarshaller
    {
        public static ListWorkspacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkspacesResponse listWorkspacesResponse = new ListWorkspacesResponse();

			listWorkspacesResponse.HttpResponse = _ctx.HttpResponse;
			listWorkspacesResponse.Message = _ctx.StringValue("ListWorkspaces.Message");
			listWorkspacesResponse.RequestId = _ctx.StringValue("ListWorkspaces.RequestId");
			listWorkspacesResponse.Code = _ctx.StringValue("ListWorkspaces.Code");

			ListWorkspacesResponse.ListWorkspaces_Data data = new ListWorkspacesResponse.ListWorkspaces_Data();
			data.CurrentPage = _ctx.LongValue("ListWorkspaces.Data.CurrentPage");
			data.PageSize = _ctx.LongValue("ListWorkspaces.Data.PageSize");
			data.TotalPage = _ctx.LongValue("ListWorkspaces.Data.TotalPage");
			data.TotalCount = _ctx.LongValue("ListWorkspaces.Data.TotalCount");

			List<ListWorkspacesResponse.ListWorkspaces_Data.ListWorkspaces_Element> data_elements = new List<ListWorkspacesResponse.ListWorkspaces_Data.ListWorkspaces_Element>();
			for (int i = 0; i < _ctx.Length("ListWorkspaces.Data.Elements.Length"); i++) {
				ListWorkspacesResponse.ListWorkspaces_Data.ListWorkspaces_Element element = new ListWorkspacesResponse.ListWorkspaces_Data.ListWorkspaces_Element();
				element.Id = _ctx.LongValue("ListWorkspaces.Data.Elements["+ i +"].Id");
				element.GmtCreate = _ctx.LongValue("ListWorkspaces.Data.Elements["+ i +"].GmtCreate");
				element.Name = _ctx.StringValue("ListWorkspaces.Data.Elements["+ i +"].Name");
				element.Description = _ctx.StringValue("ListWorkspaces.Data.Elements["+ i +"].Description");
				element.Type = _ctx.StringValue("ListWorkspaces.Data.Elements["+ i +"].Type");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			listWorkspacesResponse.Data = data;
        
			return listWorkspacesResponse;
        }
    }
}
