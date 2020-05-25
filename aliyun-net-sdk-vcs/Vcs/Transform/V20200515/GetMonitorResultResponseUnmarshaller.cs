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
			getMonitorResultResponse.Score = context.StringValue("GetMonitorResult.Score");
			getMonitorResultResponse.LeftTopX = context.StringValue("GetMonitorResult.LeftTopX");
			getMonitorResultResponse.LeftTopY = context.StringValue("GetMonitorResult.LeftTopY");
			getMonitorResultResponse.RightBottomX = context.StringValue("GetMonitorResult.RightBottomX");
			getMonitorResultResponse.RightBottomY = context.StringValue("GetMonitorResult.RightBottomY");

			GetMonitorResultResponse.GetMonitorResult_Data data = new GetMonitorResultResponse.GetMonitorResult_Data();
			data.MaxRecordId = context.StringValue("GetMonitorResult.Data.MaxRecordId");
			getMonitorResultResponse.Data = data;

			List<GetMonitorResultResponse.GetMonitorResult_RecordsItem> getMonitorResultResponse_records = new List<GetMonitorResultResponse.GetMonitorResult_RecordsItem>();
			for (int i = 0; i < context.Length("GetMonitorResult.Records.Length"); i++) {
				GetMonitorResultResponse.GetMonitorResult_RecordsItem recordsItem = new GetMonitorResultResponse.GetMonitorResult_RecordsItem();
				recordsItem.GbId = context.StringValue("GetMonitorResult.Records["+ i +"].GbId");
				recordsItem.ShotTime = context.StringValue("GetMonitorResult.Records["+ i +"].ShotTime");
				recordsItem.MonitorPicUrl = context.StringValue("GetMonitorResult.Records["+ i +"].MonitorPicUrl");
				recordsItem.ShotPicUrl = context.StringValue("GetMonitorResult.Records["+ i +"].ShotPicUrl");

				getMonitorResultResponse_records.Add(recordsItem);
			}
			getMonitorResultResponse.Records = getMonitorResultResponse_records;
        
			return getMonitorResultResponse;
        }
    }
}
