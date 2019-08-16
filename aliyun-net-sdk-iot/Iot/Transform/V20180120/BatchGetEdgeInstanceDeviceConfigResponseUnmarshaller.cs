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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class BatchGetEdgeInstanceDeviceConfigResponseUnmarshaller
    {
        public static BatchGetEdgeInstanceDeviceConfigResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetEdgeInstanceDeviceConfigResponse batchGetEdgeInstanceDeviceConfigResponse = new BatchGetEdgeInstanceDeviceConfigResponse();

			batchGetEdgeInstanceDeviceConfigResponse.HttpResponse = context.HttpResponse;
			batchGetEdgeInstanceDeviceConfigResponse.RequestId = context.StringValue("BatchGetEdgeInstanceDeviceConfig.RequestId");
			batchGetEdgeInstanceDeviceConfigResponse.Success = context.BooleanValue("BatchGetEdgeInstanceDeviceConfig.Success");
			batchGetEdgeInstanceDeviceConfigResponse.Code = context.StringValue("BatchGetEdgeInstanceDeviceConfig.Code");
			batchGetEdgeInstanceDeviceConfigResponse.ErrorMessage = context.StringValue("BatchGetEdgeInstanceDeviceConfig.ErrorMessage");

			List<BatchGetEdgeInstanceDeviceConfigResponse.BatchGetEdgeInstanceDeviceConfig_DeviceConfig> batchGetEdgeInstanceDeviceConfigResponse_deviceConfigList = new List<BatchGetEdgeInstanceDeviceConfigResponse.BatchGetEdgeInstanceDeviceConfig_DeviceConfig>();
			for (int i = 0; i < context.Length("BatchGetEdgeInstanceDeviceConfig.DeviceConfigList.Length"); i++) {
				BatchGetEdgeInstanceDeviceConfigResponse.BatchGetEdgeInstanceDeviceConfig_DeviceConfig deviceConfig = new BatchGetEdgeInstanceDeviceConfigResponse.BatchGetEdgeInstanceDeviceConfig_DeviceConfig();
				deviceConfig.IotId = context.StringValue("BatchGetEdgeInstanceDeviceConfig.DeviceConfigList["+ i +"].IotId");

				BatchGetEdgeInstanceDeviceConfigResponse.BatchGetEdgeInstanceDeviceConfig_DeviceConfig.BatchGetEdgeInstanceDeviceConfig_Config config = new BatchGetEdgeInstanceDeviceConfigResponse.BatchGetEdgeInstanceDeviceConfig_DeviceConfig.BatchGetEdgeInstanceDeviceConfig_Config();
				config.Format = context.StringValue("BatchGetEdgeInstanceDeviceConfig.DeviceConfigList["+ i +"].Config.Format");
				config.Content = context.StringValue("BatchGetEdgeInstanceDeviceConfig.DeviceConfigList["+ i +"].Config.Content");
				deviceConfig.Config = config;

				batchGetEdgeInstanceDeviceConfigResponse_deviceConfigList.Add(deviceConfig);
			}
			batchGetEdgeInstanceDeviceConfigResponse.DeviceConfigList = batchGetEdgeInstanceDeviceConfigResponse_deviceConfigList;
        
			return batchGetEdgeInstanceDeviceConfigResponse;
        }
    }
}
