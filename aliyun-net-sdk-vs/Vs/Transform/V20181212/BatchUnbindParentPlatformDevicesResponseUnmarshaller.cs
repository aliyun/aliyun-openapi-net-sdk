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
    public class BatchUnbindParentPlatformDevicesResponseUnmarshaller
    {
        public static BatchUnbindParentPlatformDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchUnbindParentPlatformDevicesResponse batchUnbindParentPlatformDevicesResponse = new BatchUnbindParentPlatformDevicesResponse();

			batchUnbindParentPlatformDevicesResponse.HttpResponse = context.HttpResponse;
			batchUnbindParentPlatformDevicesResponse.RequestId = context.StringValue("BatchUnbindParentPlatformDevices.RequestId");

			List<BatchUnbindParentPlatformDevicesResponse.BatchUnbindParentPlatformDevices_Result> batchUnbindParentPlatformDevicesResponse_results = new List<BatchUnbindParentPlatformDevicesResponse.BatchUnbindParentPlatformDevices_Result>();
			for (int i = 0; i < context.Length("BatchUnbindParentPlatformDevices.Results.Length"); i++) {
				BatchUnbindParentPlatformDevicesResponse.BatchUnbindParentPlatformDevices_Result result = new BatchUnbindParentPlatformDevicesResponse.BatchUnbindParentPlatformDevices_Result();
				result.ParentPlatformId = context.StringValue("BatchUnbindParentPlatformDevices.Results["+ i +"].ParentPlatformId");
				result.DeviceId = context.StringValue("BatchUnbindParentPlatformDevices.Results["+ i +"].DeviceId");
				result.Error = context.StringValue("BatchUnbindParentPlatformDevices.Results["+ i +"].Error");

				batchUnbindParentPlatformDevicesResponse_results.Add(result);
			}
			batchUnbindParentPlatformDevicesResponse.Results = batchUnbindParentPlatformDevicesResponse_results;
        
			return batchUnbindParentPlatformDevicesResponse;
        }
    }
}
