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
    public class ListVehicleTrackResponseUnmarshaller
    {
        public static ListVehicleTrackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVehicleTrackResponse listVehicleTrackResponse = new ListVehicleTrackResponse();

			listVehicleTrackResponse.HttpResponse = _ctx.HttpResponse;
			listVehicleTrackResponse.Code = _ctx.StringValue("ListVehicleTrack.Code");
			listVehicleTrackResponse.Message = _ctx.StringValue("ListVehicleTrack.Message");
			listVehicleTrackResponse.RequestId = _ctx.StringValue("ListVehicleTrack.RequestId");
			listVehicleTrackResponse.PageNumber = _ctx.LongValue("ListVehicleTrack.PageNumber");
			listVehicleTrackResponse.PageSize = _ctx.LongValue("ListVehicleTrack.PageSize");
			listVehicleTrackResponse.TotalCount = _ctx.LongValue("ListVehicleTrack.TotalCount");

			List<ListVehicleTrackResponse.ListVehicleTrack_Datas> listVehicleTrackResponse_data = new List<ListVehicleTrackResponse.ListVehicleTrack_Datas>();
			for (int i = 0; i < _ctx.Length("ListVehicleTrack.Data.Length"); i++) {
				ListVehicleTrackResponse.ListVehicleTrack_Datas datas = new ListVehicleTrackResponse.ListVehicleTrack_Datas();
				datas.PlateId = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].PlateId");
				datas.CorpId = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].CorpId");
				datas.DataSourceId = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].DataSourceId");
				datas.DataSourceName = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].DataSourceName");
				datas.PicUrlPath = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].PicUrlPath");
				datas.TargetPicUrlPath = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].TargetPicUrlPath");
				datas.RightBottomY = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].RightBottomY");
				datas.RightBottomX = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].RightBottomX");
				datas.LeftTopY = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].LeftTopY");
				datas.LeftTopX = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].LeftTopX");
				datas.PassTime = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].PassTime");
				datas.Order = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].Order");
				datas.Latitude = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].Latitude");
				datas.Longitude = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].Longitude");
				datas.SourceUrl = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].SourceUrl");
				datas.TargetUrl = _ctx.StringValue("ListVehicleTrack.Data["+ i +"].TargetUrl");

				listVehicleTrackResponse_data.Add(datas);
			}
			listVehicleTrackResponse.Data = listVehicleTrackResponse_data;
        
			return listVehicleTrackResponse;
        }
    }
}
