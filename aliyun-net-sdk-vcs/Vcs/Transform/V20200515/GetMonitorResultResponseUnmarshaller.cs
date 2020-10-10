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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetMonitorResultResponseUnmarshaller
    {
        public static GetMonitorResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetMonitorResultResponse getMonitorResultResponse = new GetMonitorResultResponse();

			getMonitorResultResponse.HttpResponse = context.HttpResponse;
			getMonitorResultResponse.Code = context.StringValue("GetMonitorResult.Code");
			getMonitorResultResponse.Message = context.StringValue("GetMonitorResult.Message");
			getMonitorResultResponse.RequestId = context.StringValue("GetMonitorResult.RequestId");

			GetMonitorResultResponse.GetMonitorResult_Data data = new GetMonitorResultResponse.GetMonitorResult_Data();
			data.MaxId = context.StringValue("GetMonitorResult.Data.MaxId");

			List<GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem> data_records = new List<GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem>();
			for (int i = 0; i < context.Length("GetMonitorResult.Data.Records.Length"); i++) {
				GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem recordsItem = new GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem();
				recordsItem.RightBottomY = context.StringValue("GetMonitorResult.Data.Records["+ i +"].RightBottomY");
				recordsItem.RightBottomX = context.StringValue("GetMonitorResult.Data.Records["+ i +"].RightBottomX");
				recordsItem.LeftUpY = context.StringValue("GetMonitorResult.Data.Records["+ i +"].LeftUpY");
				recordsItem.LeftUpX = context.StringValue("GetMonitorResult.Data.Records["+ i +"].LeftUpX");
				recordsItem.GbId = context.StringValue("GetMonitorResult.Data.Records["+ i +"].GbId");
				recordsItem.Score = context.StringValue("GetMonitorResult.Data.Records["+ i +"].Score");
				recordsItem.PicUrl = context.StringValue("GetMonitorResult.Data.Records["+ i +"].PicUrl");
				recordsItem.ShotTime = context.StringValue("GetMonitorResult.Data.Records["+ i +"].ShotTime");
				recordsItem.MonitorPicUrl = context.StringValue("GetMonitorResult.Data.Records["+ i +"].MonitorPicUrl");
				recordsItem.TargetPicUrl = context.StringValue("GetMonitorResult.Data.Records["+ i +"].TargetPicUrl");
				recordsItem.TaskId = context.StringValue("GetMonitorResult.Data.Records["+ i +"].TaskId");

				GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem.GetMonitorResult_ExtendInfo extendInfo = new GetMonitorResultResponse.GetMonitorResult_Data.GetMonitorResult_RecordsItem.GetMonitorResult_ExtendInfo();
				extendInfo.PlateNo = context.StringValue("GetMonitorResult.Data.Records["+ i +"].ExtendInfo.PlateNo");
				recordsItem.ExtendInfo = extendInfo;

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			getMonitorResultResponse.Data = data;
        
			return getMonitorResultResponse;
        }
    }
}
