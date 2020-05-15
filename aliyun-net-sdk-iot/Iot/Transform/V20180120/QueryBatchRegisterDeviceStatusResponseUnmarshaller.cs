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
    public class QueryBatchRegisterDeviceStatusResponseUnmarshaller
    {
        public static QueryBatchRegisterDeviceStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBatchRegisterDeviceStatusResponse queryBatchRegisterDeviceStatusResponse = new QueryBatchRegisterDeviceStatusResponse();

			queryBatchRegisterDeviceStatusResponse.HttpResponse = context.HttpResponse;
			queryBatchRegisterDeviceStatusResponse.RequestId = context.StringValue("QueryBatchRegisterDeviceStatus.RequestId");
			queryBatchRegisterDeviceStatusResponse.Success = context.BooleanValue("QueryBatchRegisterDeviceStatus.Success");
			queryBatchRegisterDeviceStatusResponse.Code = context.StringValue("QueryBatchRegisterDeviceStatus.Code");
			queryBatchRegisterDeviceStatusResponse.ErrorMessage = context.StringValue("QueryBatchRegisterDeviceStatus.ErrorMessage");

			QueryBatchRegisterDeviceStatusResponse.QueryBatchRegisterDeviceStatus_Data data = new QueryBatchRegisterDeviceStatusResponse.QueryBatchRegisterDeviceStatus_Data();
			data.Status = context.StringValue("QueryBatchRegisterDeviceStatus.Data.Status");

			List<Dictionary<string, string>> data_validList = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("QueryBatchRegisterDeviceStatus.Data.ValidList.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "QueryBatchRegisterDeviceStatus.Data.ValidList["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_validList.Add(tmp);
				}
			}
			data.ValidList = data_validList;

			List<Dictionary<string, string>> data_invalidList = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("QueryBatchRegisterDeviceStatus.Data.InvalidList.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "QueryBatchRegisterDeviceStatus.Data.InvalidList["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_invalidList.Add(tmp);
				}
			}
			data.InvalidList = data_invalidList;
			queryBatchRegisterDeviceStatusResponse.Data = data;
        
			return queryBatchRegisterDeviceStatusResponse;
        }
    }
}
