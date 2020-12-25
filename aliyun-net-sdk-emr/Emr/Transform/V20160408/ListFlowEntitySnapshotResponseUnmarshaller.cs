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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowEntitySnapshotResponseUnmarshaller
    {
        public static ListFlowEntitySnapshotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowEntitySnapshotResponse listFlowEntitySnapshotResponse = new ListFlowEntitySnapshotResponse();

			listFlowEntitySnapshotResponse.HttpResponse = _ctx.HttpResponse;
			listFlowEntitySnapshotResponse.RequestId = _ctx.StringValue("ListFlowEntitySnapshot.RequestId");
			listFlowEntitySnapshotResponse.PageNumber = _ctx.IntegerValue("ListFlowEntitySnapshot.PageNumber");
			listFlowEntitySnapshotResponse.PageSize = _ctx.IntegerValue("ListFlowEntitySnapshot.PageSize");
			listFlowEntitySnapshotResponse.TotalCount = _ctx.IntegerValue("ListFlowEntitySnapshot.TotalCount");

			List<ListFlowEntitySnapshotResponse.ListFlowEntitySnapshot_Item> listFlowEntitySnapshotResponse_items = new List<ListFlowEntitySnapshotResponse.ListFlowEntitySnapshot_Item>();
			for (int i = 0; i < _ctx.Length("ListFlowEntitySnapshot.Items.Length"); i++) {
				ListFlowEntitySnapshotResponse.ListFlowEntitySnapshot_Item item = new ListFlowEntitySnapshotResponse.ListFlowEntitySnapshot_Item();
				item.GmtCreate = _ctx.LongValue("ListFlowEntitySnapshot.Items["+ i +"].GmtCreate");
				item.Revision = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].Revision");
				item.UserId = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].UserId");
				item.CommitterId = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].CommitterId");
				item.Message = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].Message");
				item.EntityId = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].EntityId");
				item.EntityGroupId = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].EntityGroupId");
				item.EntityType = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].EntityType");
				item.Data = _ctx.StringValue("ListFlowEntitySnapshot.Items["+ i +"].Data");
				item.Active = _ctx.BooleanValue("ListFlowEntitySnapshot.Items["+ i +"].Active");

				listFlowEntitySnapshotResponse_items.Add(item);
			}
			listFlowEntitySnapshotResponse.Items = listFlowEntitySnapshotResponse_items;
        
			return listFlowEntitySnapshotResponse;
        }
    }
}
