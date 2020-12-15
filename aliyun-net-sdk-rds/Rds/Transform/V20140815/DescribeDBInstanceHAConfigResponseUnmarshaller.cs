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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceHAConfigResponseUnmarshaller
    {
        public static DescribeDBInstanceHAConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceHAConfigResponse describeDBInstanceHAConfigResponse = new DescribeDBInstanceHAConfigResponse();

			describeDBInstanceHAConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceHAConfigResponse.RequestId = _ctx.StringValue("DescribeDBInstanceHAConfig.RequestId");
			describeDBInstanceHAConfigResponse.DBInstanceId = _ctx.StringValue("DescribeDBInstanceHAConfig.DBInstanceId");
			describeDBInstanceHAConfigResponse.SyncMode = _ctx.StringValue("DescribeDBInstanceHAConfig.SyncMode");
			describeDBInstanceHAConfigResponse.HAMode = _ctx.StringValue("DescribeDBInstanceHAConfig.HAMode");

			List<DescribeDBInstanceHAConfigResponse.DescribeDBInstanceHAConfig_NodeInfo> describeDBInstanceHAConfigResponse_hostInstanceInfos = new List<DescribeDBInstanceHAConfigResponse.DescribeDBInstanceHAConfig_NodeInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceHAConfig.HostInstanceInfos.Length"); i++) {
				DescribeDBInstanceHAConfigResponse.DescribeDBInstanceHAConfig_NodeInfo nodeInfo = new DescribeDBInstanceHAConfigResponse.DescribeDBInstanceHAConfig_NodeInfo();
				nodeInfo.NodeId = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].NodeId");
				nodeInfo.RegionId = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].RegionId");
				nodeInfo.LogSyncTime = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].LogSyncTime");
				nodeInfo.DataSyncTime = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].DataSyncTime");
				nodeInfo.NodeType = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].NodeType");
				nodeInfo.ZoneId = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].ZoneId");
				nodeInfo.SyncStatus = _ctx.StringValue("DescribeDBInstanceHAConfig.HostInstanceInfos["+ i +"].SyncStatus");

				describeDBInstanceHAConfigResponse_hostInstanceInfos.Add(nodeInfo);
			}
			describeDBInstanceHAConfigResponse.HostInstanceInfos = describeDBInstanceHAConfigResponse_hostInstanceInfos;
        
			return describeDBInstanceHAConfigResponse;
        }
    }
}
