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
    public class GetDDLJobStatusResponseUnmarshaller
    {
        public static GetDDLJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDDLJobStatusResponse getDDLJobStatusResponse = new GetDDLJobStatusResponse();

			getDDLJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			getDDLJobStatusResponse.RequestId = _ctx.StringValue("GetDDLJobStatus.RequestId");

			GetDDLJobStatusResponse.GetDDLJobStatus_Data data = new GetDDLJobStatusResponse.GetDDLJobStatus_Data();
			data.Status = _ctx.StringValue("GetDDLJobStatus.Data.Status");
			data.NextTaskId = _ctx.StringValue("GetDDLJobStatus.Data.NextTaskId");
			data.TaskId = _ctx.StringValue("GetDDLJobStatus.Data.TaskId");
			data.Content = _ctx.StringValue("GetDDLJobStatus.Data.Content");
			getDDLJobStatusResponse.Data = data;
        
			return getDDLJobStatusResponse;
        }
    }
}
