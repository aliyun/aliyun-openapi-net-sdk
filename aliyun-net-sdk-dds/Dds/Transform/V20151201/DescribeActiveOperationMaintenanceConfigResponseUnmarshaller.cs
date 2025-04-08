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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeActiveOperationMaintenanceConfigResponseUnmarshaller
    {
        public static DescribeActiveOperationMaintenanceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationMaintenanceConfigResponse describeActiveOperationMaintenanceConfigResponse = new DescribeActiveOperationMaintenanceConfigResponse();

			describeActiveOperationMaintenanceConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationMaintenanceConfigResponse.HasConfig = _ctx.IntegerValue("DescribeActiveOperationMaintenanceConfig.HasConfig");
			describeActiveOperationMaintenanceConfigResponse.RequestId = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.RequestId");

			DescribeActiveOperationMaintenanceConfigResponse.DescribeActiveOperationMaintenanceConfig_Config config = new DescribeActiveOperationMaintenanceConfigResponse.DescribeActiveOperationMaintenanceConfig_Config();
			config.CycleType = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.Config.CycleType");
			config.Status = _ctx.IntegerValue("DescribeActiveOperationMaintenanceConfig.Config.Status");
			config.ModifiedTime = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.Config.ModifiedTime");
			config.MaintainStartTime = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.Config.MaintainStartTime");
			config.MaintainEndTime = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.Config.MaintainEndTime");
			config.CycleTime = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.Config.CycleTime");
			config.CreatedTime = _ctx.StringValue("DescribeActiveOperationMaintenanceConfig.Config.CreatedTime");
			describeActiveOperationMaintenanceConfigResponse.Config = config;
        
			return describeActiveOperationMaintenanceConfigResponse;
        }
    }
}
