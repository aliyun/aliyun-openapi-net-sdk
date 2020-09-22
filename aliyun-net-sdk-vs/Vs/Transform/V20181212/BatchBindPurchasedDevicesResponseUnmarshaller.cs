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
    public class BatchBindPurchasedDevicesResponseUnmarshaller
    {
        public static BatchBindPurchasedDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchBindPurchasedDevicesResponse batchBindPurchasedDevicesResponse = new BatchBindPurchasedDevicesResponse();

			batchBindPurchasedDevicesResponse.HttpResponse = context.HttpResponse;
			batchBindPurchasedDevicesResponse.RequestId = context.StringValue("BatchBindPurchasedDevices.RequestId");

			List<BatchBindPurchasedDevicesResponse.BatchBindPurchasedDevices_Result> batchBindPurchasedDevicesResponse_results = new List<BatchBindPurchasedDevicesResponse.BatchBindPurchasedDevices_Result>();
			for (int i = 0; i < context.Length("BatchBindPurchasedDevices.Results.Length"); i++) {
				BatchBindPurchasedDevicesResponse.BatchBindPurchasedDevices_Result result = new BatchBindPurchasedDevicesResponse.BatchBindPurchasedDevices_Result();
				result.Region = context.StringValue("BatchBindPurchasedDevices.Results["+ i +"].Region");
				result.GroupId = context.StringValue("BatchBindPurchasedDevices.Results["+ i +"].GroupId");
				result.DeviceId = context.StringValue("BatchBindPurchasedDevices.Results["+ i +"].DeviceId");
				result.Error = context.StringValue("BatchBindPurchasedDevices.Results["+ i +"].Error");

				batchBindPurchasedDevicesResponse_results.Add(result);
			}
			batchBindPurchasedDevicesResponse.Results = batchBindPurchasedDevicesResponse_results;
        
			return batchBindPurchasedDevicesResponse;
        }
    }
}
