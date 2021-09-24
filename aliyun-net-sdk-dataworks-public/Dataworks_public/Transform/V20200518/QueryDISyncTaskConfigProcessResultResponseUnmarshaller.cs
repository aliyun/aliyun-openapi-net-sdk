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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class QueryDISyncTaskConfigProcessResultResponseUnmarshaller
    {
        public static QueryDISyncTaskConfigProcessResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDISyncTaskConfigProcessResultResponse queryDISyncTaskConfigProcessResultResponse = new QueryDISyncTaskConfigProcessResultResponse();

			queryDISyncTaskConfigProcessResultResponse.HttpResponse = _ctx.HttpResponse;
			queryDISyncTaskConfigProcessResultResponse.RequestId = _ctx.StringValue("QueryDISyncTaskConfigProcessResult.RequestId");
			queryDISyncTaskConfigProcessResultResponse.Success = _ctx.BooleanValue("QueryDISyncTaskConfigProcessResult.Success");

			QueryDISyncTaskConfigProcessResultResponse.QueryDISyncTaskConfigProcessResult_Data data = new QueryDISyncTaskConfigProcessResultResponse.QueryDISyncTaskConfigProcessResult_Data();
			data.Status = _ctx.StringValue("QueryDISyncTaskConfigProcessResult.Data.Status");
			data.Message = _ctx.StringValue("QueryDISyncTaskConfigProcessResult.Data.Message");
			data.TaskContent = _ctx.StringValue("QueryDISyncTaskConfigProcessResult.Data.TaskContent");
			queryDISyncTaskConfigProcessResultResponse.Data = data;
        
			return queryDISyncTaskConfigProcessResultResponse;
        }
    }
}
