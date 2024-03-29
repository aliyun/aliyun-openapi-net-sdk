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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class QueryRealTimeProcessStatusResponseUnmarshaller
    {
        public static QueryRealTimeProcessStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRealTimeProcessStatusResponse queryRealTimeProcessStatusResponse = new QueryRealTimeProcessStatusResponse();

			queryRealTimeProcessStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryRealTimeProcessStatusResponse.RequestId = _ctx.StringValue("QueryRealTimeProcessStatus.RequestId");
			queryRealTimeProcessStatusResponse.Message = _ctx.StringValue("QueryRealTimeProcessStatus.Message");
			queryRealTimeProcessStatusResponse.Code = _ctx.IntegerValue("QueryRealTimeProcessStatus.Code");

			QueryRealTimeProcessStatusResponse.QueryRealTimeProcessStatus_Data data = new QueryRealTimeProcessStatusResponse.QueryRealTimeProcessStatus_Data();
			data.Status = _ctx.StringValue("QueryRealTimeProcessStatus.Data.Status");
			data.TaskId = _ctx.StringValue("QueryRealTimeProcessStatus.Data.TaskId");
			data.TaskUrl = _ctx.StringValue("QueryRealTimeProcessStatus.Data.TaskUrl");
			data.Message = _ctx.StringValue("QueryRealTimeProcessStatus.Data.Message");
			data.ProjectId = _ctx.LongValue("QueryRealTimeProcessStatus.Data.ProjectId");
			data.FileId = _ctx.LongValue("QueryRealTimeProcessStatus.Data.FileId");
			queryRealTimeProcessStatusResponse.Data = data;
        
			return queryRealTimeProcessStatusResponse;
        }
    }
}
