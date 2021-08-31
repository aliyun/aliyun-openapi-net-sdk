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
    public class UpdateSwimmingLanePriorityResponseUnmarshaller
    {
        public static UpdateSwimmingLanePriorityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateSwimmingLanePriorityResponse updateSwimmingLanePriorityResponse = new UpdateSwimmingLanePriorityResponse();

			updateSwimmingLanePriorityResponse.HttpResponse = _ctx.HttpResponse;
			updateSwimmingLanePriorityResponse.Code = _ctx.IntegerValue("UpdateSwimmingLanePriority.Code");
			updateSwimmingLanePriorityResponse.Message = _ctx.StringValue("UpdateSwimmingLanePriority.Message");
			updateSwimmingLanePriorityResponse.RequestId = _ctx.StringValue("UpdateSwimmingLanePriority.RequestId");

			UpdateSwimmingLanePriorityResponse.UpdateSwimmingLanePriority_Data data = new UpdateSwimmingLanePriorityResponse.UpdateSwimmingLanePriority_Data();
			data.Id = _ctx.LongValue("UpdateSwimmingLanePriority.Data.Id");
			data.Name = _ctx.StringValue("UpdateSwimmingLanePriority.Data.Name");
			data.Tag = _ctx.StringValue("UpdateSwimmingLanePriority.Data.Tag");
			data.NamespaceId = _ctx.StringValue("UpdateSwimmingLanePriority.Data.NamespaceId");
			data.GroupId = _ctx.LongValue("UpdateSwimmingLanePriority.Data.GroupId");
			data.EntryRule = _ctx.StringValue("UpdateSwimmingLanePriority.Data.EntryRule");

			List<UpdateSwimmingLanePriorityResponse.UpdateSwimmingLanePriority_Data.UpdateSwimmingLanePriority_SwimmingLaneAppRelationShip> data_swimmingLaneAppRelationShipList = new List<UpdateSwimmingLanePriorityResponse.UpdateSwimmingLanePriority_Data.UpdateSwimmingLanePriority_SwimmingLaneAppRelationShip>();
			for (int i = 0; i < _ctx.Length("UpdateSwimmingLanePriority.Data.SwimmingLaneAppRelationShipList.Length"); i++) {
				UpdateSwimmingLanePriorityResponse.UpdateSwimmingLanePriority_Data.UpdateSwimmingLanePriority_SwimmingLaneAppRelationShip swimmingLaneAppRelationShip = new UpdateSwimmingLanePriorityResponse.UpdateSwimmingLanePriority_Data.UpdateSwimmingLanePriority_SwimmingLaneAppRelationShip();
				swimmingLaneAppRelationShip.LaneId = _ctx.LongValue("UpdateSwimmingLanePriority.Data.SwimmingLaneAppRelationShipList["+ i +"].LaneId");
				swimmingLaneAppRelationShip.AppId = _ctx.StringValue("UpdateSwimmingLanePriority.Data.SwimmingLaneAppRelationShipList["+ i +"].AppId");
				swimmingLaneAppRelationShip.Rules = _ctx.StringValue("UpdateSwimmingLanePriority.Data.SwimmingLaneAppRelationShipList["+ i +"].Rules");
				swimmingLaneAppRelationShip.AppName = _ctx.StringValue("UpdateSwimmingLanePriority.Data.SwimmingLaneAppRelationShipList["+ i +"].AppName");

				data_swimmingLaneAppRelationShipList.Add(swimmingLaneAppRelationShip);
			}
			data.SwimmingLaneAppRelationShipList = data_swimmingLaneAppRelationShipList;
			updateSwimmingLanePriorityResponse.Data = data;
        
			return updateSwimmingLanePriorityResponse;
        }
    }
}
