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
    public class GetInstanceStatusCountResponseUnmarshaller
    {
        public static GetInstanceStatusCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceStatusCountResponse getInstanceStatusCountResponse = new GetInstanceStatusCountResponse();

			getInstanceStatusCountResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceStatusCountResponse.RequestId = _ctx.StringValue("GetInstanceStatusCount.RequestId");

			GetInstanceStatusCountResponse.GetInstanceStatusCount_StatusCount statusCount = new GetInstanceStatusCountResponse.GetInstanceStatusCount_StatusCount();
			statusCount.TotalCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.TotalCount");
			statusCount.NotRunCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.NotRunCount");
			statusCount.WaitTimeCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.WaitTimeCount");
			statusCount.WaitResCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.WaitResCount");
			statusCount.RunningCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.RunningCount");
			statusCount.FailureCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.FailureCount");
			statusCount.SuccessCount = _ctx.IntegerValue("GetInstanceStatusCount.StatusCount.SuccessCount");
			getInstanceStatusCountResponse.StatusCount = statusCount;
        
			return getInstanceStatusCountResponse;
        }
    }
}
