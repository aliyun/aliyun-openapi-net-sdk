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
    public class ModifyGlobalSecurityIPGroupRelationResponseUnmarshaller
    {
        public static ModifyGlobalSecurityIPGroupRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyGlobalSecurityIPGroupRelationResponse modifyGlobalSecurityIPGroupRelationResponse = new ModifyGlobalSecurityIPGroupRelationResponse();

			modifyGlobalSecurityIPGroupRelationResponse.HttpResponse = _ctx.HttpResponse;
			modifyGlobalSecurityIPGroupRelationResponse.DBClusterId = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.DBClusterId");
			modifyGlobalSecurityIPGroupRelationResponse.RequestId = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.RequestId");

			List<ModifyGlobalSecurityIPGroupRelationResponse.ModifyGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem> modifyGlobalSecurityIPGroupRelationResponse_globalSecurityIPGroupRel = new List<ModifyGlobalSecurityIPGroupRelationResponse.ModifyGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem>();
			for (int i = 0; i < _ctx.Length("ModifyGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel.Length"); i++) {
				ModifyGlobalSecurityIPGroupRelationResponse.ModifyGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem globalSecurityIPGroupRelItem = new ModifyGlobalSecurityIPGroupRelationResponse.ModifyGlobalSecurityIPGroupRelation_GlobalSecurityIPGroupRelItem();
				globalSecurityIPGroupRelItem.GlobalSecurityGroupId = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupRelItem.GIpList = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].GIpList");
				globalSecurityIPGroupRelItem.RegionId = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].RegionId");
				globalSecurityIPGroupRelItem.WhitelistNetType = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].WhitelistNetType");
				globalSecurityIPGroupRelItem.GlobalIgName = _ctx.StringValue("ModifyGlobalSecurityIPGroupRelation.GlobalSecurityIPGroupRel["+ i +"].GlobalIgName");

				modifyGlobalSecurityIPGroupRelationResponse_globalSecurityIPGroupRel.Add(globalSecurityIPGroupRelItem);
			}
			modifyGlobalSecurityIPGroupRelationResponse.GlobalSecurityIPGroupRel = modifyGlobalSecurityIPGroupRelationResponse_globalSecurityIPGroupRel;
        
			return modifyGlobalSecurityIPGroupRelationResponse;
        }
    }
}
