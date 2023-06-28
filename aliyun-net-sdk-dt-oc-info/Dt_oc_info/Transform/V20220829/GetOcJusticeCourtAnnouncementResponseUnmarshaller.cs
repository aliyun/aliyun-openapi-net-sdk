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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcJusticeCourtAnnouncementResponseUnmarshaller
    {
        public static GetOcJusticeCourtAnnouncementResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeCourtAnnouncementResponse getOcJusticeCourtAnnouncementResponse = new GetOcJusticeCourtAnnouncementResponse();

			getOcJusticeCourtAnnouncementResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeCourtAnnouncementResponse.Code = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Code");
			getOcJusticeCourtAnnouncementResponse.Success = _ctx.BooleanValue("GetOcJusticeCourtAnnouncement.Success");
			getOcJusticeCourtAnnouncementResponse.Message = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Message");
			getOcJusticeCourtAnnouncementResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeCourtAnnouncement.TotalNum");
			getOcJusticeCourtAnnouncementResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeCourtAnnouncement.PageIndex");
			getOcJusticeCourtAnnouncementResponse.PageNum = _ctx.IntegerValue("GetOcJusticeCourtAnnouncement.PageNum");
			getOcJusticeCourtAnnouncementResponse.RequestId = _ctx.StringValue("GetOcJusticeCourtAnnouncement.RequestId");

			List<GetOcJusticeCourtAnnouncementResponse.GetOcJusticeCourtAnnouncement_DataItem> getOcJusticeCourtAnnouncementResponse_data = new List<GetOcJusticeCourtAnnouncementResponse.GetOcJusticeCourtAnnouncement_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeCourtAnnouncement.Data.Length"); i++) {
				GetOcJusticeCourtAnnouncementResponse.GetOcJusticeCourtAnnouncement_DataItem dataItem = new GetOcJusticeCourtAnnouncementResponse.GetOcJusticeCourtAnnouncement_DataItem();
				dataItem.CauseAction = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].CauseAction");
				dataItem.CaseNum = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].CaseNum");
				dataItem.HearingDate = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].HearingDate");
				dataItem.Department = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].Department");
				dataItem.Court = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].Court");
				dataItem.Tribunal = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].Tribunal");
				dataItem.Judge = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].Judge");
				dataItem.Title = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].Title");
				dataItem.Party = _ctx.StringValue("GetOcJusticeCourtAnnouncement.Data["+ i +"].Party");

				getOcJusticeCourtAnnouncementResponse_data.Add(dataItem);
			}
			getOcJusticeCourtAnnouncementResponse.Data = getOcJusticeCourtAnnouncementResponse_data;
        
			return getOcJusticeCourtAnnouncementResponse;
        }
    }
}
