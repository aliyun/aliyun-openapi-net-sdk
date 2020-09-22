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
    public class BatchStartDevicesResponseUnmarshaller
    {
        public static BatchStartDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchStartDevicesResponse batchStartDevicesResponse = new BatchStartDevicesResponse();

			batchStartDevicesResponse.HttpResponse = context.HttpResponse;
			batchStartDevicesResponse.RequestId = context.StringValue("BatchStartDevices.RequestId");

			List<BatchStartDevicesResponse.BatchStartDevices_Result> batchStartDevicesResponse_results = new List<BatchStartDevicesResponse.BatchStartDevices_Result>();
			for (int i = 0; i < context.Length("BatchStartDevices.Results.Length"); i++) {
				BatchStartDevicesResponse.BatchStartDevices_Result result = new BatchStartDevicesResponse.BatchStartDevices_Result();
				result.Id = context.StringValue("BatchStartDevices.Results["+ i +"].Id");

				List<BatchStartDevicesResponse.BatchStartDevices_Result.BatchStartDevices_Stream> result_streams = new List<BatchStartDevicesResponse.BatchStartDevices_Result.BatchStartDevices_Stream>();
				for (int j = 0; j < context.Length("BatchStartDevices.Results["+ i +"].Streams.Length"); j++) {
					BatchStartDevicesResponse.BatchStartDevices_Result.BatchStartDevices_Stream stream = new BatchStartDevicesResponse.BatchStartDevices_Result.BatchStartDevices_Stream();
					stream.Id = context.StringValue("BatchStartDevices.Results["+ i +"].Streams["+ j +"].Id");
					stream.Name = context.StringValue("BatchStartDevices.Results["+ i +"].Streams["+ j +"].Name");
					stream.Error = context.StringValue("BatchStartDevices.Results["+ i +"].Streams["+ j +"].Error");

					result_streams.Add(stream);
				}
				result.Streams = result_streams;

				batchStartDevicesResponse_results.Add(result);
			}
			batchStartDevicesResponse.Results = batchStartDevicesResponse_results;
        
			return batchStartDevicesResponse;
        }
    }
}
