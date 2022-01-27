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
    public class QueryDeviceSpeechResponseUnmarshaller
    {
        public static QueryDeviceSpeechResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceSpeechResponse queryDeviceSpeechResponse = new QueryDeviceSpeechResponse();

			queryDeviceSpeechResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceSpeechResponse.RequestId = _ctx.StringValue("QueryDeviceSpeech.RequestId");
			queryDeviceSpeechResponse.Success = _ctx.BooleanValue("QueryDeviceSpeech.Success");
			queryDeviceSpeechResponse.Code = _ctx.StringValue("QueryDeviceSpeech.Code");
			queryDeviceSpeechResponse.ErrorMessage = _ctx.StringValue("QueryDeviceSpeech.ErrorMessage");

			QueryDeviceSpeechResponse.QueryDeviceSpeech_Data data = new QueryDeviceSpeechResponse.QueryDeviceSpeech_Data();
			data.Total = _ctx.IntegerValue("QueryDeviceSpeech.Data.Total");
			data.PageId = _ctx.IntegerValue("QueryDeviceSpeech.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QueryDeviceSpeech.Data.PageSize");

			List<QueryDeviceSpeechResponse.QueryDeviceSpeech_Data.QueryDeviceSpeech_Items> data_list = new List<QueryDeviceSpeechResponse.QueryDeviceSpeech_Data.QueryDeviceSpeech_Items>();
			for (int i = 0; i < _ctx.Length("QueryDeviceSpeech.Data.List.Length"); i++) {
				QueryDeviceSpeechResponse.QueryDeviceSpeech_Data.QueryDeviceSpeech_Items items = new QueryDeviceSpeechResponse.QueryDeviceSpeech_Data.QueryDeviceSpeech_Items();
				items.BizCode = _ctx.StringValue("QueryDeviceSpeech.Data.List["+ i +"].BizCode");
				items.Size = _ctx.FloatValue("QueryDeviceSpeech.Data.List["+ i +"].Size");
				items.AudioFormat = _ctx.StringValue("QueryDeviceSpeech.Data.List["+ i +"].AudioFormat");

				data_list.Add(items);
			}
			data.List = data_list;
			queryDeviceSpeechResponse.Data = data;
        
			return queryDeviceSpeechResponse;
        }
    }
}
