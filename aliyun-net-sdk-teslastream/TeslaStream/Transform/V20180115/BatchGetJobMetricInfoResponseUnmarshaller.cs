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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.TeslaStream.Model.V20180115;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaStream.Transform.V20180115
{
    public class BatchGetJobMetricInfoResponseUnmarshaller
    {
        public static BatchGetJobMetricInfoResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetJobMetricInfoResponse batchGetJobMetricInfoResponse = new BatchGetJobMetricInfoResponse();

			batchGetJobMetricInfoResponse.HttpResponse = context.HttpResponse;
			batchGetJobMetricInfoResponse.Code = context.IntegerValue("BatchGetJobMetricInfo.Code");
			batchGetJobMetricInfoResponse.Message = context.StringValue("BatchGetJobMetricInfo.Message");
			batchGetJobMetricInfoResponse.RequestId = context.StringValue("BatchGetJobMetricInfo.RequestId");

			List<BatchGetJobMetricInfoResponse.BatchGetJobMetricInfo_Job> batchGetJobMetricInfoResponse_data = new List<BatchGetJobMetricInfoResponse.BatchGetJobMetricInfo_Job>();
			for (int i = 0; i < context.Length("BatchGetJobMetricInfo.Data.Length"); i++) {
				BatchGetJobMetricInfoResponse.BatchGetJobMetricInfo_Job job = new BatchGetJobMetricInfoResponse.BatchGetJobMetricInfo_Job();
				job.Delay = context.IntegerValue("BatchGetJobMetricInfo.Data["+ i +"].Delay");
				job.TpsOut = context.IntegerValue("BatchGetJobMetricInfo.Data["+ i +"].TpsOut");
				job.MemRequest = context.IntegerValue("BatchGetJobMetricInfo.Data["+ i +"].MemRequest");
				job.JobUniqKey = context.StringValue("BatchGetJobMetricInfo.Data["+ i +"].JobUniqKey");
				job.MemUsed = context.FloatValue("BatchGetJobMetricInfo.Data["+ i +"].MemUsed");
				job.CpuUsed = context.FloatValue("BatchGetJobMetricInfo.Data["+ i +"].CpuUsed");
				job.CpuRequest = context.IntegerValue("BatchGetJobMetricInfo.Data["+ i +"].CpuRequest");
				job.Nickname = context.StringValue("BatchGetJobMetricInfo.Data["+ i +"].Nickname");
				job.TpsIn = context.IntegerValue("BatchGetJobMetricInfo.Data["+ i +"].TpsIn");
				job.Priority = context.StringValue("BatchGetJobMetricInfo.Data["+ i +"].Priority");

				batchGetJobMetricInfoResponse_data.Add(job);
			}
			batchGetJobMetricInfoResponse.Data = batchGetJobMetricInfoResponse_data;
        
			return batchGetJobMetricInfoResponse;
        }
    }
}