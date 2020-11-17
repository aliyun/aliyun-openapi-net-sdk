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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterAccessWhitelistResponseUnmarshaller
    {
        public static DescribeDBClusterAccessWhitelistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAccessWhitelistResponse describeDBClusterAccessWhitelistResponse = new DescribeDBClusterAccessWhitelistResponse();

			describeDBClusterAccessWhitelistResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAccessWhitelistResponse.RequestId = _ctx.StringValue("DescribeDBClusterAccessWhitelist.RequestId");

			List<DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterIPArray> describeDBClusterAccessWhitelistResponse_items = new List<DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterIPArray>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAccessWhitelist.Items.Length"); i++) {
				DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterIPArray dBClusterIPArray = new DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterIPArray();
				dBClusterIPArray.DBClusterIPArrayName = _ctx.StringValue("DescribeDBClusterAccessWhitelist.Items["+ i +"].DBClusterIPArrayName");
				dBClusterIPArray.DBClusterIPArrayAttribute = _ctx.StringValue("DescribeDBClusterAccessWhitelist.Items["+ i +"].DBClusterIPArrayAttribute");
				dBClusterIPArray.SecurityIps = _ctx.StringValue("DescribeDBClusterAccessWhitelist.Items["+ i +"].SecurityIps");

				describeDBClusterAccessWhitelistResponse_items.Add(dBClusterIPArray);
			}
			describeDBClusterAccessWhitelistResponse.Items = describeDBClusterAccessWhitelistResponse_items;

			List<DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup> describeDBClusterAccessWhitelistResponse_dBClusterSecurityGroups = new List<DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAccessWhitelist.DBClusterSecurityGroups.Length"); i++) {
				DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup dBClusterSecurityGroup = new DescribeDBClusterAccessWhitelistResponse.DescribeDBClusterAccessWhitelist_DBClusterSecurityGroup();
				dBClusterSecurityGroup.SecurityGroupId = _ctx.StringValue("DescribeDBClusterAccessWhitelist.DBClusterSecurityGroups["+ i +"].SecurityGroupId");
				dBClusterSecurityGroup.SecurityGroupName = _ctx.StringValue("DescribeDBClusterAccessWhitelist.DBClusterSecurityGroups["+ i +"].SecurityGroupName");

				describeDBClusterAccessWhitelistResponse_dBClusterSecurityGroups.Add(dBClusterSecurityGroup);
			}
			describeDBClusterAccessWhitelistResponse.DBClusterSecurityGroups = describeDBClusterAccessWhitelistResponse_dBClusterSecurityGroups;
        
			return describeDBClusterAccessWhitelistResponse;
        }
    }
}
