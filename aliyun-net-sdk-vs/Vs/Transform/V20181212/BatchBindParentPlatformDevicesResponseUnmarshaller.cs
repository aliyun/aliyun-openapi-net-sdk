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
    public class BatchBindParentPlatformDevicesResponseUnmarshaller
    {
        public static BatchBindParentPlatformDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchBindParentPlatformDevicesResponse batchBindParentPlatformDevicesResponse = new BatchBindParentPlatformDevicesResponse();

			batchBindParentPlatformDevicesResponse.HttpResponse = _ctx.HttpResponse;
			batchBindParentPlatformDevicesResponse.RequestId = _ctx.StringValue("BatchBindParentPlatformDevices.RequestId");

			List<BatchBindParentPlatformDevicesResponse.BatchBindParentPlatformDevices_Result> batchBindParentPlatformDevicesResponse_results = new List<BatchBindParentPlatformDevicesResponse.BatchBindParentPlatformDevices_Result>();
			for (int i = 0; i < _ctx.Length("BatchBindParentPlatformDevices.Results.Length"); i++) {
				BatchBindParentPlatformDevicesResponse.BatchBindParentPlatformDevices_Result result = new BatchBindParentPlatformDevicesResponse.BatchBindParentPlatformDevices_Result();
				result.ParentPlatformId = _ctx.StringValue("BatchBindParentPlatformDevices.Results["+ i +"].ParentPlatformId");
				result.DeviceId = _ctx.StringValue("BatchBindParentPlatformDevices.Results["+ i +"].DeviceId");
				result.Error = _ctx.StringValue("BatchBindParentPlatformDevices.Results["+ i +"].Error");

				batchBindParentPlatformDevicesResponse_results.Add(result);
			}
			batchBindParentPlatformDevicesResponse.Results = batchBindParentPlatformDevicesResponse_results;
        
			return batchBindParentPlatformDevicesResponse;
        }
    }
}
