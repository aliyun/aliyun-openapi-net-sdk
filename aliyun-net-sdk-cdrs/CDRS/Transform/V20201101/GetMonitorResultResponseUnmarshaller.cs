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
    public class GetMonitorResultResponseUnmarshaller
    {
        public static GetMonitorResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMonitorResultResponse getMonitorResultResponse = new GetMonitorResultResponse();

			getMonitorResultResponse.HttpResponse = _ctx.HttpResponse;
			getMonitorResultResponse.Code = _ctx.StringValue("GetMonitorResult.Code");
			getMonitorResultResponse.Message = _ctx.StringValue("GetMonitorResult.Message");
			getMonitorResultResponse.RequestId = _ctx.StringValue("GetMonitorResult.RequestId");

			GetMonitorResultResponse.GetMonitorResult_Data data = new GetMonitorResultResponse.GetMonitorResult_Data();
			data.MaxId = _ctx.StringValue("GetMonitorResult.Data.MaxId");

			List<GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem> data_records = new List<GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem>();
			for (int i = 0; i < _ctx.Length("GetMonitorResult.Data.Records.Length"); i++) {
				GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem recordsItem = new GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem();
				recordsItem.RightBottomY = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].RightBottomY");
				recordsItem.RightBottomX = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].RightBottomX");
				recordsItem.LeftUpY = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].LeftUpY");
				recordsItem.LeftUpX = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].LeftUpX");
				recordsItem.GbId = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].GbId");
				recordsItem.Score = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].Score");
				recordsItem.PicUrl = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].PicUrl");
				recordsItem.ShotTime = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].ShotTime");
				recordsItem.MonitorPicUrl = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].MonitorPicUrl");
				recordsItem.TargetPicUrl = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].TargetPicUrl");
				recordsItem.TaskId = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].TaskId");

				GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem.GetMonitorResult_ExtendInfo extendInfo = new GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem.GetMonitorResult_ExtendInfo();
				extendInfo.PlateNo = _ctx.StringValue("GetMonitorResult.Data.Records["+ i +"].ExtendInfo.PlateNo");
				recordsItem.ExtendInfo = extendInfo;

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			getMonitorResultResponse.Data = data;
        
			return getMonitorResultResponse;
        }
    }
}
