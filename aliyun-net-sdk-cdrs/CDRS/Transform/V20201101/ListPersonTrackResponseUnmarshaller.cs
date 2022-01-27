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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListPersonTrackResponseUnmarshaller
    {
        public static ListPersonTrackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonTrackResponse listPersonTrackResponse = new ListPersonTrackResponse();

			listPersonTrackResponse.HttpResponse = _ctx.HttpResponse;
			listPersonTrackResponse.Code = _ctx.StringValue("ListPersonTrack.Code");
			listPersonTrackResponse.Message = _ctx.StringValue("ListPersonTrack.Message");
			listPersonTrackResponse.RequestId = _ctx.StringValue("ListPersonTrack.RequestId");
			listPersonTrackResponse.PageNumber = _ctx.LongValue("ListPersonTrack.PageNumber");
			listPersonTrackResponse.PageSize = _ctx.LongValue("ListPersonTrack.PageSize");
			listPersonTrackResponse.TotalCount = _ctx.LongValue("ListPersonTrack.TotalCount");

			List<ListPersonTrackResponse.ListPersonTrack_Datas> listPersonTrackResponse_data = new List<ListPersonTrackResponse.ListPersonTrack_Datas>();
			for (int i = 0; i < _ctx.Length("ListPersonTrack.Data.Length"); i++) {
				ListPersonTrackResponse.ListPersonTrack_Datas datas = new ListPersonTrackResponse.ListPersonTrack_Datas();
				datas.PersonId = _ctx.StringValue("ListPersonTrack.Data["+ i +"].PersonId");
				datas.CorpId = _ctx.StringValue("ListPersonTrack.Data["+ i +"].CorpId");
				datas.DataSourceId = _ctx.StringValue("ListPersonTrack.Data["+ i +"].DataSourceId");
				datas.DataSourceName = _ctx.StringValue("ListPersonTrack.Data["+ i +"].DataSourceName");
				datas.PicUrlPath = _ctx.StringValue("ListPersonTrack.Data["+ i +"].PicUrlPath");
				datas.TargetPicUrlPath = _ctx.StringValue("ListPersonTrack.Data["+ i +"].TargetPicUrlPath");
				datas.RightBottomY = _ctx.StringValue("ListPersonTrack.Data["+ i +"].RightBottomY");
				datas.RightBottomX = _ctx.StringValue("ListPersonTrack.Data["+ i +"].RightBottomX");
				datas.LeftTopY = _ctx.StringValue("ListPersonTrack.Data["+ i +"].LeftTopY");
				datas.LeftTopX = _ctx.StringValue("ListPersonTrack.Data["+ i +"].LeftTopX");
				datas.ShotTime = _ctx.StringValue("ListPersonTrack.Data["+ i +"].ShotTime");
				datas.Order = _ctx.StringValue("ListPersonTrack.Data["+ i +"].Order");
				datas.Longitude = _ctx.StringValue("ListPersonTrack.Data["+ i +"].Longitude");
				datas.Latitude = _ctx.StringValue("ListPersonTrack.Data["+ i +"].Latitude");
				datas.SourceUrl = _ctx.StringValue("ListPersonTrack.Data["+ i +"].SourceUrl");
				datas.TargetUrl = _ctx.StringValue("ListPersonTrack.Data["+ i +"].TargetUrl");

				listPersonTrackResponse_data.Add(datas);
			}
			listPersonTrackResponse.Data = listPersonTrackResponse_data;
        
			return listPersonTrackResponse;
        }
    }
}
