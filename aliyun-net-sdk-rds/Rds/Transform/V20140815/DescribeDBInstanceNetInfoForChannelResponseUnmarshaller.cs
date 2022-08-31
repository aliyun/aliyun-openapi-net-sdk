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
    public class DescribeDBInstanceNetInfoForChannelResponseUnmarshaller
    {
        public static DescribeDBInstanceNetInfoForChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceNetInfoForChannelResponse describeDBInstanceNetInfoForChannelResponse = new DescribeDBInstanceNetInfoForChannelResponse();

			describeDBInstanceNetInfoForChannelResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceNetInfoForChannelResponse.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.InstanceNetworkType");
			describeDBInstanceNetInfoForChannelResponse.RequestId = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.RequestId");

			List<DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo> describeDBInstanceNetInfoForChannelResponse_dBInstanceNetInfos = new List<DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos.Length"); i++) {
				DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo dBInstanceNetInfo = new DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo();
				dBInstanceNetInfo.Upgradeable = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].Upgradeable");
				dBInstanceNetInfo.ExpiredTime = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].expiredTime");
				dBInstanceNetInfo.IPType = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].IPType");
				dBInstanceNetInfo.Port = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].Port");
				dBInstanceNetInfo.VPCId = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].VPCId");
				dBInstanceNetInfo.Availability = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].Availability");
				dBInstanceNetInfo.VSwitchId = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].VSwitchId");
				dBInstanceNetInfo.ConnectionStringType = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].ConnectionStringType");
				dBInstanceNetInfo.ConnectionString = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].ConnectionString");
				dBInstanceNetInfo.MaxDelayTime = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].MaxDelayTime");
				dBInstanceNetInfo.IPAddress = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].IPAddress");
				dBInstanceNetInfo.DistributionType = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].DistributionType");

				List<DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_SecurityIPGroup> dBInstanceNetInfo_securityIPGroups = new List<DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_SecurityIPGroup>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].SecurityIPGroups.Length"); j++) {
					DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_SecurityIPGroup securityIPGroup = new DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_SecurityIPGroup();
					securityIPGroup.SecurityIPs = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].SecurityIPGroups["+ j +"].SecurityIPs");
					securityIPGroup.SecurityIPGroupName = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].SecurityIPGroups["+ j +"].SecurityIPGroupName");

					dBInstanceNetInfo_securityIPGroups.Add(securityIPGroup);
				}
				dBInstanceNetInfo.SecurityIPGroups = dBInstanceNetInfo_securityIPGroups;

				List<DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_DBInstanceWeight> dBInstanceNetInfo_dBInstanceWeights = new List<DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_DBInstanceWeight>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].DBInstanceWeights.Length"); j++) {
					DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_DBInstanceWeight dBInstanceWeight = new DescribeDBInstanceNetInfoForChannelResponse.DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo.DescribeDBInstanceNetInfoForChannel_DBInstanceWeight();
					dBInstanceWeight.Availability = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].Availability");
					dBInstanceWeight.Weight = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].Weight");
					dBInstanceWeight.DBInstanceId = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].DBInstanceId");
					dBInstanceWeight.DBInstanceType = _ctx.StringValue("DescribeDBInstanceNetInfoForChannel.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].DBInstanceType");

					dBInstanceNetInfo_dBInstanceWeights.Add(dBInstanceWeight);
				}
				dBInstanceNetInfo.DBInstanceWeights = dBInstanceNetInfo_dBInstanceWeights;

				describeDBInstanceNetInfoForChannelResponse_dBInstanceNetInfos.Add(dBInstanceNetInfo);
			}
			describeDBInstanceNetInfoForChannelResponse.DBInstanceNetInfos = describeDBInstanceNetInfoForChannelResponse_dBInstanceNetInfos;
        
			return describeDBInstanceNetInfoForChannelResponse;
        }
    }
}
