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
    public class InvokeDataAPIServiceResponseUnmarshaller
    {
        public static InvokeDataAPIServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InvokeDataAPIServiceResponse invokeDataAPIServiceResponse = new InvokeDataAPIServiceResponse();

			invokeDataAPIServiceResponse.HttpResponse = _ctx.HttpResponse;
			invokeDataAPIServiceResponse.RequestId = _ctx.StringValue("InvokeDataAPIService.RequestId");
			invokeDataAPIServiceResponse.Success = _ctx.BooleanValue("InvokeDataAPIService.Success");
			invokeDataAPIServiceResponse.Code = _ctx.StringValue("InvokeDataAPIService.Code");
			invokeDataAPIServiceResponse.ErrorMessage = _ctx.StringValue("InvokeDataAPIService.ErrorMessage");

			InvokeDataAPIServiceResponse.InvokeDataAPIService_Data data = new InvokeDataAPIServiceResponse.InvokeDataAPIService_Data();
			data.PageNo = _ctx.IntegerValue("InvokeDataAPIService.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("InvokeDataAPIService.Data.PageSize");
			data.ApiSrn = _ctx.StringValue("InvokeDataAPIService.Data.ApiSrn");

			List<string> data_fieldNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("InvokeDataAPIService.Data.FieldNameList.Length"); i++) {
				data_fieldNameList.Add(_ctx.StringValue("InvokeDataAPIService.Data.FieldNameList["+ i +"]"));
			}
			data.FieldNameList = data_fieldNameList;

			List<Dictionary<string, string>> data_resultList = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("InvokeDataAPIService.Data.ResultList.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "InvokeDataAPIService.Data.ResultList["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_resultList.Add(tmp);
				}
			}
			data.ResultList = data_resultList;
			invokeDataAPIServiceResponse.Data = data;
        
			return invokeDataAPIServiceResponse;
        }
    }
}
