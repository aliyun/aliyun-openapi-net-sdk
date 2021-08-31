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
    public class GetSwimmingLaneResponseUnmarshaller
    {
        public static GetSwimmingLaneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSwimmingLaneResponse getSwimmingLaneResponse = new GetSwimmingLaneResponse();

			getSwimmingLaneResponse.HttpResponse = _ctx.HttpResponse;
			getSwimmingLaneResponse.Code = _ctx.IntegerValue("GetSwimmingLane.Code");
			getSwimmingLaneResponse.Message = _ctx.StringValue("GetSwimmingLane.Message");
			getSwimmingLaneResponse.RequestId = _ctx.StringValue("GetSwimmingLane.RequestId");

			GetSwimmingLaneResponse.GetSwimmingLane_Data data = new GetSwimmingLaneResponse.GetSwimmingLane_Data();
			data.Id = _ctx.StringValue("GetSwimmingLane.Data.Id");
			data.Name = _ctx.StringValue("GetSwimmingLane.Data.Name");
			data.Tag = _ctx.StringValue("GetSwimmingLane.Data.Tag");
			data.NamespaceId = _ctx.StringValue("GetSwimmingLane.Data.NamespaceId");
			data.GroupId = _ctx.LongValue("GetSwimmingLane.Data.GroupId");
			data.EntryRule = _ctx.StringValue("GetSwimmingLane.Data.EntryRule");
			data.EnableRules = _ctx.BooleanValue("GetSwimmingLane.Data.EnableRules");
			data.ScenarioSign = _ctx.StringValue("GetSwimmingLane.Data.ScenarioSign");

			List<GetSwimmingLaneResponse.GetSwimmingLane_Data.GetSwimmingLane_SwimmingLaneAppRelationShip> data_swimmingLaneAppRelationShipList = new List<GetSwimmingLaneResponse.GetSwimmingLane_Data.GetSwimmingLane_SwimmingLaneAppRelationShip>();
			for (int i = 0; i < _ctx.Length("GetSwimmingLane.Data.SwimmingLaneAppRelationShipList.Length"); i++) {
				GetSwimmingLaneResponse.GetSwimmingLane_Data.GetSwimmingLane_SwimmingLaneAppRelationShip swimmingLaneAppRelationShip = new GetSwimmingLaneResponse.GetSwimmingLane_Data.GetSwimmingLane_SwimmingLaneAppRelationShip();
				swimmingLaneAppRelationShip.LaneId = _ctx.LongValue("GetSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].LaneId");
				swimmingLaneAppRelationShip.AppId = _ctx.StringValue("GetSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].AppId");
				swimmingLaneAppRelationShip.AppName = _ctx.StringValue("GetSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].AppName");
				swimmingLaneAppRelationShip.Rules = _ctx.StringValue("GetSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].Rules");

				data_swimmingLaneAppRelationShipList.Add(swimmingLaneAppRelationShip);
			}
			data.SwimmingLaneAppRelationShipList = data_swimmingLaneAppRelationShipList;
			getSwimmingLaneResponse.Data = data;
        
			return getSwimmingLaneResponse;
        }
    }
}
