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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListSwimmingLaneGroupResponseUnmarshaller
    {
        public static ListSwimmingLaneGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSwimmingLaneGroupResponse listSwimmingLaneGroupResponse = new ListSwimmingLaneGroupResponse();

			listSwimmingLaneGroupResponse.HttpResponse = _ctx.HttpResponse;
			listSwimmingLaneGroupResponse.Code = _ctx.IntegerValue("ListSwimmingLaneGroup.Code");
			listSwimmingLaneGroupResponse.Message = _ctx.StringValue("ListSwimmingLaneGroup.Message");
			listSwimmingLaneGroupResponse.RequestId = _ctx.StringValue("ListSwimmingLaneGroup.RequestId");

			List<ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup> listSwimmingLaneGroupResponse_data = new List<ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup>();
			for (int i = 0; i < _ctx.Length("ListSwimmingLaneGroup.Data.Length"); i++) {
				ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup swimmingLaneGroup = new ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup();
				swimmingLaneGroup.Id = _ctx.LongValue("ListSwimmingLaneGroup.Data["+ i +"].Id");
				swimmingLaneGroup.Name = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].Name");
				swimmingLaneGroup.NamespaceId = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].NamespaceId");

				ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup.ListSwimmingLaneGroup_EntryApplication entryApplication = new ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup.ListSwimmingLaneGroup_EntryApplication();
				entryApplication.AppName = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].EntryApplication.AppName");
				entryApplication.AppId = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].EntryApplication.AppId");
				entryApplication.Source = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].EntryApplication.Source");
				swimmingLaneGroup.EntryApplication = entryApplication;

				List<ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup.ListSwimmingLaneGroup_Application> swimmingLaneGroup_applicationList = new List<ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup.ListSwimmingLaneGroup_Application>();
				for (int j = 0; j < _ctx.Length("ListSwimmingLaneGroup.Data["+ i +"].ApplicationList.Length"); j++) {
					ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup.ListSwimmingLaneGroup_Application application = new ListSwimmingLaneGroupResponse.ListSwimmingLaneGroup_SwimmingLaneGroup.ListSwimmingLaneGroup_Application();
					application.AppName = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].ApplicationList["+ j +"].AppName");
					application.AppId = _ctx.StringValue("ListSwimmingLaneGroup.Data["+ i +"].ApplicationList["+ j +"].AppId");

					swimmingLaneGroup_applicationList.Add(application);
				}
				swimmingLaneGroup.ApplicationList = swimmingLaneGroup_applicationList;

				listSwimmingLaneGroupResponse_data.Add(swimmingLaneGroup);
			}
			listSwimmingLaneGroupResponse.Data = listSwimmingLaneGroupResponse_data;
        
			return listSwimmingLaneGroupResponse;
        }
    }
}
