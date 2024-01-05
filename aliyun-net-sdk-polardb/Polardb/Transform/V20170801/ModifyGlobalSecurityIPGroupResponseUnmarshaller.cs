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
    public class ModifyGlobalSecurityIPGroupResponseUnmarshaller
    {
        public static ModifyGlobalSecurityIPGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyGlobalSecurityIPGroupResponse modifyGlobalSecurityIPGroupResponse = new ModifyGlobalSecurityIPGroupResponse();

			modifyGlobalSecurityIPGroupResponse.HttpResponse = _ctx.HttpResponse;
			modifyGlobalSecurityIPGroupResponse.RequestId = _ctx.StringValue("ModifyGlobalSecurityIPGroup.RequestId");

			List<ModifyGlobalSecurityIPGroupResponse.ModifyGlobalSecurityIPGroup_GlobalSecurityIPGroupItem> modifyGlobalSecurityIPGroupResponse_globalSecurityIPGroup = new List<ModifyGlobalSecurityIPGroupResponse.ModifyGlobalSecurityIPGroup_GlobalSecurityIPGroupItem>();
			for (int i = 0; i < _ctx.Length("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup.Length"); i++) {
				ModifyGlobalSecurityIPGroupResponse.ModifyGlobalSecurityIPGroup_GlobalSecurityIPGroupItem globalSecurityIPGroupItem = new ModifyGlobalSecurityIPGroupResponse.ModifyGlobalSecurityIPGroup_GlobalSecurityIPGroupItem();
				globalSecurityIPGroupItem.GlobalSecurityGroupId = _ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupItem.GlobalIgName = _ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalIgName");
				globalSecurityIPGroupItem.SecurityIPType = _ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].SecurityIPType");
				globalSecurityIPGroupItem.GIpList = _ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GIpList");
				globalSecurityIPGroupItem.WhitelistNetType = _ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].WhitelistNetType");
				globalSecurityIPGroupItem.RegionId = _ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].RegionId");

				List<string> globalSecurityIPGroupItem_dBInstances = new List<string>();
				for (int j = 0; j < _ctx.Length("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].DBInstances.Length"); j++) {
					globalSecurityIPGroupItem_dBInstances.Add(_ctx.StringValue("ModifyGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].DBInstances["+ j +"]"));
				}
				globalSecurityIPGroupItem.DBInstances = globalSecurityIPGroupItem_dBInstances;

				modifyGlobalSecurityIPGroupResponse_globalSecurityIPGroup.Add(globalSecurityIPGroupItem);
			}
			modifyGlobalSecurityIPGroupResponse.GlobalSecurityIPGroup = modifyGlobalSecurityIPGroupResponse_globalSecurityIPGroup;
        
			return modifyGlobalSecurityIPGroupResponse;
        }
    }
}
