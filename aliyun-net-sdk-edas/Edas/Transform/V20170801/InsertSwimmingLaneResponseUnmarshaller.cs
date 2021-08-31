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
    public class InsertSwimmingLaneResponseUnmarshaller
    {
        public static InsertSwimmingLaneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertSwimmingLaneResponse insertSwimmingLaneResponse = new InsertSwimmingLaneResponse();

			insertSwimmingLaneResponse.HttpResponse = _ctx.HttpResponse;
			insertSwimmingLaneResponse.Code = _ctx.IntegerValue("InsertSwimmingLane.Code");
			insertSwimmingLaneResponse.Message = _ctx.StringValue("InsertSwimmingLane.Message");
			insertSwimmingLaneResponse.RequestId = _ctx.StringValue("InsertSwimmingLane.RequestId");

			InsertSwimmingLaneResponse.InsertSwimmingLane_Data data = new InsertSwimmingLaneResponse.InsertSwimmingLane_Data();
			data.Id = _ctx.LongValue("InsertSwimmingLane.Data.Id");
			data.Name = _ctx.StringValue("InsertSwimmingLane.Data.Name");
			data.Tag = _ctx.StringValue("InsertSwimmingLane.Data.Tag");
			data.NamespaceId = _ctx.StringValue("InsertSwimmingLane.Data.NamespaceId");
			data.GroupId = _ctx.LongValue("InsertSwimmingLane.Data.GroupId");
			data.EntryRule = _ctx.StringValue("InsertSwimmingLane.Data.EntryRule");
			data.AppInfos = _ctx.StringValue("InsertSwimmingLane.Data.AppInfos");

			List<InsertSwimmingLaneResponse.InsertSwimmingLane_Data.InsertSwimmingLane_SwimmingLaneAppRelationShip> data_swimmingLaneAppRelationShipList = new List<InsertSwimmingLaneResponse.InsertSwimmingLane_Data.InsertSwimmingLane_SwimmingLaneAppRelationShip>();
			for (int i = 0; i < _ctx.Length("InsertSwimmingLane.Data.SwimmingLaneAppRelationShipList.Length"); i++) {
				InsertSwimmingLaneResponse.InsertSwimmingLane_Data.InsertSwimmingLane_SwimmingLaneAppRelationShip swimmingLaneAppRelationShip = new InsertSwimmingLaneResponse.InsertSwimmingLane_Data.InsertSwimmingLane_SwimmingLaneAppRelationShip();
				swimmingLaneAppRelationShip.LaneId = _ctx.LongValue("InsertSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].LaneId");
				swimmingLaneAppRelationShip.AppId = _ctx.StringValue("InsertSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].AppId");
				swimmingLaneAppRelationShip.Rules = _ctx.StringValue("InsertSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].Rules");
				swimmingLaneAppRelationShip.AppName = _ctx.StringValue("InsertSwimmingLane.Data.SwimmingLaneAppRelationShipList["+ i +"].AppName");

				data_swimmingLaneAppRelationShipList.Add(swimmingLaneAppRelationShip);
			}
			data.SwimmingLaneAppRelationShipList = data_swimmingLaneAppRelationShipList;
			insertSwimmingLaneResponse.Data = data;
        
			return insertSwimmingLaneResponse;
        }
    }
}
