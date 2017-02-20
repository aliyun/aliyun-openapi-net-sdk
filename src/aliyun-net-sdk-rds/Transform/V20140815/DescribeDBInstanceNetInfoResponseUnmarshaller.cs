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
    public class DescribeDBInstanceNetInfoResponseUnmarshaller
    {
        public static DescribeDBInstanceNetInfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstanceNetInfoResponse describeDBInstanceNetInfoResponse = new DescribeDBInstanceNetInfoResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDBInstanceNetInfo.RequestId"),
                InstanceNetworkType = context.StringValue("DescribeDBInstanceNetInfo.InstanceNetworkType")
            };
            List<DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo> dBInstanceNetInfos = new List<DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo>();
			for (int i = 0; i < context.Length("DescribeDBInstanceNetInfo.DBInstanceNetInfos.Length"); i++) {
                DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo dBInstanceNetInfo = new DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo()
                {
                    ConnectionString = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].ConnectionString"),
                    IpAddress = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].IPAddress"),
                    IpType = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].IPType"),
                    Port = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].Port"),
                    VpcId = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].VPCId"),
                    VSwitchId = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].VSwitchId")
                };
                List<DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo.SecurityIpGroup> securityIpGroups = new List<DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo.SecurityIpGroup>();
				for (int j = 0; j < context.Length($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].SecurityIPGroups.Length"); j++) {
                    DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo.SecurityIpGroup securityIpGroup = new DescribeDBInstanceNetInfoResponse.DBInstanceNetInfo.SecurityIpGroup()
                    {
                        SecurityIpGroupName = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].SecurityIPGroups[{j}].SecurityIPGroupName"),
                        SecurityIPs = context.StringValue($"DescribeDBInstanceNetInfo.DBInstanceNetInfos[{i}].SecurityIPGroups[{j}].SecurityIPs")
                    };
                    securityIpGroups.Add(securityIpGroup);
				}
				dBInstanceNetInfo.SecurityIpGroups = securityIpGroups;

				dBInstanceNetInfos.Add(dBInstanceNetInfo);
			}
			describeDBInstanceNetInfoResponse.DBInstanceNetInfos = dBInstanceNetInfos;
        
			return describeDBInstanceNetInfoResponse;
        }
    }
}