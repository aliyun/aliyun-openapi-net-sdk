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
    public class DescribeGlobalSecurityIPGroupResponseUnmarshaller
    {
        public static DescribeGlobalSecurityIPGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalSecurityIPGroupResponse describeGlobalSecurityIPGroupResponse = new DescribeGlobalSecurityIPGroupResponse();

			describeGlobalSecurityIPGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalSecurityIPGroupResponse.RequestId = _ctx.StringValue("DescribeGlobalSecurityIPGroup.RequestId");

			List<DescribeGlobalSecurityIPGroupResponse.DescribeGlobalSecurityIPGroup_GlobalSecurityIPGroupItem> describeGlobalSecurityIPGroupResponse_globalSecurityIPGroup = new List<DescribeGlobalSecurityIPGroupResponse.DescribeGlobalSecurityIPGroup_GlobalSecurityIPGroupItem>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup.Length"); i++) {
				DescribeGlobalSecurityIPGroupResponse.DescribeGlobalSecurityIPGroup_GlobalSecurityIPGroupItem globalSecurityIPGroupItem = new DescribeGlobalSecurityIPGroupResponse.DescribeGlobalSecurityIPGroup_GlobalSecurityIPGroupItem();
				globalSecurityIPGroupItem.GlobalSecurityGroupId = _ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupItem.GlobalIgName = _ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalIgName");
				globalSecurityIPGroupItem.SecurityIPType = _ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].SecurityIPType");
				globalSecurityIPGroupItem.GIpList = _ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GIpList");
				globalSecurityIPGroupItem.WhitelistNetType = _ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].WhitelistNetType");
				globalSecurityIPGroupItem.RegionId = _ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].RegionId");

				List<string> globalSecurityIPGroupItem_dBInstances = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].DBInstances.Length"); j++) {
					globalSecurityIPGroupItem_dBInstances.Add(_ctx.StringValue("DescribeGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].DBInstances["+ j +"]"));
				}
				globalSecurityIPGroupItem.DBInstances = globalSecurityIPGroupItem_dBInstances;

				describeGlobalSecurityIPGroupResponse_globalSecurityIPGroup.Add(globalSecurityIPGroupItem);
			}
			describeGlobalSecurityIPGroupResponse.GlobalSecurityIPGroup = describeGlobalSecurityIPGroupResponse_globalSecurityIPGroup;
        
			return describeGlobalSecurityIPGroupResponse;
        }
    }
}
