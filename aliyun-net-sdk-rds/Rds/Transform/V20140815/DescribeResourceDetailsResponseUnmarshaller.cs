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
    public class DescribeResourceDetailsResponseUnmarshaller
    {
        public static DescribeResourceDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceDetailsResponse describeResourceDetailsResponse = new DescribeResourceDetailsResponse();

			describeResourceDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceDetailsResponse.RequestId = _ctx.StringValue("DescribeResourceDetails.RequestId");
			describeResourceDetailsResponse.Region = _ctx.StringValue("DescribeResourceDetails.Region");
			describeResourceDetailsResponse.InstanceStorageType = _ctx.StringValue("DescribeResourceDetails.InstanceStorageType");
			describeResourceDetailsResponse.DbInstanceStorage = _ctx.LongValue("DescribeResourceDetails.DbInstanceStorage");
			describeResourceDetailsResponse.DiskUsed = _ctx.LongValue("DescribeResourceDetails.DiskUsed");
			describeResourceDetailsResponse.BackupSize = _ctx.LongValue("DescribeResourceDetails.BackupSize");
			describeResourceDetailsResponse.VpcId = _ctx.StringValue("DescribeResourceDetails.VpcId");
			describeResourceDetailsResponse.VSwitchId = _ctx.StringValue("DescribeResourceDetails.VSwitchId");
			describeResourceDetailsResponse.SecurityIPList = _ctx.StringValue("DescribeResourceDetails.SecurityIPList");
			describeResourceDetailsResponse.DbProxyInstanceName = _ctx.StringValue("DescribeResourceDetails.DbProxyInstanceName");
			describeResourceDetailsResponse.ResourceGroupId = _ctx.StringValue("DescribeResourceDetails.ResourceGroupId");
			describeResourceDetailsResponse.BackupLogSize = _ctx.LongValue("DescribeResourceDetails.BackupLogSize");
			describeResourceDetailsResponse.BackupDataSize = _ctx.LongValue("DescribeResourceDetails.BackupDataSize");

			List<DescribeResourceDetailsResponse.DescribeResourceDetails_RdsEcsSecurityGroupRelItem> describeResourceDetailsResponse_rdsEcsSecurityGroupRel = new List<DescribeResourceDetailsResponse.DescribeResourceDetails_RdsEcsSecurityGroupRelItem>();
			for (int i = 0; i < _ctx.Length("DescribeResourceDetails.RdsEcsSecurityGroupRel.Length"); i++) {
				DescribeResourceDetailsResponse.DescribeResourceDetails_RdsEcsSecurityGroupRelItem rdsEcsSecurityGroupRelItem = new DescribeResourceDetailsResponse.DescribeResourceDetails_RdsEcsSecurityGroupRelItem();
				rdsEcsSecurityGroupRelItem.SecurityGroupName = _ctx.StringValue("DescribeResourceDetails.RdsEcsSecurityGroupRel["+ i +"].SecurityGroupName");

				describeResourceDetailsResponse_rdsEcsSecurityGroupRel.Add(rdsEcsSecurityGroupRelItem);
			}
			describeResourceDetailsResponse.RdsEcsSecurityGroupRel = describeResourceDetailsResponse_rdsEcsSecurityGroupRel;
        
			return describeResourceDetailsResponse;
        }
    }
}
