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
    public class ListSwimmingLaneResponseUnmarshaller
    {
        public static ListSwimmingLaneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSwimmingLaneResponse listSwimmingLaneResponse = new ListSwimmingLaneResponse();

			listSwimmingLaneResponse.HttpResponse = _ctx.HttpResponse;
			listSwimmingLaneResponse.Code = _ctx.IntegerValue("ListSwimmingLane.Code");
			listSwimmingLaneResponse.Message = _ctx.StringValue("ListSwimmingLane.Message");
			listSwimmingLaneResponse.RequestId = _ctx.StringValue("ListSwimmingLane.RequestId");

			List<ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane> listSwimmingLaneResponse_data = new List<ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane>();
			for (int i = 0; i < _ctx.Length("ListSwimmingLane.Data.Length"); i++) {
				ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane swimmingLane = new ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane();
				swimmingLane.Id = _ctx.LongValue("ListSwimmingLane.Data["+ i +"].Id");
				swimmingLane.Name = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].Name");
				swimmingLane.Tag = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].Tag");
				swimmingLane.NamespaceId = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].NamespaceId");
				swimmingLane.GroupId = _ctx.LongValue("ListSwimmingLane.Data["+ i +"].GroupId");
				swimmingLane.EntryRule = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].EntryRule");
				swimmingLane.EnableRules = _ctx.BooleanValue("ListSwimmingLane.Data["+ i +"].EnableRules");
				swimmingLane.ScenarioSign = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].ScenarioSign");

				List<ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane.ListSwimmingLane_SwimmingLaneAppRelationShip> swimmingLane_swimmingLaneAppRelationShipList = new List<ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane.ListSwimmingLane_SwimmingLaneAppRelationShip>();
				for (int j = 0; j < _ctx.Length("ListSwimmingLane.Data["+ i +"].SwimmingLaneAppRelationShipList.Length"); j++) {
					ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane.ListSwimmingLane_SwimmingLaneAppRelationShip swimmingLaneAppRelationShip = new ListSwimmingLaneResponse.ListSwimmingLane_SwimmingLane.ListSwimmingLane_SwimmingLaneAppRelationShip();
					swimmingLaneAppRelationShip.LaneId = _ctx.LongValue("ListSwimmingLane.Data["+ i +"].SwimmingLaneAppRelationShipList["+ j +"].LaneId");
					swimmingLaneAppRelationShip.AppId = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].SwimmingLaneAppRelationShipList["+ j +"].AppId");
					swimmingLaneAppRelationShip.AppName = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].SwimmingLaneAppRelationShipList["+ j +"].AppName");
					swimmingLaneAppRelationShip.Rules = _ctx.StringValue("ListSwimmingLane.Data["+ i +"].SwimmingLaneAppRelationShipList["+ j +"].Rules");

					swimmingLane_swimmingLaneAppRelationShipList.Add(swimmingLaneAppRelationShip);
				}
				swimmingLane.SwimmingLaneAppRelationShipList = swimmingLane_swimmingLaneAppRelationShipList;

				listSwimmingLaneResponse_data.Add(swimmingLane);
			}
			listSwimmingLaneResponse.Data = listSwimmingLaneResponse_data;
        
			return listSwimmingLaneResponse;
        }
    }
}
