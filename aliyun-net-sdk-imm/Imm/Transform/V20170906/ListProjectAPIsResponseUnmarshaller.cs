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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListProjectAPIsResponseUnmarshaller
    {
        public static ListProjectAPIsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectAPIsResponse listProjectAPIsResponse = new ListProjectAPIsResponse();

			listProjectAPIsResponse.HttpResponse = context.HttpResponse;
			listProjectAPIsResponse.RequestId = context.StringValue("ListProjectAPIs.RequestId");
			listProjectAPIsResponse.Project = context.StringValue("ListProjectAPIs.Project");

			List<string> listProjectAPIsResponse_aPIs = new List<string>();
			for (int i = 0; i < context.Length("ListProjectAPIs.APIs.Length"); i++) {
				listProjectAPIsResponse_aPIs.Add(context.StringValue("ListProjectAPIs.APIs["+ i +"]"));
			}
			listProjectAPIsResponse.APIs = listProjectAPIsResponse_aPIs;
        
			return listProjectAPIsResponse;
        }
    }
}
