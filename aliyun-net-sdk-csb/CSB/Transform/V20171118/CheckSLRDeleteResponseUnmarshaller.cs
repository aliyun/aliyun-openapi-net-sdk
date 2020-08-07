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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class CheckSLRDeleteResponseUnmarshaller
    {
        public static CheckSLRDeleteResponse Unmarshall(UnmarshallerContext context)
        {
			CheckSLRDeleteResponse checkSLRDeleteResponse = new CheckSLRDeleteResponse();

			checkSLRDeleteResponse.HttpResponse = context.HttpResponse;
			checkSLRDeleteResponse.Deletable = context.BooleanValue("CheckSLRDelete.Deletable");
			checkSLRDeleteResponse.RequestId = context.StringValue("CheckSLRDelete.RequestId");
			checkSLRDeleteResponse.Code = context.IntegerValue("CheckSLRDelete.Code");
			checkSLRDeleteResponse.Message = context.StringValue("CheckSLRDelete.Message");

			List<CheckSLRDeleteResponse.CheckSLRDelete_RoleUsage> checkSLRDeleteResponse_roleUsages = new List<CheckSLRDeleteResponse.CheckSLRDelete_RoleUsage>();
			for (int i = 0; i < context.Length("CheckSLRDelete.RoleUsages.Length"); i++) {
				CheckSLRDeleteResponse.CheckSLRDelete_RoleUsage roleUsage = new CheckSLRDeleteResponse.CheckSLRDelete_RoleUsage();
				roleUsage.Region = context.StringValue("CheckSLRDelete.RoleUsages["+ i +"].Region");

				List<string> roleUsage_resources = new List<string>();
				for (int j = 0; j < context.Length("CheckSLRDelete.RoleUsages["+ i +"].Resources.Length"); j++) {
					roleUsage_resources.Add(context.StringValue("CheckSLRDelete.RoleUsages["+ i +"].Resources["+ j +"]"));
				}
				roleUsage.Resources = roleUsage_resources;

				checkSLRDeleteResponse_roleUsages.Add(roleUsage);
			}
			checkSLRDeleteResponse.RoleUsages = checkSLRDeleteResponse_roleUsages;
        
			return checkSLRDeleteResponse;
        }
    }
}
