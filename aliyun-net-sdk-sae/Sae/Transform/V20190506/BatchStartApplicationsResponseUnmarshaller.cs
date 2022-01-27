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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class BatchStartApplicationsResponseUnmarshaller
    {
        public static BatchStartApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchStartApplicationsResponse batchStartApplicationsResponse = new BatchStartApplicationsResponse();

			batchStartApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			batchStartApplicationsResponse.RequestId = _ctx.StringValue("BatchStartApplications.RequestId");
			batchStartApplicationsResponse.Code = _ctx.StringValue("BatchStartApplications.Code");
			batchStartApplicationsResponse.Message = _ctx.StringValue("BatchStartApplications.Message");
			batchStartApplicationsResponse.ErrorCode = _ctx.StringValue("BatchStartApplications.ErrorCode");
			batchStartApplicationsResponse.TraceId = _ctx.StringValue("BatchStartApplications.TraceId");
			batchStartApplicationsResponse.Success = _ctx.BooleanValue("BatchStartApplications.Success");

			BatchStartApplicationsResponse.BatchStartApplications_Data data = new BatchStartApplicationsResponse.BatchStartApplications_Data();
			data.ChangeOrderId = _ctx.StringValue("BatchStartApplications.Data.ChangeOrderId");
			batchStartApplicationsResponse.Data = data;
        
			return batchStartApplicationsResponse;
        }
    }
}
