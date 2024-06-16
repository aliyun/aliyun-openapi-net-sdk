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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class CreateGlobalSecurityIPGroupResponseUnmarshaller
    {
        public static CreateGlobalSecurityIPGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGlobalSecurityIPGroupResponse createGlobalSecurityIPGroupResponse = new CreateGlobalSecurityIPGroupResponse();

			createGlobalSecurityIPGroupResponse.HttpResponse = _ctx.HttpResponse;
			createGlobalSecurityIPGroupResponse.RequestId = _ctx.StringValue("CreateGlobalSecurityIPGroup.RequestId");

			List<CreateGlobalSecurityIPGroupResponse.CreateGlobalSecurityIPGroup_GlobalSecurityIPGroupItem> createGlobalSecurityIPGroupResponse_globalSecurityIPGroup = new List<CreateGlobalSecurityIPGroupResponse.CreateGlobalSecurityIPGroup_GlobalSecurityIPGroupItem>();
			for (int i = 0; i < _ctx.Length("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup.Length"); i++) {
				CreateGlobalSecurityIPGroupResponse.CreateGlobalSecurityIPGroup_GlobalSecurityIPGroupItem globalSecurityIPGroupItem = new CreateGlobalSecurityIPGroupResponse.CreateGlobalSecurityIPGroup_GlobalSecurityIPGroupItem();
				globalSecurityIPGroupItem.GlobalSecurityGroupId = _ctx.StringValue("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalSecurityGroupId");
				globalSecurityIPGroupItem.GlobalIgName = _ctx.StringValue("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GlobalIgName");
				globalSecurityIPGroupItem.SecurityIPType = _ctx.StringValue("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].SecurityIPType");
				globalSecurityIPGroupItem.GIpList = _ctx.StringValue("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].GIpList");
				globalSecurityIPGroupItem.WhitelistNetType = _ctx.StringValue("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].WhitelistNetType");
				globalSecurityIPGroupItem.RegionId = _ctx.StringValue("CreateGlobalSecurityIPGroup.GlobalSecurityIPGroup["+ i +"].RegionId");

				createGlobalSecurityIPGroupResponse_globalSecurityIPGroup.Add(globalSecurityIPGroupItem);
			}
			createGlobalSecurityIPGroupResponse.GlobalSecurityIPGroup = createGlobalSecurityIPGroupResponse_globalSecurityIPGroup;
        
			return createGlobalSecurityIPGroupResponse;
        }
    }
}
