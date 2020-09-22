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
    public class BatchStopDevicesResponseUnmarshaller
    {
        public static BatchStopDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchStopDevicesResponse batchStopDevicesResponse = new BatchStopDevicesResponse();

			batchStopDevicesResponse.HttpResponse = context.HttpResponse;
			batchStopDevicesResponse.RequestId = context.StringValue("BatchStopDevices.RequestId");

			List<BatchStopDevicesResponse.BatchStopDevices_Result> batchStopDevicesResponse_results = new List<BatchStopDevicesResponse.BatchStopDevices_Result>();
			for (int i = 0; i < context.Length("BatchStopDevices.Results.Length"); i++) {
				BatchStopDevicesResponse.BatchStopDevices_Result result = new BatchStopDevicesResponse.BatchStopDevices_Result();
				result.Id = context.StringValue("BatchStopDevices.Results["+ i +"].Id");

				List<BatchStopDevicesResponse.BatchStopDevices_Result.BatchStopDevices_Stream> result_streams = new List<BatchStopDevicesResponse.BatchStopDevices_Result.BatchStopDevices_Stream>();
				for (int j = 0; j < context.Length("BatchStopDevices.Results["+ i +"].Streams.Length"); j++) {
					BatchStopDevicesResponse.BatchStopDevices_Result.BatchStopDevices_Stream stream = new BatchStopDevicesResponse.BatchStopDevices_Result.BatchStopDevices_Stream();
					stream.Id = context.StringValue("BatchStopDevices.Results["+ i +"].Streams["+ j +"].Id");
					stream.Name = context.StringValue("BatchStopDevices.Results["+ i +"].Streams["+ j +"].Name");
					stream.Error = context.StringValue("BatchStopDevices.Results["+ i +"].Streams["+ j +"].Error");

					result_streams.Add(stream);
				}
				result.Streams = result_streams;

				batchStopDevicesResponse_results.Add(result);
			}
			batchStopDevicesResponse.Results = batchStopDevicesResponse_results;
        
			return batchStopDevicesResponse;
        }
    }
}
