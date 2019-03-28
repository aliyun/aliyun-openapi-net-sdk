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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetPornBatchDetectJobResponseUnmarshaller
    {
        public static GetPornBatchDetectJobResponse Unmarshall(UnmarshallerContext context)
        {
			GetPornBatchDetectJobResponse getPornBatchDetectJobResponse = new GetPornBatchDetectJobResponse();

			getPornBatchDetectJobResponse.HttpResponse = context.HttpResponse;
			getPornBatchDetectJobResponse.RequestId = context.StringValue("GetPornBatchDetectJob.RequestId");
			getPornBatchDetectJobResponse.JobId = context.StringValue("GetPornBatchDetectJob.JobId");
			getPornBatchDetectJobResponse.SrcUri = context.StringValue("GetPornBatchDetectJob.SrcUri");
			getPornBatchDetectJobResponse.TgtUri = context.StringValue("GetPornBatchDetectJob.TgtUri");
			getPornBatchDetectJobResponse.NotifyTopicName = context.StringValue("GetPornBatchDetectJob.NotifyTopicName");
			getPornBatchDetectJobResponse.NotifyEndpoint = context.StringValue("GetPornBatchDetectJob.NotifyEndpoint");
			getPornBatchDetectJobResponse.ExternalID = context.StringValue("GetPornBatchDetectJob.ExternalID");
			getPornBatchDetectJobResponse.Status = context.StringValue("GetPornBatchDetectJob.Status");
			getPornBatchDetectJobResponse.CreateTime = context.StringValue("GetPornBatchDetectJob.CreateTime");
			getPornBatchDetectJobResponse.FinishTime = context.StringValue("GetPornBatchDetectJob.FinishTime");
			getPornBatchDetectJobResponse.Percent = context.IntegerValue("GetPornBatchDetectJob.Percent");
        
			return getPornBatchDetectJobResponse;
        }
    }
}
