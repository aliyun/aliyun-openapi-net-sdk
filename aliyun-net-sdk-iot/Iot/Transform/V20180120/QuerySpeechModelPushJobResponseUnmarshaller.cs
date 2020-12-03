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
    public class QuerySpeechModelPushJobResponseUnmarshaller
    {
        public static QuerySpeechModelPushJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechModelPushJobResponse querySpeechModelPushJobResponse = new QuerySpeechModelPushJobResponse();

			querySpeechModelPushJobResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechModelPushJobResponse.RequestId = _ctx.StringValue("QuerySpeechModelPushJob.RequestId");
			querySpeechModelPushJobResponse.Success = _ctx.BooleanValue("QuerySpeechModelPushJob.Success");
			querySpeechModelPushJobResponse.Code = _ctx.StringValue("QuerySpeechModelPushJob.Code");
			querySpeechModelPushJobResponse.ErrorMessage = _ctx.StringValue("QuerySpeechModelPushJob.ErrorMessage");

			QuerySpeechModelPushJobResponse.QuerySpeechModelPushJob_Data data = new QuerySpeechModelPushJobResponse.QuerySpeechModelPushJob_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.PageSize");

			List<QuerySpeechModelPushJobResponse.QuerySpeechModelPushJob_Data.QuerySpeechModelPushJob_Items> data_list = new List<QuerySpeechModelPushJobResponse.QuerySpeechModelPushJob_Data.QuerySpeechModelPushJob_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechModelPushJob.Data.List.Length"); i++) {
				QuerySpeechModelPushJobResponse.QuerySpeechModelPushJob_Data.QuerySpeechModelPushJob_Items items = new QuerySpeechModelPushJobResponse.QuerySpeechModelPushJob_Data.QuerySpeechModelPushJob_Items();
				items.Code = _ctx.StringValue("QuerySpeechModelPushJob.Data.List["+ i +"].Code");
				items.ExpiredTime = _ctx.LongValue("QuerySpeechModelPushJob.Data.List["+ i +"].ExpiredTime");
				items.PushMode = _ctx.StringValue("QuerySpeechModelPushJob.Data.List["+ i +"].PushMode");
				items.IotId = _ctx.StringValue("QuerySpeechModelPushJob.Data.List["+ i +"].IotId");
				items.Status = _ctx.StringValue("QuerySpeechModelPushJob.Data.List["+ i +"].Status");
				items.CreatedTime = _ctx.LongValue("QuerySpeechModelPushJob.Data.List["+ i +"].CreatedTime");
				items.TotalDeviceNum = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.List["+ i +"].TotalDeviceNum");
				items.SuccessDeviceNum = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.List["+ i +"].SuccessDeviceNum");
				items.SpeechModelStatus = _ctx.BooleanValue("QuerySpeechModelPushJob.Data.List["+ i +"].SpeechModelStatus");
				items.FailDeviceNum = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.List["+ i +"].FailDeviceNum");
				items.SpeechModelNum = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.List["+ i +"].SpeechModelNum");
				items.RunningDeviceNum = _ctx.IntegerValue("QuerySpeechModelPushJob.Data.List["+ i +"].RunningDeviceNum");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechModelPushJobResponse.Data = data;
        
			return querySpeechModelPushJobResponse;
        }
    }
}
