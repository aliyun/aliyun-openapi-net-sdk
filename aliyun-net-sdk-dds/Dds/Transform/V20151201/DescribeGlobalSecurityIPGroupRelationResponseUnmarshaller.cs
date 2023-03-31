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
    public class DescribeGlobalSecurityIPGroupRelationResponseUnmarshaller
    {
        public static DescribeGlobalSecurityIPGroupRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalSecurityIPGroupRelationResponse describeGlobalSecurityIPGroupRelationResponse = new DescribeGlobalSecurityIPGroupRelationResponse();

			describeGlobalSecurityIPGroupRelationResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalSecurityIPGroupRelationResponse.DBClusterId = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.DBClusterId");
			describeGlobalSecurityIPGroupRelationResponse.RequestId = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.RequestId");

			List<DescribeGlobalSecurityIPGroupRelationResponse.DescribeGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem> describeGlobalSecurityIPGroupRelationResponse_globalSecurityIPGroupRel = new List<DescribeGlobalSecurityIPGroupRelationResponse.DescribeGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel.Length"); i++) {
				DescribeGlobalSecurityIPGroupRelationResponse.DescribeGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem globalSecurityIPGroupRelItem = new DescribeGlobalSecurityIPGroupRelationResponse.DescribeGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem();
				globalSecurityIPGroupRelItem.GlobalSecurityGroupId = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupRelItem.GIpList = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].GIpList");
				globalSecurityIPGroupRelItem.RegionId = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].RegionId");
				globalSecurityIPGroupRelItem.WhitelistNetType = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].WhitelistNetType");
				globalSecurityIPGroupRelItem.GlobalIgName = _ctx.StringValue("DescribeGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].GlobalIgName");

				describeGlobalSecurityIPGroupRelationResponse_globalSecurityIPGroupRel.Add(globalSecurityIPGroupRelItem);
			}
			describeGlobalSecurityIPGroupRelationResponse.GlobalSecurityIPGroupRel = describeGlobalSecurityIPGroupRelationResponse_globalSecurityIPGroupRel;
        
			return describeGlobalSecurityIPGroupRelationResponse;
        }
    }
}
