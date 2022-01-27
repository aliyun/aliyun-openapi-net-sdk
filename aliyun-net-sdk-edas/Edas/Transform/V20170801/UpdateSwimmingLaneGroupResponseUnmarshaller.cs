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
    public class UpdateSwimmingLaneGroupResponseUnmarshaller
    {
        public static UpdateSwimmingLaneGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateSwimmingLaneGroupResponse updateSwimmingLaneGroupResponse = new UpdateSwimmingLaneGroupResponse();

			updateSwimmingLaneGroupResponse.HttpResponse = _ctx.HttpResponse;
			updateSwimmingLaneGroupResponse.Code = _ctx.IntegerValue("UpdateSwimmingLaneGroup.Code");
			updateSwimmingLaneGroupResponse.Message = _ctx.StringValue("UpdateSwimmingLaneGroup.Message");
			updateSwimmingLaneGroupResponse.RequestId = _ctx.StringValue("UpdateSwimmingLaneGroup.RequestId");

			UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data data = new UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data();
			data.Id = _ctx.LongValue("UpdateSwimmingLaneGroup.Data.Id");
			data.Name = _ctx.StringValue("UpdateSwimmingLaneGroup.Data.Name");
			data.NamespaceId = _ctx.StringValue("UpdateSwimmingLaneGroup.Data.NamespaceId");

			UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data.UpdateSwimmingLaneGroup_EntryApplication entryApplication = new UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data.UpdateSwimmingLaneGroup_EntryApplication();
			entryApplication.AppName = _ctx.StringValue("UpdateSwimmingLaneGroup.Data.EntryApplication.AppName");
			entryApplication.AppId = _ctx.StringValue("UpdateSwimmingLaneGroup.Data.EntryApplication.AppId");
			data.EntryApplication = entryApplication;

			List<UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data.UpdateSwimmingLaneGroup_Application> data_applicationList = new List<UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data.UpdateSwimmingLaneGroup_Application>();
			for (int i = 0; i < _ctx.Length("UpdateSwimmingLaneGroup.Data.ApplicationList.Length"); i++) {
				UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data.UpdateSwimmingLaneGroup_Application application = new UpdateSwimmingLaneGroupResponse.UpdateSwimmingLaneGroup_Data.UpdateSwimmingLaneGroup_Application();
				application.AppName = _ctx.StringValue("UpdateSwimmingLaneGroup.Data.ApplicationList["+ i +"].AppName");
				application.AppId = _ctx.StringValue("UpdateSwimmingLaneGroup.Data.ApplicationList["+ i +"].AppId");

				data_applicationList.Add(application);
			}
			data.ApplicationList = data_applicationList;
			updateSwimmingLaneGroupResponse.Data = data;
        
			return updateSwimmingLaneGroupResponse;
        }
    }
}
