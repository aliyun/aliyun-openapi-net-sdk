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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeActiveOperationMaintainConfResponseUnmarshaller
    {
        public static DescribeActiveOperationMaintainConfResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationMaintainConfResponse describeActiveOperationMaintainConfResponse = new DescribeActiveOperationMaintainConfResponse();

			describeActiveOperationMaintainConfResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationMaintainConfResponse.RequestId = _ctx.StringValue("DescribeActiveOperationMaintainConf.RequestId");
			describeActiveOperationMaintainConfResponse.HasConfig = _ctx.LongValue("DescribeActiveOperationMaintainConf.HasConfig");

			DescribeActiveOperationMaintainConfResponse.DescribeActiveOperationMaintainConf_Config config = new DescribeActiveOperationMaintainConfResponse.DescribeActiveOperationMaintainConf_Config();
			config.CreatedTime = _ctx.StringValue("DescribeActiveOperationMaintainConf.Config.CreatedTime");
			config.CycleTime = _ctx.StringValue("DescribeActiveOperationMaintainConf.Config.CycleTime");
			config.CycleType = _ctx.StringValue("DescribeActiveOperationMaintainConf.Config.CycleType");
			config.MaintainEndTime = _ctx.StringValue("DescribeActiveOperationMaintainConf.Config.MaintainEndTime");
			config.MaintainStartTime = _ctx.StringValue("DescribeActiveOperationMaintainConf.Config.MaintainStartTime");
			config.ModifiedTime = _ctx.StringValue("DescribeActiveOperationMaintainConf.Config.ModifiedTime");
			config.Status = _ctx.LongValue("DescribeActiveOperationMaintainConf.Config.Status");
			describeActiveOperationMaintainConfResponse.Config = config;
        
			return describeActiveOperationMaintainConfResponse;
        }
    }
}
