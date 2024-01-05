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
    public class ModifyGlobalSecurityIPGroupNameResponseUnmarshaller
    {
        public static ModifyGlobalSecurityIPGroupNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyGlobalSecurityIPGroupNameResponse modifyGlobalSecurityIPGroupNameResponse = new ModifyGlobalSecurityIPGroupNameResponse();

			modifyGlobalSecurityIPGroupNameResponse.HttpResponse = _ctx.HttpResponse;
			modifyGlobalSecurityIPGroupNameResponse.RequestId = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.RequestId");

			List<ModifyGlobalSecurityIPGroupNameResponse.ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem> modifyGlobalSecurityIPGroupNameResponse_globalSecurityIPGroup = new List<ModifyGlobalSecurityIPGroupNameResponse.ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem>();
			for (int i = 0; i < _ctx.Length("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup.Length"); i++) {
				ModifyGlobalSecurityIPGroupNameResponse.ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem globalSecurityIPGroupItem = new ModifyGlobalSecurityIPGroupNameResponse.ModifyGlobalSecurityIPGroupName_GlobalSecurityIPGroupItem();
				globalSecurityIPGroupItem.GlobalSecurityGroupId = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupItem.GlobalIgName = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup["+ i +"].GlobalIgName");
				globalSecurityIPGroupItem.SecurityIPType = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup["+ i +"].SecurityIPType");
				globalSecurityIPGroupItem.GIpList = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup["+ i +"].GIpList");
				globalSecurityIPGroupItem.WhitelistNetType = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup["+ i +"].WhitelistNetType");
				globalSecurityIPGroupItem.RegionId = _ctx.StringValue("ModifyGlobalSecurityIPGroupName.GlobalSecurityIPGroup["+ i +"].RegionId");

				modifyGlobalSecurityIPGroupNameResponse_globalSecurityIPGroup.Add(globalSecurityIPGroupItem);
			}
			modifyGlobalSecurityIPGroupNameResponse.GlobalSecurityIPGroup = modifyGlobalSecurityIPGroupNameResponse_globalSecurityIPGroup;
        
			return modifyGlobalSecurityIPGroupNameResponse;
        }
    }
}
