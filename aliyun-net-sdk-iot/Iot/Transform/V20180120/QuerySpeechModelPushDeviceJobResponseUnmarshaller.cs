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
    public class QuerySpeechModelPushDeviceJobResponseUnmarshaller
    {
        public static QuerySpeechModelPushDeviceJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechModelPushDeviceJobResponse querySpeechModelPushDeviceJobResponse = new QuerySpeechModelPushDeviceJobResponse();

			querySpeechModelPushDeviceJobResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechModelPushDeviceJobResponse.RequestId = _ctx.StringValue("QuerySpeechModelPushDeviceJob.RequestId");
			querySpeechModelPushDeviceJobResponse.Success = _ctx.BooleanValue("QuerySpeechModelPushDeviceJob.Success");
			querySpeechModelPushDeviceJobResponse.Code = _ctx.StringValue("QuerySpeechModelPushDeviceJob.Code");
			querySpeechModelPushDeviceJobResponse.ErrorMessage = _ctx.StringValue("QuerySpeechModelPushDeviceJob.ErrorMessage");

			QuerySpeechModelPushDeviceJobResponse.QuerySpeechModelPushDeviceJob_Data data = new QuerySpeechModelPushDeviceJobResponse.QuerySpeechModelPushDeviceJob_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechModelPushDeviceJob.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechModelPushDeviceJob.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechModelPushDeviceJob.Data.PageSize");

			List<QuerySpeechModelPushDeviceJobResponse.QuerySpeechModelPushDeviceJob_Data.QuerySpeechModelPushDeviceJob_Items> data_list = new List<QuerySpeechModelPushDeviceJobResponse.QuerySpeechModelPushDeviceJob_Data.QuerySpeechModelPushDeviceJob_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechModelPushDeviceJob.Data.List.Length"); i++) {
				QuerySpeechModelPushDeviceJobResponse.QuerySpeechModelPushDeviceJob_Data.QuerySpeechModelPushDeviceJob_Items items = new QuerySpeechModelPushDeviceJobResponse.QuerySpeechModelPushDeviceJob_Data.QuerySpeechModelPushDeviceJob_Items();
				items.GmtModified = _ctx.LongValue("QuerySpeechModelPushDeviceJob.Data.List["+ i +"].GmtModified");
				items.Status = _ctx.StringValue("QuerySpeechModelPushDeviceJob.Data.List["+ i +"].Status");
				items.DeviceName = _ctx.StringValue("QuerySpeechModelPushDeviceJob.Data.List["+ i +"].DeviceName");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechModelPushDeviceJobResponse.Data = data;
        
			return querySpeechModelPushDeviceJobResponse;
        }
    }
}
