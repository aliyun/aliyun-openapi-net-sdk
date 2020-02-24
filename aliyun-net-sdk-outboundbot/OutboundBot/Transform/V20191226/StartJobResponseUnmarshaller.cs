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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class StartJobResponseUnmarshaller
    {
        public static StartJobResponse Unmarshall(UnmarshallerContext context)
        {
			StartJobResponse startJobResponse = new StartJobResponse();

			startJobResponse.HttpResponse = context.HttpResponse;
			startJobResponse.RequestId = context.StringValue("StartJob.RequestId");
			startJobResponse.Success = context.BooleanValue("StartJob.Success");
			startJobResponse.Code = context.StringValue("StartJob.Code");
			startJobResponse.Message = context.StringValue("StartJob.Message");
			startJobResponse.HttpStatusCode = context.IntegerValue("StartJob.HttpStatusCode");

			List<StartJobResponse.StartJob_KeyValuePair> startJobResponse_taskIds = new List<StartJobResponse.StartJob_KeyValuePair>();
			for (int i = 0; i < context.Length("StartJob.TaskIds.Length"); i++) {
				StartJobResponse.StartJob_KeyValuePair keyValuePair = new StartJobResponse.StartJob_KeyValuePair();
				keyValuePair.Key = context.StringValue("StartJob.TaskIds["+ i +"].Key");
				keyValuePair._Value = context.StringValue("StartJob.TaskIds["+ i +"].Value");

				startJobResponse_taskIds.Add(keyValuePair);
			}
			startJobResponse.TaskIds = startJobResponse_taskIds;
        
			return startJobResponse;
        }
    }
}
