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
    public class BatchGetEdgeInstanceDriverConfigsResponseUnmarshaller
    {
        public static BatchGetEdgeInstanceDriverConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetEdgeInstanceDriverConfigsResponse batchGetEdgeInstanceDriverConfigsResponse = new BatchGetEdgeInstanceDriverConfigsResponse();

			batchGetEdgeInstanceDriverConfigsResponse.HttpResponse = context.HttpResponse;
			batchGetEdgeInstanceDriverConfigsResponse.RequestId = context.StringValue("BatchGetEdgeInstanceDriverConfigs.RequestId");
			batchGetEdgeInstanceDriverConfigsResponse.Success = context.BooleanValue("BatchGetEdgeInstanceDriverConfigs.Success");
			batchGetEdgeInstanceDriverConfigsResponse.Code = context.StringValue("BatchGetEdgeInstanceDriverConfigs.Code");
			batchGetEdgeInstanceDriverConfigsResponse.ErrorMessage = context.StringValue("BatchGetEdgeInstanceDriverConfigs.ErrorMessage");

			List<BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig> batchGetEdgeInstanceDriverConfigsResponse_driverConfigList = new List<BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig>();
			for (int i = 0; i < context.Length("BatchGetEdgeInstanceDriverConfigs.DriverConfigList.Length"); i++) {
				BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig driverConfig = new BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig();
				driverConfig.DriverId = context.StringValue("BatchGetEdgeInstanceDriverConfigs.DriverConfigList["+ i +"].DriverId");

				List<BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig.BatchGetEdgeInstanceDriverConfigs_Config> driverConfig_configList = new List<BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig.BatchGetEdgeInstanceDriverConfigs_Config>();
				for (int j = 0; j < context.Length("BatchGetEdgeInstanceDriverConfigs.DriverConfigList["+ i +"].ConfigList.Length"); j++) {
					BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig.BatchGetEdgeInstanceDriverConfigs_Config config = new BatchGetEdgeInstanceDriverConfigsResponse.BatchGetEdgeInstanceDriverConfigs_DriverConfig.BatchGetEdgeInstanceDriverConfigs_Config();
					config.ConfigId = context.StringValue("BatchGetEdgeInstanceDriverConfigs.DriverConfigList["+ i +"].ConfigList["+ j +"].ConfigId");
					config.Format = context.StringValue("BatchGetEdgeInstanceDriverConfigs.DriverConfigList["+ i +"].ConfigList["+ j +"].Format");
					config.Content = context.StringValue("BatchGetEdgeInstanceDriverConfigs.DriverConfigList["+ i +"].ConfigList["+ j +"].Content");
					config.Key = context.StringValue("BatchGetEdgeInstanceDriverConfigs.DriverConfigList["+ i +"].ConfigList["+ j +"].Key");

					driverConfig_configList.Add(config);
				}
				driverConfig.ConfigList = driverConfig_configList;

				batchGetEdgeInstanceDriverConfigsResponse_driverConfigList.Add(driverConfig);
			}
			batchGetEdgeInstanceDriverConfigsResponse.DriverConfigList = batchGetEdgeInstanceDriverConfigsResponse_driverConfigList;
        
			return batchGetEdgeInstanceDriverConfigsResponse;
        }
    }
}
