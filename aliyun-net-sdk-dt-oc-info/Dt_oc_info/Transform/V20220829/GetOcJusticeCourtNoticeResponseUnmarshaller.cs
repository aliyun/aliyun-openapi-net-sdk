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
    public class GetOcJusticeCourtNoticeResponseUnmarshaller
    {
        public static GetOcJusticeCourtNoticeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeCourtNoticeResponse getOcJusticeCourtNoticeResponse = new GetOcJusticeCourtNoticeResponse();

			getOcJusticeCourtNoticeResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeCourtNoticeResponse.Code = _ctx.StringValue("GetOcJusticeCourtNotice.Code");
			getOcJusticeCourtNoticeResponse.Success = _ctx.BooleanValue("GetOcJusticeCourtNotice.Success");
			getOcJusticeCourtNoticeResponse.Message = _ctx.StringValue("GetOcJusticeCourtNotice.Message");
			getOcJusticeCourtNoticeResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeCourtNotice.TotalNum");
			getOcJusticeCourtNoticeResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeCourtNotice.PageIndex");
			getOcJusticeCourtNoticeResponse.PageNum = _ctx.IntegerValue("GetOcJusticeCourtNotice.PageNum");
			getOcJusticeCourtNoticeResponse.RequestId = _ctx.StringValue("GetOcJusticeCourtNotice.RequestId");

			List<GetOcJusticeCourtNoticeResponse.GetOcJusticeCourtNotice_DataItem> getOcJusticeCourtNoticeResponse_data = new List<GetOcJusticeCourtNoticeResponse.GetOcJusticeCourtNotice_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeCourtNotice.Data.Length"); i++) {
				GetOcJusticeCourtNoticeResponse.GetOcJusticeCourtNotice_DataItem dataItem = new GetOcJusticeCourtNoticeResponse.GetOcJusticeCourtNotice_DataItem();
				dataItem.Party = _ctx.StringValue("GetOcJusticeCourtNotice.Data["+ i +"].Party");
				dataItem.Type = _ctx.StringValue("GetOcJusticeCourtNotice.Data["+ i +"].Type");
				dataItem.Court = _ctx.StringValue("GetOcJusticeCourtNotice.Data["+ i +"].Court");
				dataItem.PublicDate = _ctx.StringValue("GetOcJusticeCourtNotice.Data["+ i +"].PublicDate");
				dataItem.Content = _ctx.StringValue("GetOcJusticeCourtNotice.Data["+ i +"].Content");

				getOcJusticeCourtNoticeResponse_data.Add(dataItem);
			}
			getOcJusticeCourtNoticeResponse.Data = getOcJusticeCourtNoticeResponse_data;
        
			return getOcJusticeCourtNoticeResponse;
        }
    }
}
