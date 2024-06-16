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
    public class DeleteGlobalSecurityIPGroupResponseUnmarshaller
    {
        public static DeleteGlobalSecurityIPGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteGlobalSecurityIPGroupResponse deleteGlobalSecurityIPGroupResponse = new DeleteGlobalSecurityIPGroupResponse();

			deleteGlobalSecurityIPGroupResponse.HttpResponse = _ctx.HttpResponse;
			deleteGlobalSecurityIPGroupResponse.RequestId = _ctx.StringValue("DeleteGlobalSecurityIPGroup.RequestId");

			List<DeleteGlobalSecurityIPGroupResponse.DeleteGlobalSecurityIPGroup_GlobalSecurityIPGroupItem> deleteGlobalSecurityIPGroupResponse_globalSecurityIPGroup = new List<DeleteGlobalSecurityIPGroupResponse.DeleteGlobalSecurityIPGroup_GlobalSecurityIPGroupItem>();
			for (int i = 0; i < _ctx.Length("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup.Length"); i++) {
				DeleteGlobalSecurityIPGroupResponse.DeleteGlobalSecurityIPGroup_GlobalSecurityIPGroupItem globalSecurityIPGroupItem = new DeleteGlobalSecurityIPGroupResponse.DeleteGlobalSecurityIPGroup_GlobalSecurityIPGroupItem();
				globalSecurityIPGroupItem.GlobalSecurityGroupId = _ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupItem.GlobalIgName = _ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalIgName");
				globalSecurityIPGroupItem.SecurityIPType = _ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].SecurityIPType");
				globalSecurityIPGroupItem.GIpList = _ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GIpList");
				globalSecurityIPGroupItem.WhitelistNetType = _ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].WhitelistNetType");
				globalSecurityIPGroupItem.RegionId = _ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].RegionId");

				List<string> globalSecurityIPGroupItem_dBInstances = new List<string>();
				for (int j = 0; j < _ctx.Length("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].DBInstances.Length"); j++) {
					globalSecurityIPGroupItem_dBInstances.Add(_ctx.StringValue("DeleteGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].DBInstances["+ j +"]"));
				}
				globalSecurityIPGroupItem.DBInstances = globalSecurityIPGroupItem_dBInstances;

				deleteGlobalSecurityIPGroupResponse_globalSecurityIPGroup.Add(globalSecurityIPGroupItem);
			}
			deleteGlobalSecurityIPGroupResponse.GlobalSecurityIPGroup = deleteGlobalSecurityIPGroupResponse_globalSecurityIPGroup;
        
			return deleteGlobalSecurityIPGroupResponse;
        }
    }
}
