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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class BatchStopStreamsResponseUnmarshaller
    {
        public static BatchStopStreamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchStopStreamsResponse batchStopStreamsResponse = new BatchStopStreamsResponse();

			batchStopStreamsResponse.HttpResponse = _ctx.HttpResponse;
			batchStopStreamsResponse.RequestId = _ctx.StringValue("BatchStopStreams.RequestId");

			List<BatchStopStreamsResponse.BatchStopStreams_Result> batchStopStreamsResponse_results = new List<BatchStopStreamsResponse.BatchStopStreams_Result>();
			for (int i = 0; i < _ctx.Length("BatchStopStreams.Results.Length"); i++) {
				BatchStopStreamsResponse.BatchStopStreams_Result result = new BatchStopStreamsResponse.BatchStopStreams_Result();
				result.Id = _ctx.StringValue("BatchStopStreams.Results["+ i +"].Id");
				result.Name = _ctx.StringValue("BatchStopStreams.Results["+ i +"].Name");
				result.Error = _ctx.StringValue("BatchStopStreams.Results["+ i +"].Error");

				batchStopStreamsResponse_results.Add(result);
			}
			batchStopStreamsResponse.Results = batchStopStreamsResponse_results;
        
			return batchStopStreamsResponse;
        }
    }
}
