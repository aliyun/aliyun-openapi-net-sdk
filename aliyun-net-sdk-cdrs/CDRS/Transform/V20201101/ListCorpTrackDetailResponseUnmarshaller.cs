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
    public class ListCorpTrackDetailResponseUnmarshaller
    {
        public static ListCorpTrackDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCorpTrackDetailResponse listCorpTrackDetailResponse = new ListCorpTrackDetailResponse();

			listCorpTrackDetailResponse.HttpResponse = _ctx.HttpResponse;
			listCorpTrackDetailResponse.Code = _ctx.StringValue("ListCorpTrackDetail.Code");
			listCorpTrackDetailResponse.Message = _ctx.StringValue("ListCorpTrackDetail.Message");
			listCorpTrackDetailResponse.RequestId = _ctx.StringValue("ListCorpTrackDetail.RequestId");
			listCorpTrackDetailResponse.Success = _ctx.StringValue("ListCorpTrackDetail.Success");
			listCorpTrackDetailResponse.TotalCount = _ctx.IntegerValue("ListCorpTrackDetail.TotalCount");
			listCorpTrackDetailResponse.PageSize = _ctx.IntegerValue("ListCorpTrackDetail.PageSize");
			listCorpTrackDetailResponse.PageNumber = _ctx.IntegerValue("ListCorpTrackDetail.PageNumber");

			List<ListCorpTrackDetailResponse.ListCorpTrackDetail_DataItem> listCorpTrackDetailResponse_data = new List<ListCorpTrackDetailResponse.ListCorpTrackDetail_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCorpTrackDetail.Data.Length"); i++) {
				ListCorpTrackDetailResponse.ListCorpTrackDetail_DataItem dataItem = new ListCorpTrackDetailResponse.ListCorpTrackDetail_DataItem();
				dataItem.Date = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].Date");
				dataItem.LastTime = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].LastTime");
				dataItem.StartTime = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].StartTime");
				dataItem.EndSourceImage = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].EndSourceImage");
				dataItem.DeviceId = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].DeviceId");
				dataItem.StartTargetImage = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].StartTargetImage");
				dataItem.GroupId = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].GroupId");
				dataItem.PersonId = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].PersonId");
				dataItem.StartSourceImage = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].StartSourceImage");
				dataItem.CorpId = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].CorpId");
				dataItem.EndTargetImage = _ctx.StringValue("ListCorpTrackDetail.Data["+ i +"].EndTargetImage");

				listCorpTrackDetailResponse_data.Add(dataItem);
			}
			listCorpTrackDetailResponse.Data = listCorpTrackDetailResponse_data;
        
			return listCorpTrackDetailResponse;
        }
    }
}
