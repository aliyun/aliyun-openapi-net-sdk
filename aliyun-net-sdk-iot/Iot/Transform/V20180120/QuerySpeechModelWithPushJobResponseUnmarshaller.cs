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
    public class QuerySpeechModelWithPushJobResponseUnmarshaller
    {
        public static QuerySpeechModelWithPushJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechModelWithPushJobResponse querySpeechModelWithPushJobResponse = new QuerySpeechModelWithPushJobResponse();

			querySpeechModelWithPushJobResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechModelWithPushJobResponse.RequestId = _ctx.StringValue("QuerySpeechModelWithPushJob.RequestId");
			querySpeechModelWithPushJobResponse.Success = _ctx.BooleanValue("QuerySpeechModelWithPushJob.Success");
			querySpeechModelWithPushJobResponse.Code = _ctx.StringValue("QuerySpeechModelWithPushJob.Code");
			querySpeechModelWithPushJobResponse.ErrorMessage = _ctx.StringValue("QuerySpeechModelWithPushJob.ErrorMessage");

			QuerySpeechModelWithPushJobResponse.QuerySpeechModelWithPushJob_Data data = new QuerySpeechModelWithPushJobResponse.QuerySpeechModelWithPushJob_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechModelWithPushJob.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechModelWithPushJob.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechModelWithPushJob.Data.PageSize");

			List<QuerySpeechModelWithPushJobResponse.QuerySpeechModelWithPushJob_Data.QuerySpeechModelWithPushJob_Items> data_list = new List<QuerySpeechModelWithPushJobResponse.QuerySpeechModelWithPushJob_Data.QuerySpeechModelWithPushJob_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechModelWithPushJob.Data.List.Length"); i++) {
				QuerySpeechModelWithPushJobResponse.QuerySpeechModelWithPushJob_Data.QuerySpeechModelWithPushJob_Items items = new QuerySpeechModelWithPushJobResponse.QuerySpeechModelWithPushJob_Data.QuerySpeechModelWithPushJob_Items();
				items.BizCode = _ctx.StringValue("QuerySpeechModelWithPushJob.Data.List["+ i +"].BizCode");
				items.Text = _ctx.StringValue("QuerySpeechModelWithPushJob.Data.List["+ i +"].Text");
				items.Voice = _ctx.StringValue("QuerySpeechModelWithPushJob.Data.List["+ i +"].Voice");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechModelWithPushJobResponse.Data = data;
        
			return querySpeechModelWithPushJobResponse;
        }
    }
}
