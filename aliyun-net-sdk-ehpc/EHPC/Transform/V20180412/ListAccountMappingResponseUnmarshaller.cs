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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListAccountMappingResponseUnmarshaller
    {
        public static ListAccountMappingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAccountMappingResponse listAccountMappingResponse = new ListAccountMappingResponse();

			listAccountMappingResponse.HttpResponse = _ctx.HttpResponse;
			listAccountMappingResponse.RequestId = _ctx.StringValue("ListAccountMapping.RequestId");

			List<ListAccountMappingResponse.ListAccountMapping_UserMapping> listAccountMappingResponse_userMappings = new List<ListAccountMappingResponse.ListAccountMapping_UserMapping>();
			for (int i = 0; i < _ctx.Length("ListAccountMapping.UserMappings.Length"); i++) {
				ListAccountMappingResponse.ListAccountMapping_UserMapping userMapping = new ListAccountMappingResponse.ListAccountMapping_UserMapping();
				userMapping.UserName = _ctx.StringValue("ListAccountMapping.UserMappings["+ i +"].UserName");
				userMapping.AccountId = _ctx.StringValue("ListAccountMapping.UserMappings["+ i +"].AccountId");
				userMapping.AccountName = _ctx.StringValue("ListAccountMapping.UserMappings["+ i +"].AccountName");

				listAccountMappingResponse_userMappings.Add(userMapping);
			}
			listAccountMappingResponse.UserMappings = listAccountMappingResponse_userMappings;
        
			return listAccountMappingResponse;
        }
    }
}
