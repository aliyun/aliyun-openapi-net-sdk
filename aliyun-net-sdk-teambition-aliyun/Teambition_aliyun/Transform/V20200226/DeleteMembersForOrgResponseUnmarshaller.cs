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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class DeleteMembersForOrgResponseUnmarshaller
    {
        public static DeleteMembersForOrgResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteMembersForOrgResponse deleteMembersForOrgResponse = new DeleteMembersForOrgResponse();

			deleteMembersForOrgResponse.HttpResponse = context.HttpResponse;
			deleteMembersForOrgResponse.RequestId = context.StringValue("DeleteMembersForOrg.RequestId");
			deleteMembersForOrgResponse.ErrorCode = context.StringValue("DeleteMembersForOrg.ErrorCode");
			deleteMembersForOrgResponse.ErrorMessage = context.StringValue("DeleteMembersForOrg.ErrorMessage");
			deleteMembersForOrgResponse.Success = context.BooleanValue("DeleteMembersForOrg.Success");
			deleteMembersForOrgResponse._Object = context.BooleanValue("DeleteMembersForOrg.Object");
        
			return deleteMembersForOrgResponse;
        }
    }
}
