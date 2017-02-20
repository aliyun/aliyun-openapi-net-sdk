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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceHaConfigResponseUnmarshaller
    {
        public static DescribeDBInstanceHaConfigResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstanceHaConfigResponse describeDBInstanceHaConfigResponse = new DescribeDBInstanceHaConfigResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDBInstanceHAConfig.RequestId"),
                DBInstanceId = context.StringValue("DescribeDBInstanceHAConfig.DBInstanceId"),
                SyncMode = context.StringValue("DescribeDBInstanceHAConfig.SyncMode"),
                HaMode = context.StringValue("DescribeDBInstanceHAConfig.HAMode")
            };
            List<DescribeDBInstanceHaConfigResponse.NodeInfo> hostInstanceInfos = new List<DescribeDBInstanceHaConfigResponse.NodeInfo>();
			for (int i = 0; i < context.Length("DescribeDBInstanceHAConfig.HostInstanceInfos.Length"); i++) {
                DescribeDBInstanceHaConfigResponse.NodeInfo nodeInfo = new DescribeDBInstanceHaConfigResponse.NodeInfo()
                {
                    NodeId = context.StringValue($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].NodeId"),
                    RegionId = context.StringValue($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].RegionId"),
                    LogSyncTime = context.StringValue($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].LogSyncTime"),
                    DataSyncTime = context.StringValue($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].DataSyncTime"),
                    NodeType = context.StringValue($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].NodeType"),
                    ZoneId = context.StringValue($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].ZoneId"),
                    SyncStatus = context.EnumValue<DescribeDBInstanceHaConfigResponse.NodeInfo.SyncStatusEnum>($"DescribeDBInstanceHAConfig.HostInstanceInfos[{i}].SyncStatus")
                };
                hostInstanceInfos.Add(nodeInfo);
			}
			describeDBInstanceHaConfigResponse.HostInstanceInfos = hostInstanceInfos;
        
			return describeDBInstanceHaConfigResponse;
        }
    }
}