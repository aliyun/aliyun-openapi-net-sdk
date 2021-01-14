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
    public class GetCdrsMonitorResultResponseUnmarshaller
    {
        public static GetCdrsMonitorResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCdrsMonitorResultResponse getCdrsMonitorResultResponse = new GetCdrsMonitorResultResponse();

			getCdrsMonitorResultResponse.HttpResponse = _ctx.HttpResponse;
			getCdrsMonitorResultResponse.Code = _ctx.StringValue("GetCdrsMonitorResult.Code");
			getCdrsMonitorResultResponse.Message = _ctx.StringValue("GetCdrsMonitorResult.Message");
			getCdrsMonitorResultResponse.RequestId = _ctx.StringValue("GetCdrsMonitorResult.RequestId");

			GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data data = new GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data();
			data.MaxId = _ctx.StringValue("GetCdrsMonitorResult.Data.MaxId");

			List<GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data.GetCdrsMonitorResult_RecordsItem> data_records = new List<GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data.GetCdrsMonitorResult_RecordsItem>();
			for (int i = 0; i < _ctx.Length("GetCdrsMonitorResult.Data.Records.Length"); i++) {
				GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data.GetCdrsMonitorResult_RecordsItem recordsItem = new GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data.GetCdrsMonitorResult_RecordsItem();
				recordsItem.RightBottomY = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].RightBottomY");
				recordsItem.RightBottomX = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].RightBottomX");
				recordsItem.LeftUpY = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].LeftUpY");
				recordsItem.LeftUpX = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].LeftUpX");
				recordsItem.GbId = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].GbId");
				recordsItem.Score = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].Score");
				recordsItem.PicUrl = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].PicUrl");
				recordsItem.ShotTime = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].ShotTime");
				recordsItem.MonitorPicUrl = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].MonitorPicUrl");
				recordsItem.TargetPicUrl = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].TargetPicUrl");
				recordsItem.TaskId = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].TaskId");

				GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data.GetCdrsMonitorResult_RecordsItem.GetCdrsMonitorResult_ExtendInfo extendInfo = new GetCdrsMonitorResultResponse.GetCdrsMonitorResult_Data.GetCdrsMonitorResult_RecordsItem.GetCdrsMonitorResult_ExtendInfo();
				extendInfo.PlateNo = _ctx.StringValue("GetCdrsMonitorResult.Data.Records["+ i +"].ExtendInfo.PlateNo");
				recordsItem.ExtendInfo = extendInfo;

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			getCdrsMonitorResultResponse.Data = data;
        
			return getCdrsMonitorResultResponse;
        }
    }
}
