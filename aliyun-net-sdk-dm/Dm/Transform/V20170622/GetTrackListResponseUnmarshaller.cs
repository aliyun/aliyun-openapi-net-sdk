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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class GetTrackListResponseUnmarshaller
    {
        public static GetTrackListResponse Unmarshall(UnmarshallerContext context)
        {
			GetTrackListResponse getTrackListResponse = new GetTrackListResponse();

			getTrackListResponse.HttpResponse = context.HttpResponse;
			getTrackListResponse.RequestId = context.StringValue("GetTrackList.RequestId");
			getTrackListResponse.Total = context.IntegerValue("GetTrackList.Total");
			getTrackListResponse.PageNo = context.IntegerValue("GetTrackList.PageNo");
			getTrackListResponse.PageSize = context.IntegerValue("GetTrackList.PageSize");
			getTrackListResponse.OffsetCreateTime = context.StringValue("GetTrackList.OffsetCreateTime");
			getTrackListResponse.OffsetCreateTimeDesc = context.StringValue("GetTrackList.OffsetCreateTimeDesc");

			List<GetTrackListResponse.GetTrackList_Stat> getTrackListResponse_data = new List<GetTrackListResponse.GetTrackList_Stat>();
			for (int i = 0; i < context.Length("GetTrackList.Data.Length"); i++) {
				GetTrackListResponse.GetTrackList_Stat stat = new GetTrackListResponse.GetTrackList_Stat();
				stat.CreateTime = context.StringValue("GetTrackList.Data["+ i +"].CreateTime");
				stat.RcptClickCount = context.StringValue("GetTrackList.Data["+ i +"].RcptClickCount");
				stat.RcptClickRate = context.StringValue("GetTrackList.Data["+ i +"].RcptClickRate");
				stat.RcptOpenCount = context.StringValue("GetTrackList.Data["+ i +"].RcptOpenCount");
				stat.RcptOpenRate = context.StringValue("GetTrackList.Data["+ i +"].RcptOpenRate");
				stat.RcptUniqueClickCount = context.StringValue("GetTrackList.Data["+ i +"].RcptUniqueClickCount");
				stat.RcptUniqueClickRate = context.StringValue("GetTrackList.Data["+ i +"].RcptUniqueClickRate");
				stat.RcptUniqueOpenCount = context.StringValue("GetTrackList.Data["+ i +"].RcptUniqueOpenCount");
				stat.RcptUniqueOpenRate = context.StringValue("GetTrackList.Data["+ i +"].RcptUniqueOpenRate");
				stat.TotalNumber = context.StringValue("GetTrackList.Data["+ i +"].TotalNumber");

				getTrackListResponse_data.Add(stat);
			}
			getTrackListResponse.Data = getTrackListResponse_data;
        
			return getTrackListResponse;
        }
    }
}
