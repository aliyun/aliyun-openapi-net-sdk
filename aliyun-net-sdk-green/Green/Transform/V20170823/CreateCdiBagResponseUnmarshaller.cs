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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class CreateCdiBagResponseUnmarshaller
    {
        public static CreateCdiBagResponse Unmarshall(UnmarshallerContext context)
        {
			CreateCdiBagResponse createCdiBagResponse = new CreateCdiBagResponse();

			createCdiBagResponse.HttpResponse = context.HttpResponse;
			createCdiBagResponse.Code = context.StringValue("CreateCdiBag.Code");
			createCdiBagResponse.Message = context.StringValue("CreateCdiBag.Message");
			createCdiBagResponse.OrderId = context.StringValue("CreateCdiBag.OrderId");
			createCdiBagResponse.RequestId = context.StringValue("CreateCdiBag.RequestId");

			List<string> createCdiBagResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("CreateCdiBag.InstanceIds.Length"); i++) {
				createCdiBagResponse_instanceIds.Add(context.StringValue("CreateCdiBag.InstanceIds["+ i +"]"));
			}
			createCdiBagResponse.InstanceIds = createCdiBagResponse_instanceIds;
        
			return createCdiBagResponse;
        }
    }
}
