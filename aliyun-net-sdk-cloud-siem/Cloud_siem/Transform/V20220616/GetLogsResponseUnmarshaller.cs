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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class GetLogsResponseUnmarshaller
    {
        public static GetLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLogsResponse getLogsResponse = new GetLogsResponse();

			getLogsResponse.HttpResponse = _ctx.HttpResponse;
			getLogsResponse.Success = _ctx.BooleanValue("GetLogs.Success");
			getLogsResponse.Code = _ctx.IntegerValue("GetLogs.Code");
			getLogsResponse.Message = _ctx.StringValue("GetLogs.Message");
			getLogsResponse.RequestId = _ctx.StringValue("GetLogs.RequestId");

			GetLogsResponse.GetLogs_Data data = new GetLogsResponse.GetLogs_Data();

			GetLogsResponse.GetLogs_Data.GetLogs_PageInfo pageInfo = new GetLogsResponse.GetLogs_Data.GetLogs_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("GetLogs.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("GetLogs.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("GetLogs.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			GetLogsResponse.GetLogs_Data.GetLogs_ResponseData responseData = new GetLogsResponse.GetLogs_Data.GetLogs_ResponseData();
			responseData.CompleteOrNot = _ctx.BooleanValue("GetLogs.Data.ResponseData.CompleteOrNot");
			responseData.Count = _ctx.IntegerValue("GetLogs.Data.ResponseData.Count");
			responseData.Cost = _ctx.LongValue("GetLogs.Data.ResponseData.Cost");
			responseData.HasSql = _ctx.BooleanValue("GetLogs.Data.ResponseData.HasSql");

			List<string> responseData_keys = new List<string>();
			for (int i = 0; i < _ctx.Length("GetLogs.Data.ResponseData.Keys.Length"); i++) {
				responseData_keys.Add(_ctx.StringValue("GetLogs.Data.ResponseData.Keys["+ i +"]"));
			}
			responseData.Keys = responseData_keys;

			List<string> responseData_lines = new List<string>();
			for (int i = 0; i < _ctx.Length("GetLogs.Data.ResponseData.Lines.Length"); i++) {
				responseData_lines.Add(_ctx.StringValue("GetLogs.Data.ResponseData.Lines["+ i +"]"));
			}
			responseData.Lines = responseData_lines;
			data.ResponseData = responseData;
			getLogsResponse.Data = data;
        
			return getLogsResponse;
        }
    }
}
