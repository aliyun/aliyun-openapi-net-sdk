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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryUserOmsDataResponseUnmarshaller
    {
        public static QueryUserOmsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserOmsDataResponse queryUserOmsDataResponse = new QueryUserOmsDataResponse();

			queryUserOmsDataResponse.HttpResponse = _ctx.HttpResponse;
			queryUserOmsDataResponse.RequestId = _ctx.StringValue("QueryUserOmsData.RequestId");
			queryUserOmsDataResponse.Success = _ctx.BooleanValue("QueryUserOmsData.Success");
			queryUserOmsDataResponse.Code = _ctx.StringValue("QueryUserOmsData.Code");
			queryUserOmsDataResponse.Message = _ctx.StringValue("QueryUserOmsData.Message");

			QueryUserOmsDataResponse.QueryUserOmsData_Data data = new QueryUserOmsDataResponse.QueryUserOmsData_Data();
			data.Marker = _ctx.StringValue("QueryUserOmsData.Data.Marker");
			data.HostId = _ctx.StringValue("QueryUserOmsData.Data.HostId");

			List<Dictionary<string, string>> data_omsData = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("QueryUserOmsData.Data.OmsData.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "QueryUserOmsData.Data.OmsData["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_omsData.Add(tmp);
				}
			}
			data.OmsData = data_omsData;
			queryUserOmsDataResponse.Data = data;
        
			return queryUserOmsDataResponse;
        }
    }
}
