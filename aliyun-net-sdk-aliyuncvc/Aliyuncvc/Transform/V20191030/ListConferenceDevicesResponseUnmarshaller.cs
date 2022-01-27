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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class ListConferenceDevicesResponseUnmarshaller
    {
        public static ListConferenceDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConferenceDevicesResponse listConferenceDevicesResponse = new ListConferenceDevicesResponse();

			listConferenceDevicesResponse.HttpResponse = _ctx.HttpResponse;
			listConferenceDevicesResponse.ErrorCode = _ctx.IntegerValue("ListConferenceDevices.ErrorCode");
			listConferenceDevicesResponse.Message = _ctx.StringValue("ListConferenceDevices.Message");
			listConferenceDevicesResponse.Success = _ctx.BooleanValue("ListConferenceDevices.Success");
			listConferenceDevicesResponse.RequestId = _ctx.StringValue("ListConferenceDevices.RequestId");

			ListConferenceDevicesResponse.ListConferenceDevices_ConferencesDatas conferencesDatas = new ListConferenceDevicesResponse.ListConferenceDevices_ConferencesDatas();
			conferencesDatas.Total = _ctx.IntegerValue("ListConferenceDevices.ConferencesDatas.Total");
			conferencesDatas.PageSize = _ctx.IntegerValue("ListConferenceDevices.ConferencesDatas.PageSize");
			conferencesDatas.PageNumber = _ctx.IntegerValue("ListConferenceDevices.ConferencesDatas.PageNumber");

			List<ListConferenceDevicesResponse.ListConferenceDevices_ConferencesDatas.ListConferenceDevices_Data> conferencesDatas_conferences = new List<ListConferenceDevicesResponse.ListConferenceDevices_ConferencesDatas.ListConferenceDevices_Data>();
			for (int i = 0; i < _ctx.Length("ListConferenceDevices.ConferencesDatas.Conferences.Length"); i++) {
				ListConferenceDevicesResponse.ListConferenceDevices_ConferencesDatas.ListConferenceDevices_Data data = new ListConferenceDevicesResponse.ListConferenceDevices_ConferencesDatas.ListConferenceDevices_Data();
				data.ActivationCode = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].ActivationCode");
				data.ConferenceCode = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].ConferenceCode");
				data.ConferenceName = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].ConferenceName");
				data.CreateTime = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].CreateTime");
				data.DeviceModel = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].DeviceModel");
				data.Manufacturer = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].Manufacturer");
				data.PictureUrl = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].PictureUrl");
				data.SN = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].SN");
				data.Status = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].Status");
				data.CastScreenCode = _ctx.StringValue("ListConferenceDevices.ConferencesDatas.Conferences["+ i +"].CastScreenCode");

				conferencesDatas_conferences.Add(data);
			}
			conferencesDatas.Conferences = conferencesDatas_conferences;
			listConferenceDevicesResponse.ConferencesDatas = conferencesDatas;
        
			return listConferenceDevicesResponse;
        }
    }
}
