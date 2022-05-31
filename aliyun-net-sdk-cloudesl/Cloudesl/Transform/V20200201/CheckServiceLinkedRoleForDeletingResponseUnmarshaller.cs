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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class CheckServiceLinkedRoleForDeletingResponseUnmarshaller
    {
        public static CheckServiceLinkedRoleForDeletingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckServiceLinkedRoleForDeletingResponse checkServiceLinkedRoleForDeletingResponse = new CheckServiceLinkedRoleForDeletingResponse();

			checkServiceLinkedRoleForDeletingResponse.HttpResponse = _ctx.HttpResponse;
			checkServiceLinkedRoleForDeletingResponse.Deletable = _ctx.BooleanValue("CheckServiceLinkedRoleForDeleting.Deletable");
			checkServiceLinkedRoleForDeletingResponse.RequestId = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.RequestId");
			checkServiceLinkedRoleForDeletingResponse.Success = _ctx.BooleanValue("CheckServiceLinkedRoleForDeleting.Success");
			checkServiceLinkedRoleForDeletingResponse.Message = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.Message");
			checkServiceLinkedRoleForDeletingResponse.ErrorCode = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.ErrorCode");
			checkServiceLinkedRoleForDeletingResponse.ErrorMessage = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.ErrorMessage");
			checkServiceLinkedRoleForDeletingResponse.Code = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.Code");
			checkServiceLinkedRoleForDeletingResponse.DynamicCode = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.DynamicCode");
			checkServiceLinkedRoleForDeletingResponse.DynamicMessage = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.DynamicMessage");

			List<CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage> checkServiceLinkedRoleForDeletingResponse_roleUsages = new List<CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage>();
			for (int i = 0; i < _ctx.Length("CheckServiceLinkedRoleForDeleting.RoleUsages.Length"); i++) {
				CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage roleUsage = new CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage();
				roleUsage.Region = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Region");
				roleUsage.Resources = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Resources");

				checkServiceLinkedRoleForDeletingResponse_roleUsages.Add(roleUsage);
			}
			checkServiceLinkedRoleForDeletingResponse.RoleUsages = checkServiceLinkedRoleForDeletingResponse_roleUsages;
        
			return checkServiceLinkedRoleForDeletingResponse;
        }
    }
}
