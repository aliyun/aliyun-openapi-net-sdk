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
    public class QuerySpeechPushJobResponseUnmarshaller
    {
        public static QuerySpeechPushJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechPushJobResponse querySpeechPushJobResponse = new QuerySpeechPushJobResponse();

			querySpeechPushJobResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechPushJobResponse.RequestId = _ctx.StringValue("QuerySpeechPushJob.RequestId");
			querySpeechPushJobResponse.Success = _ctx.BooleanValue("QuerySpeechPushJob.Success");
			querySpeechPushJobResponse.Code = _ctx.StringValue("QuerySpeechPushJob.Code");
			querySpeechPushJobResponse.ErrorMessage = _ctx.StringValue("QuerySpeechPushJob.ErrorMessage");

			QuerySpeechPushJobResponse.QuerySpeechPushJob_Data data = new QuerySpeechPushJobResponse.QuerySpeechPushJob_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechPushJob.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechPushJob.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechPushJob.Data.PageSize");

			List<QuerySpeechPushJobResponse.QuerySpeechPushJob_Data.QuerySpeechPushJob_Items> data_list = new List<QuerySpeechPushJobResponse.QuerySpeechPushJob_Data.QuerySpeechPushJob_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechPushJob.Data.List.Length"); i++) {
				QuerySpeechPushJobResponse.QuerySpeechPushJob_Data.QuerySpeechPushJob_Items items = new QuerySpeechPushJobResponse.QuerySpeechPushJob_Data.QuerySpeechPushJob_Items();
				items.Code = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].Code");
				items.ExpiredTime = _ctx.LongValue("QuerySpeechPushJob.Data.List["+ i +"].ExpiredTime");
				items.PushMode = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].PushMode");
				items.IotId = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].IotId");
				items.Status = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].Status");
				items.CreatedTime = _ctx.LongValue("QuerySpeechPushJob.Data.List["+ i +"].CreatedTime");
				items.TotalDeviceNum = _ctx.IntegerValue("QuerySpeechPushJob.Data.List["+ i +"].TotalDeviceNum");
				items.SuccessDeviceNum = _ctx.IntegerValue("QuerySpeechPushJob.Data.List["+ i +"].SuccessDeviceNum");
				items.SpeechStatus = _ctx.BooleanValue("QuerySpeechPushJob.Data.List["+ i +"].SpeechStatus");
				items.FailDeviceNum = _ctx.IntegerValue("QuerySpeechPushJob.Data.List["+ i +"].FailDeviceNum");
				items.SpeechNum = _ctx.IntegerValue("QuerySpeechPushJob.Data.List["+ i +"].SpeechNum");
				items.RunningDeviceNum = _ctx.IntegerValue("QuerySpeechPushJob.Data.List["+ i +"].RunningDeviceNum");
				items.GroupId = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].GroupId");
				items.GroupName = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].GroupName");
				items.ProductKey = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].ProductKey");
				items.DeviceName = _ctx.StringValue("QuerySpeechPushJob.Data.List["+ i +"].DeviceName");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechPushJobResponse.Data = data;
        
			return querySpeechPushJobResponse;
        }
    }
}
