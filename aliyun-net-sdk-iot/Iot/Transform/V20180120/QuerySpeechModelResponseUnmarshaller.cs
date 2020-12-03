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
    public class QuerySpeechModelResponseUnmarshaller
    {
        public static QuerySpeechModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechModelResponse querySpeechModelResponse = new QuerySpeechModelResponse();

			querySpeechModelResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechModelResponse.RequestId = _ctx.StringValue("QuerySpeechModel.RequestId");
			querySpeechModelResponse.Success = _ctx.BooleanValue("QuerySpeechModel.Success");
			querySpeechModelResponse.Code = _ctx.StringValue("QuerySpeechModel.Code");
			querySpeechModelResponse.ErrorMessage = _ctx.StringValue("QuerySpeechModel.ErrorMessage");

			QuerySpeechModelResponse.QuerySpeechModel_Data data = new QuerySpeechModelResponse.QuerySpeechModel_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechModel.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechModel.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechModel.Data.PageSize");

			List<QuerySpeechModelResponse.QuerySpeechModel_Data.QuerySpeechModel_Items> data_list = new List<QuerySpeechModelResponse.QuerySpeechModel_Data.QuerySpeechModel_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechModel.Data.List.Length"); i++) {
				QuerySpeechModelResponse.QuerySpeechModel_Data.QuerySpeechModel_Items items = new QuerySpeechModelResponse.QuerySpeechModel_Data.QuerySpeechModel_Items();
				items.Code = _ctx.StringValue("QuerySpeechModel.Data.List["+ i +"].Code");
				items.BizCode = _ctx.StringValue("QuerySpeechModel.Data.List["+ i +"].BizCode");
				items.Text = _ctx.StringValue("QuerySpeechModel.Data.List["+ i +"].Text");
				items.Voice = _ctx.StringValue("QuerySpeechModel.Data.List["+ i +"].Voice");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechModelResponse.Data = data;
        
			return querySpeechModelResponse;
        }
    }
}
