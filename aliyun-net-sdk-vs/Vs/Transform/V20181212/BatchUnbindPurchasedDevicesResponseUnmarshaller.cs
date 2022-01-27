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
    public class BatchUnbindPurchasedDevicesResponseUnmarshaller
    {
        public static BatchUnbindPurchasedDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchUnbindPurchasedDevicesResponse batchUnbindPurchasedDevicesResponse = new BatchUnbindPurchasedDevicesResponse();

			batchUnbindPurchasedDevicesResponse.HttpResponse = _ctx.HttpResponse;
			batchUnbindPurchasedDevicesResponse.RequestId = _ctx.StringValue("BatchUnbindPurchasedDevices.RequestId");

			List<BatchUnbindPurchasedDevicesResponse.BatchUnbindPurchasedDevices_Result> batchUnbindPurchasedDevicesResponse_results = new List<BatchUnbindPurchasedDevicesResponse.BatchUnbindPurchasedDevices_Result>();
			for (int i = 0; i < _ctx.Length("BatchUnbindPurchasedDevices.Results.Length"); i++) {
				BatchUnbindPurchasedDevicesResponse.BatchUnbindPurchasedDevices_Result result = new BatchUnbindPurchasedDevicesResponse.BatchUnbindPurchasedDevices_Result();
				result.DeviceId = _ctx.StringValue("BatchUnbindPurchasedDevices.Results["+ i +"].DeviceId");
				result.Error = _ctx.StringValue("BatchUnbindPurchasedDevices.Results["+ i +"].Error");

				batchUnbindPurchasedDevicesResponse_results.Add(result);
			}
			batchUnbindPurchasedDevicesResponse.Results = batchUnbindPurchasedDevicesResponse_results;
        
			return batchUnbindPurchasedDevicesResponse;
        }
    }
}
