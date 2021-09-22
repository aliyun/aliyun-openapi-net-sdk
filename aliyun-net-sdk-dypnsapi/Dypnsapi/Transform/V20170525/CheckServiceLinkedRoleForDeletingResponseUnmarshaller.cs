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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class CheckServiceLinkedRoleForDeletingResponseUnmarshaller
    {
        public static CheckServiceLinkedRoleForDeletingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckServiceLinkedRoleForDeletingResponse checkServiceLinkedRoleForDeletingResponse = new CheckServiceLinkedRoleForDeletingResponse();

			checkServiceLinkedRoleForDeletingResponse.HttpResponse = _ctx.HttpResponse;
			checkServiceLinkedRoleForDeletingResponse.Deletable = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.Deletable");
			checkServiceLinkedRoleForDeletingResponse.RequestId = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.RequestId");

			List<CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage> checkServiceLinkedRoleForDeletingResponse_roleUsages = new List<CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage>();
			for (int i = 0; i < _ctx.Length("CheckServiceLinkedRoleForDeleting.RoleUsages.Length"); i++) {
				CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage roleUsage = new CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsage();
				roleUsage.Region = _ctx.StringValue("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Region");

				List<string> roleUsage_resources = new List<string>();
				for (int j = 0; j < _ctx.Length("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Resources.Length"); j++) {
					roleUsage_resources.Add(_ctx.StringValue("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Resources["+ j +"]"));
				}
				roleUsage.Resources = roleUsage_resources;

				checkServiceLinkedRoleForDeletingResponse_roleUsages.Add(roleUsage);
			}
			checkServiceLinkedRoleForDeletingResponse.RoleUsages = checkServiceLinkedRoleForDeletingResponse_roleUsages;
        
			return checkServiceLinkedRoleForDeletingResponse;
        }
    }
}
