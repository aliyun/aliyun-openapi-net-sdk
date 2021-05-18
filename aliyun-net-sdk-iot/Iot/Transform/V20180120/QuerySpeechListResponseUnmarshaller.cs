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
    public class QuerySpeechListResponseUnmarshaller
    {
        public static QuerySpeechListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechListResponse querySpeechListResponse = new QuerySpeechListResponse();

			querySpeechListResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechListResponse.RequestId = _ctx.StringValue("QuerySpeechList.RequestId");
			querySpeechListResponse.Success = _ctx.BooleanValue("QuerySpeechList.Success");
			querySpeechListResponse.Code = _ctx.StringValue("QuerySpeechList.Code");
			querySpeechListResponse.ErrorMessage = _ctx.StringValue("QuerySpeechList.ErrorMessage");

			QuerySpeechListResponse.QuerySpeechList_Data data = new QuerySpeechListResponse.QuerySpeechList_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechList.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechList.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechList.Data.PageSize");

			List<QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items> data_list = new List<QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechList.Data.List.Length"); i++) {
				QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items items = new QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items();
				items.SpeechCode = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].SpeechCode");
				items.BizCode = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].BizCode");
				items.Text = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].Text");
				items.Voice = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].Voice");
				items.SpeechType = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].SpeechType");

				List<QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items.QuerySpeechList_Items1> items_speechList = new List<QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items.QuerySpeechList_Items1>();
				for (int j = 0; j < _ctx.Length("QuerySpeechList.Data.List["+ i +"].SpeechList.Length"); j++) {
					QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items.QuerySpeechList_Items1 items1 = new QuerySpeechListResponse.QuerySpeechList_Data.QuerySpeechList_Items.QuerySpeechList_Items1();
					items1.SpeechCode = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].SpeechList["+ j +"].SpeechCode");
					items1.BizCode = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].SpeechList["+ j +"].BizCode");
					items1.Text = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].SpeechList["+ j +"].Text");
					items1.Voice = _ctx.StringValue("QuerySpeechList.Data.List["+ i +"].SpeechList["+ j +"].Voice");

					items_speechList.Add(items1);
				}
				items.SpeechList = items_speechList;

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechListResponse.Data = data;
        
			return querySpeechListResponse;
        }
    }
}
