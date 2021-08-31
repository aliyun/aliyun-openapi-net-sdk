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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class QueryServiceTimeConfigResponseUnmarshaller
    {
        public static QueryServiceTimeConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryServiceTimeConfigResponse queryServiceTimeConfigResponse = new QueryServiceTimeConfigResponse();

			queryServiceTimeConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryServiceTimeConfigResponse.Code = _ctx.IntegerValue("QueryServiceTimeConfig.Code");
			queryServiceTimeConfigResponse.Message = _ctx.StringValue("QueryServiceTimeConfig.Message");
			queryServiceTimeConfigResponse.Success = _ctx.BooleanValue("QueryServiceTimeConfig.Success");

			QueryServiceTimeConfigResponse.QueryServiceTimeConfig_Data data = new QueryServiceTimeConfigResponse.QueryServiceTimeConfig_Data();
			data.PageNumber = _ctx.IntegerValue("QueryServiceTimeConfig.Data.PageNumber");
			data.TotalSize = _ctx.IntegerValue("QueryServiceTimeConfig.Data.TotalSize");
			data.PageSize = _ctx.IntegerValue("QueryServiceTimeConfig.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryServiceTimeConfig.Data.CurrentPage");

			List<QueryServiceTimeConfigResponse.QueryServiceTimeConfig_Data.QueryServiceTimeConfig_MseServiceTime> data_result = new List<QueryServiceTimeConfigResponse.QueryServiceTimeConfig_Data.QueryServiceTimeConfig_MseServiceTime>();
			for (int i = 0; i < _ctx.Length("QueryServiceTimeConfig.Data.Result.Length"); i++) {
				QueryServiceTimeConfigResponse.QueryServiceTimeConfig_Data.QueryServiceTimeConfig_MseServiceTime mseServiceTime = new QueryServiceTimeConfigResponse.QueryServiceTimeConfig_Data.QueryServiceTimeConfig_MseServiceTime();
				mseServiceTime.Id = _ctx.LongValue("QueryServiceTimeConfig.Data.Result["+ i +"].Id");
				mseServiceTime.Path = _ctx.StringValue("QueryServiceTimeConfig.Data.Result["+ i +"].Path");
				mseServiceTime.ConsumerAppName = _ctx.StringValue("QueryServiceTimeConfig.Data.Result["+ i +"].ConsumerAppName");
				mseServiceTime.Timeout = _ctx.StringValue("QueryServiceTimeConfig.Data.Result["+ i +"].Timeout");
				mseServiceTime.ConsumerAppId = _ctx.StringValue("QueryServiceTimeConfig.Data.Result["+ i +"].ConsumerAppId");

				data_result.Add(mseServiceTime);
			}
			data.Result = data_result;
			queryServiceTimeConfigResponse.Data = data;
        
			return queryServiceTimeConfigResponse;
        }
    }
}
