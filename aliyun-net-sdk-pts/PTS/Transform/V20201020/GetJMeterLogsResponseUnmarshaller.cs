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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class GetJMeterLogsResponseUnmarshaller
    {
        public static GetJMeterLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJMeterLogsResponse getJMeterLogsResponse = new GetJMeterLogsResponse();

			getJMeterLogsResponse.HttpResponse = _ctx.HttpResponse;
			getJMeterLogsResponse.TotalCount = _ctx.LongValue("GetJMeterLogs.TotalCount");
			getJMeterLogsResponse.RequestId = _ctx.StringValue("GetJMeterLogs.RequestId");
			getJMeterLogsResponse.Message = _ctx.StringValue("GetJMeterLogs.Message");
			getJMeterLogsResponse.PageSize = _ctx.IntegerValue("GetJMeterLogs.PageSize");
			getJMeterLogsResponse.PageNumber = _ctx.IntegerValue("GetJMeterLogs.PageNumber");
			getJMeterLogsResponse.Code = _ctx.StringValue("GetJMeterLogs.Code");
			getJMeterLogsResponse.Success = _ctx.BooleanValue("GetJMeterLogs.Success");
			getJMeterLogsResponse.AgentCount = _ctx.IntegerValue("GetJMeterLogs.AgentCount");

			List<Dictionary<string, string>> getJMeterLogsResponse_logs = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetJMeterLogs.Logs.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetJMeterLogs.Logs["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getJMeterLogsResponse_logs.Add(tmp);
				}
			}
			getJMeterLogsResponse.Logs = getJMeterLogsResponse_logs;
        
			return getJMeterLogsResponse;
        }
    }
}
