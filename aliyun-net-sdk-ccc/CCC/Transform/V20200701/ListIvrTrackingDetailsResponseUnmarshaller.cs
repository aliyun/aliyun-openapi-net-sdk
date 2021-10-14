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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListIvrTrackingDetailsResponseUnmarshaller
    {
        public static ListIvrTrackingDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIvrTrackingDetailsResponse listIvrTrackingDetailsResponse = new ListIvrTrackingDetailsResponse();

			listIvrTrackingDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listIvrTrackingDetailsResponse.Code = _ctx.StringValue("ListIvrTrackingDetails.Code");
			listIvrTrackingDetailsResponse.HttpStatusCode = _ctx.IntegerValue("ListIvrTrackingDetails.HttpStatusCode");
			listIvrTrackingDetailsResponse.Message = _ctx.StringValue("ListIvrTrackingDetails.Message");
			listIvrTrackingDetailsResponse.RequestId = _ctx.StringValue("ListIvrTrackingDetails.RequestId");

			ListIvrTrackingDetailsResponse.ListIvrTrackingDetails_Data data = new ListIvrTrackingDetailsResponse.ListIvrTrackingDetails_Data();
			data.PageNumber = _ctx.IntegerValue("ListIvrTrackingDetails.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListIvrTrackingDetails.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListIvrTrackingDetails.Data.TotalCount");

			List<ListIvrTrackingDetailsResponse.ListIvrTrackingDetails_Data.ListIvrTrackingDetails_IvrTracking> data_list = new List<ListIvrTrackingDetailsResponse.ListIvrTrackingDetails_Data.ListIvrTrackingDetails_IvrTracking>();
			for (int i = 0; i < _ctx.Length("ListIvrTrackingDetails.Data.List.Length"); i++) {
				ListIvrTrackingDetailsResponse.ListIvrTrackingDetails_Data.ListIvrTrackingDetails_IvrTracking ivrTracking = new ListIvrTrackingDetailsResponse.ListIvrTrackingDetails_Data.ListIvrTrackingDetails_IvrTracking();
				ivrTracking.Callee = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].Callee");
				ivrTracking.Caller = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].Caller");
				ivrTracking.ChannelId = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].ChannelId");
				ivrTracking.ChannelVariables = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].ChannelVariables");
				ivrTracking.ContactId = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].ContactId");
				ivrTracking.EnterTime = _ctx.LongValue("ListIvrTrackingDetails.Data.List["+ i +"].EnterTime");
				ivrTracking.FlowId = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].FlowId");
				ivrTracking.FlowName = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].FlowName");
				ivrTracking.Instance = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].Instance");
				ivrTracking.LeaveTime = _ctx.LongValue("ListIvrTrackingDetails.Data.List["+ i +"].LeaveTime");
				ivrTracking.NodeExitCode = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].NodeExitCode");
				ivrTracking.NodeId = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].NodeId");
				ivrTracking.NodeName = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].NodeName");
				ivrTracking.NodeProperties = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].NodeProperties");
				ivrTracking.NodeType = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].NodeType");
				ivrTracking.NodeVariables = _ctx.StringValue("ListIvrTrackingDetails.Data.List["+ i +"].NodeVariables");

				data_list.Add(ivrTracking);
			}
			data.List = data_list;
			listIvrTrackingDetailsResponse.Data = data;
        
			return listIvrTrackingDetailsResponse;
        }
    }
}
