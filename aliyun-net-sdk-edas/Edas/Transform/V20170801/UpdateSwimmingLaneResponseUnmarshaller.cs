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
    public class UpdateSwimmingLaneResponseUnmarshaller
    {
        public static UpdateSwimmingLaneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateSwimmingLaneResponse updateSwimmingLaneResponse = new UpdateSwimmingLaneResponse();

			updateSwimmingLaneResponse.HttpResponse = _ctx.HttpResponse;
			updateSwimmingLaneResponse.Code = _ctx.IntegerValue("UpdateSwimmingLane.Code");
			updateSwimmingLaneResponse.Message = _ctx.StringValue("UpdateSwimmingLane.Message");
			updateSwimmingLaneResponse.RequestId = _ctx.StringValue("UpdateSwimmingLane.RequestId");

			UpdateSwimmingLaneResponse.UpdateSwimmingLane_Data data = new UpdateSwimmingLaneResponse.UpdateSwimmingLane_Data();
			data.Id = _ctx.LongValue("UpdateSwimmingLane.Data.Id");
			data.Name = _ctx.StringValue("UpdateSwimmingLane.Data.Name");
			data.Tag = _ctx.StringValue("UpdateSwimmingLane.Data.Tag");
			data.NamespaceId = _ctx.StringValue("UpdateSwimmingLane.Data.NamespaceId");
			data.GroupId = _ctx.LongValue("UpdateSwimmingLane.Data.GroupId");
			data.EntryRule = _ctx.StringValue("UpdateSwimmingLane.Data.EntryRule");

			List<UpdateSwimmingLaneResponse.UpdateSwimmingLane_Data.UpdateSwimmingLane_SwimmingLaneAppRelationShip> data_swimmingLaneAppRelationShipList = new List<UpdateSwimmingLaneResponse.UpdateSwimmingLane_Data.UpdateSwimmingLane_SwimmingLaneAppRelationShip>();
			for (int i = 0; i < _ctx.Length("UpdateSwimmingLane.Data.SwimmingLaneAppRelationShipList.Length"); i++) {
				UpdateSwimmingLaneResponse.UpdateSwimmingLane_Data.UpdateSwimmingLane_SwimmingLaneAppRelationShip swimmingLaneAppRelationShip = new UpdateSwimmingLaneResponse.UpdateSwimmingLane_Data.UpdateSwimmingLane_SwimmingLaneAppRelationShip();
				swimmingLaneAppRelationShip.LaneId = _ctx.LongValue("UpdateSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].LaneId");
				swimmingLaneAppRelationShip.AppId = _ctx.StringValue("UpdateSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].AppId");
				swimmingLaneAppRelationShip.Rules = _ctx.StringValue("UpdateSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].Rules");
				swimmingLaneAppRelationShip.AppName = _ctx.StringValue("UpdateSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].AppName");

				data_swimmingLaneAppRelationShipList.Add(swimmingLaneAppRelationShip);
			}
			data.SwimmingLaneAppRelationShipList = data_swimmingLaneAppRelationShipList;
			updateSwimmingLaneResponse.Data = data;
        
			return updateSwimmingLaneResponse;
        }
    }
}
