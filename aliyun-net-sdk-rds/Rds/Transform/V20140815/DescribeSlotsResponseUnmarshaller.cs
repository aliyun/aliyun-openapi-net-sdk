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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSlotsResponseUnmarshaller
    {
        public static DescribeSlotsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlotsResponse describeSlotsResponse = new DescribeSlotsResponse();

			describeSlotsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlotsResponse.RequestId = _ctx.StringValue("DescribeSlots.RequestId");

			List<DescribeSlotsResponse.DescribeSlots_Slot> describeSlotsResponse_slots = new List<DescribeSlotsResponse.DescribeSlots_Slot>();
			for (int i = 0; i < _ctx.Length("DescribeSlots.Slots.Length"); i++) {
				DescribeSlotsResponse.DescribeSlots_Slot slot = new DescribeSlotsResponse.DescribeSlots_Slot();
				slot.SlotName = _ctx.StringValue("DescribeSlots.Slots["+ i +"].SlotName");
				slot.Plugin = _ctx.StringValue("DescribeSlots.Slots["+ i +"].Plugin");
				slot.SlotType = _ctx.StringValue("DescribeSlots.Slots["+ i +"].SlotType");
				slot.Database = _ctx.StringValue("DescribeSlots.Slots["+ i +"].Database");
				slot.Temporary = _ctx.StringValue("DescribeSlots.Slots["+ i +"].Temporary");
				slot.SlotStatus = _ctx.StringValue("DescribeSlots.Slots["+ i +"].SlotStatus");
				slot.WalDelay = _ctx.StringValue("DescribeSlots.Slots["+ i +"].WalDelay");
				slot.SubReplayLag = _ctx.StringValue("DescribeSlots.Slots["+ i +"].SubReplayLag");

				describeSlotsResponse_slots.Add(slot);
			}
			describeSlotsResponse.Slots = describeSlotsResponse_slots;
        
			return describeSlotsResponse;
        }
    }
}
