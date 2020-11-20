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
    public class BatchStopApplicationsResponseUnmarshaller
    {
        public static BatchStopApplicationsResponse Unmarshall(UnmarshallerContext context)
        {
			BatchStopApplicationsResponse batchStopApplicationsResponse = new BatchStopApplicationsResponse();

			batchStopApplicationsResponse.HttpResponse = context.HttpResponse;
			batchStopApplicationsResponse.RequestId = context.StringValue("BatchStopApplications.RequestId");
			batchStopApplicationsResponse.Code = context.StringValue("BatchStopApplications.Code");
			batchStopApplicationsResponse.Message = context.StringValue("BatchStopApplications.Message");
			batchStopApplicationsResponse.ErrorCode = context.StringValue("BatchStopApplications.ErrorCode");
			batchStopApplicationsResponse.TraceId = context.StringValue("BatchStopApplications.TraceId");
			batchStopApplicationsResponse.Success = context.BooleanValue("BatchStopApplications.Success");

			BatchStopApplicationsResponse.BatchStopApplications_Data data = new BatchStopApplicationsResponse.BatchStopApplications_Data();
			data.ChangeOrderId = context.StringValue("BatchStopApplications.Data.ChangeOrderId");
			batchStopApplicationsResponse.Data = data;
        
			return batchStopApplicationsResponse;
        }
    }
}
