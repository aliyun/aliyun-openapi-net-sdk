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
    public class BatchStartStreamsResponseUnmarshaller
    {
        public static BatchStartStreamsResponse Unmarshall(UnmarshallerContext context)
        {
			BatchStartStreamsResponse batchStartStreamsResponse = new BatchStartStreamsResponse();

			batchStartStreamsResponse.HttpResponse = context.HttpResponse;
			batchStartStreamsResponse.RequestId = context.StringValue("BatchStartStreams.RequestId");

			List<BatchStartStreamsResponse.BatchStartStreams_Result> batchStartStreamsResponse_results = new List<BatchStartStreamsResponse.BatchStartStreams_Result>();
			for (int i = 0; i < context.Length("BatchStartStreams.Results.Length"); i++) {
				BatchStartStreamsResponse.BatchStartStreams_Result result = new BatchStartStreamsResponse.BatchStartStreams_Result();
				result.Id = context.StringValue("BatchStartStreams.Results["+ i +"].Id");
				result.Name = context.StringValue("BatchStartStreams.Results["+ i +"].Name");
				result.Error = context.StringValue("BatchStartStreams.Results["+ i +"].Error");

				batchStartStreamsResponse_results.Add(result);
			}
			batchStartStreamsResponse.Results = batchStartStreamsResponse_results;
        
			return batchStartStreamsResponse;
        }
    }
}
