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
    public class InsertSwimmingLaneGroupResponseUnmarshaller
    {
        public static InsertSwimmingLaneGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertSwimmingLaneGroupResponse insertSwimmingLaneGroupResponse = new InsertSwimmingLaneGroupResponse();

			insertSwimmingLaneGroupResponse.HttpResponse = _ctx.HttpResponse;
			insertSwimmingLaneGroupResponse.Code = _ctx.IntegerValue("InsertSwimmingLaneGroup.Code");
			insertSwimmingLaneGroupResponse.Message = _ctx.StringValue("InsertSwimmingLaneGroup.Message");
			insertSwimmingLaneGroupResponse.RequestId = _ctx.StringValue("InsertSwimmingLaneGroup.RequestId");

			InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data data = new InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data();
			data.Id = _ctx.LongValue("InsertSwimmingLaneGroup.Data.Id");
			data.Name = _ctx.StringValue("InsertSwimmingLaneGroup.Data.Name");
			data.NamespaceId = _ctx.StringValue("InsertSwimmingLaneGroup.Data.NamespaceId");

			InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data.InsertSwimmingLaneGroup_EntryApplication entryApplication = new InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data.InsertSwimmingLaneGroup_EntryApplication();
			entryApplication.AppName = _ctx.StringValue("InsertSwimmingLaneGroup.Data.EntryApplication.AppName");
			entryApplication.AppId = _ctx.StringValue("InsertSwimmingLaneGroup.Data.EntryApplication.AppId");
			data.EntryApplication = entryApplication;

			List<InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data.InsertSwimmingLaneGroup_Application> data_applicationList = new List<InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data.InsertSwimmingLaneGroup_Application>();
			for (int i = 0; i < _ctx.Length("InsertSwimmingLaneGroup.Data.ApplicationList.Length"); i++) {
				InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data.InsertSwimmingLaneGroup_Application application = new InsertSwimmingLaneGroupResponse.InsertSwimmingLaneGroup_Data.InsertSwimmingLaneGroup_Application();
				application.AppName = _ctx.StringValue("InsertSwimmingLaneGroup.Data.ApplicationList["+ i +"].AppName");
				application.AppId = _ctx.StringValue("InsertSwimmingLaneGroup.Data.ApplicationList["+ i +"].AppId");

				data_applicationList.Add(application);
			}
			data.ApplicationList = data_applicationList;
			insertSwimmingLaneGroupResponse.Data = data;
        
			return insertSwimmingLaneGroupResponse;
        }
    }
}
