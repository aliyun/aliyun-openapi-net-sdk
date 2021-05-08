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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryUnionTaskListResponseUnmarshaller
    {
        public static QueryUnionTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUnionTaskListResponse queryUnionTaskListResponse = new QueryUnionTaskListResponse();

			queryUnionTaskListResponse.HttpResponse = _ctx.HttpResponse;
			queryUnionTaskListResponse.Code = _ctx.IntegerValue("QueryUnionTaskList.Code");
			queryUnionTaskListResponse.Success = _ctx.BooleanValue("QueryUnionTaskList.Success");
			queryUnionTaskListResponse.ErrorMsg = _ctx.StringValue("QueryUnionTaskList.ErrorMsg");
			queryUnionTaskListResponse.RequestId = _ctx.StringValue("QueryUnionTaskList.RequestId");
			queryUnionTaskListResponse.Data = _ctx.StringValue("QueryUnionTaskList.Data");
        
			return queryUnionTaskListResponse;
        }
    }
}
