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
    public class QuerySpeechPushJobSpeechResponseUnmarshaller
    {
        public static QuerySpeechPushJobSpeechResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechPushJobSpeechResponse querySpeechPushJobSpeechResponse = new QuerySpeechPushJobSpeechResponse();

			querySpeechPushJobSpeechResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechPushJobSpeechResponse.RequestId = _ctx.StringValue("QuerySpeechPushJobSpeech.RequestId");
			querySpeechPushJobSpeechResponse.Success = _ctx.BooleanValue("QuerySpeechPushJobSpeech.Success");
			querySpeechPushJobSpeechResponse.Code = _ctx.StringValue("QuerySpeechPushJobSpeech.Code");
			querySpeechPushJobSpeechResponse.ErrorMessage = _ctx.StringValue("QuerySpeechPushJobSpeech.ErrorMessage");

			QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data data = new QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechPushJobSpeech.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechPushJobSpeech.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechPushJobSpeech.Data.PageSize");

			List<QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items> data_list = new List<QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechPushJobSpeech.Data.List.Length"); i++) {
				QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items items = new QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items();
				items.BizCode = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].BizCode");
				items.Text = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].Text");
				items.Voice = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].Voice");
				items.SpeechType = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].SpeechType");

				List<QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items.QuerySpeechPushJobSpeech_Items1> items_speechList = new List<QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items.QuerySpeechPushJobSpeech_Items1>();
				for (int j = 0; j < _ctx.Length("QuerySpeechPushJobSpeech.Data.List["+ i +"].SpeechList.Length"); j++) {
					QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items.QuerySpeechPushJobSpeech_Items1 items1 = new QuerySpeechPushJobSpeechResponse.QuerySpeechPushJobSpeech_Data.QuerySpeechPushJobSpeech_Items.QuerySpeechPushJobSpeech_Items1();
					items1.BizCode = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].SpeechList["+ j +"].BizCode");
					items1.Text = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].SpeechList["+ j +"].Text");
					items1.Voice = _ctx.StringValue("QuerySpeechPushJobSpeech.Data.List["+ i +"].SpeechList["+ j +"].Voice");

					items_speechList.Add(items1);
				}
				items.SpeechList = items_speechList;

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechPushJobSpeechResponse.Data = data;
        
			return querySpeechPushJobSpeechResponse;
        }
    }
}
