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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceHAConfigResponseUnmarshaller
    {
        public static DescribeDBInstanceHAConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceHAConfigResponse describeDBInstanceHAConfigResponse = new DescribeDBInstanceHAConfigResponse();

			describeDBInstanceHAConfigResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceHAConfigResponse.RequestId = context.StringValue("DescribeDBInstanceHAConfig.RequestId");
			describeDBInstanceHAConfigResponse.DBInstanceId = context.StringValue("DescribeDBInstanceHAConfig.DBInstanceId");
			describeDBInstanceHAConfigResponse.SyncMode = context.StringValue("DescribeDBInstanceHAConfig.SyncMode");
			describeDBInstanceHAConfigResponse.HAMode = context.StringValue("DescribeDBInstanceHAConfig.HAMode");

			List<DescribeDBInstanceHAConfigResponse.NodeInfo> hostInstanceInfos = new List<DescribeDBInstanceHAConfigResponse.NodeInfo>();
			for (int i = 0; i < context.Length("DescribeDBInstanceHAConfig.HostInstanceInfos.Length"); i++) {
				DescribeDBInstanceHAConfigResponse.NodeInfo nodeInfo = new DescribeDBInstanceHAConfigResponse.NodeInfo();
				nodeInfo.NodeId = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].NodeId");
				nodeInfo.RegionId = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].RegionId");
				nodeInfo.LogSyncTime = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].LogSyncTime");
				nodeInfo.DataSyncTime = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].DataSyncTime");
				nodeInfo.NodeType = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].NodeType");
				nodeInfo.ZoneId = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].ZoneId");
				nodeInfo.SyncStatus = context.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].SyncStatus");

				hostInstanceInfos.Add(nodeInfo);
			}
			describeDBInstanceHAConfigResponse.HostInstanceInfos = hostInstanceInfos;
        
			return describeDBInstanceHAConfigResponse;
        }
    }
}