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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class PageQuerySpeechBroadcastHourResponseUnmarshaller
    {
        public static PageQuerySpeechBroadcastHourResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PageQuerySpeechBroadcastHourResponse pageQuerySpeechBroadcastHourResponse = new PageQuerySpeechBroadcastHourResponse();

			pageQuerySpeechBroadcastHourResponse.HttpResponse = _ctx.HttpResponse;
			pageQuerySpeechBroadcastHourResponse.RequestId = _ctx.StringValue("PageQuerySpeechBroadcastHour.RequestId");
			pageQuerySpeechBroadcastHourResponse.Success = _ctx.BooleanValue("PageQuerySpeechBroadcastHour.Success");
			pageQuerySpeechBroadcastHourResponse.Code = _ctx.StringValue("PageQuerySpeechBroadcastHour.Code");
			pageQuerySpeechBroadcastHourResponse.ErrorMessage = _ctx.StringValue("PageQuerySpeechBroadcastHour.ErrorMessage");

			PageQuerySpeechBroadcastHourResponse.PageQuerySpeechBroadcastHour_Data data = new PageQuerySpeechBroadcastHourResponse.PageQuerySpeechBroadcastHour_Data();
			data.PageId = _ctx.IntegerValue("PageQuerySpeechBroadcastHour.Data.PageId");
			data.PageSize = _ctx.IntegerValue("PageQuerySpeechBroadcastHour.Data.PageSize");
			data.Total = _ctx.IntegerValue("PageQuerySpeechBroadcastHour.Data.Total");
			data.PageToken = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.PageToken");

			List<PageQuerySpeechBroadcastHourResponse.PageQuerySpeechBroadcastHour_Data.PageQuerySpeechBroadcastHour_Data1> data_resultData = new List<PageQuerySpeechBroadcastHourResponse.PageQuerySpeechBroadcastHour_Data.PageQuerySpeechBroadcastHour_Data1>();
			for (int i = 0; i < _ctx.Length("PageQuerySpeechBroadcastHour.Data.ResultData.Length"); i++) {
				PageQuerySpeechBroadcastHourResponse.PageQuerySpeechBroadcastHour_Data.PageQuerySpeechBroadcastHour_Data1 data1 = new PageQuerySpeechBroadcastHourResponse.PageQuerySpeechBroadcastHour_Data.PageQuerySpeechBroadcastHour_Data1();
				data1.ProductKey = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].ProductKey");
				data1.DeviceName = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].DeviceName");
				data1.ShareTaskCode = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].ShareTaskCode");
				data1.Speechs = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].Speechs");
				data1.Code = _ctx.IntegerValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].Code");
				data1.Msg = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].Msg");
				data1.SpeechId = _ctx.StringValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].SpeechId");
				data1.StartTime = _ctx.LongValue("PageQuerySpeechBroadcastHour.Data.ResultData["+ i +"].StartTime");

				data_resultData.Add(data1);
			}
			data.ResultData = data_resultData;
			pageQuerySpeechBroadcastHourResponse.Data = data;
        
			return pageQuerySpeechBroadcastHourResponse;
        }
    }
}
