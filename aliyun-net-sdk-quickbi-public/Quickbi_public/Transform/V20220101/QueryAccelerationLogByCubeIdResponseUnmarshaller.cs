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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryAccelerationLogByCubeIdResponseUnmarshaller
    {
        public static QueryAccelerationLogByCubeIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAccelerationLogByCubeIdResponse queryAccelerationLogByCubeIdResponse = new QueryAccelerationLogByCubeIdResponse();

			queryAccelerationLogByCubeIdResponse.HttpResponse = _ctx.HttpResponse;
			queryAccelerationLogByCubeIdResponse.RequestId = _ctx.StringValue("QueryAccelerationLogByCubeId.RequestId");
			queryAccelerationLogByCubeIdResponse.Success = _ctx.BooleanValue("QueryAccelerationLogByCubeId.Success");

			QueryAccelerationLogByCubeIdResponse.QueryAccelerationLogByCubeId_Result result = new QueryAccelerationLogByCubeIdResponse.QueryAccelerationLogByCubeId_Result();
			result.TotalPages = _ctx.IntegerValue("QueryAccelerationLogByCubeId.Result.TotalPages");
			result.TotalNum = _ctx.IntegerValue("QueryAccelerationLogByCubeId.Result.TotalNum");
			result.PageNum = _ctx.IntegerValue("QueryAccelerationLogByCubeId.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryAccelerationLogByCubeId.Result.PageSize");
			result.Pre = _ctx.IntegerValue("QueryAccelerationLogByCubeId.Result.Pre");
			result.Next = _ctx.IntegerValue("QueryAccelerationLogByCubeId.Result.Next");

			List<QueryAccelerationLogByCubeIdResponse.QueryAccelerationLogByCubeId_Result.QueryAccelerationLogByCubeId_DataItem> result_data = new List<QueryAccelerationLogByCubeIdResponse.QueryAccelerationLogByCubeId_Result.QueryAccelerationLogByCubeId_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryAccelerationLogByCubeId.Result.Data.Length"); i++) {
				QueryAccelerationLogByCubeIdResponse.QueryAccelerationLogByCubeId_Result.QueryAccelerationLogByCubeId_DataItem dataItem = new QueryAccelerationLogByCubeIdResponse.QueryAccelerationLogByCubeId_Result.QueryAccelerationLogByCubeId_DataItem();
				dataItem.JobId = _ctx.StringValue("QueryAccelerationLogByCubeId.Result.Data["+ i +"].JobId");
				dataItem.JobHistoryId = _ctx.StringValue("QueryAccelerationLogByCubeId.Result.Data["+ i +"].JobHistoryId");
				dataItem.JonStartDate = _ctx.StringValue("QueryAccelerationLogByCubeId.Result.Data["+ i +"].JonStartDate");
				dataItem.JobStatus = _ctx.StringValue("QueryAccelerationLogByCubeId.Result.Data["+ i +"].JobStatus");
				dataItem.Duration = _ctx.StringValue("QueryAccelerationLogByCubeId.Result.Data["+ i +"].Duration");
				dataItem.Log = _ctx.StringValue("QueryAccelerationLogByCubeId.Result.Data["+ i +"].Log");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryAccelerationLogByCubeIdResponse.Result = result;
        
			return queryAccelerationLogByCubeIdResponse;
        }
    }
}
