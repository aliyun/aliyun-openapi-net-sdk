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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Sts.Model.V20150401;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sts.Transform.V20150401
{
    public class GetCallerIdentityResponseUnmarshaller
    {
        public static GetCallerIdentityResponse Unmarshall(UnmarshallerContext context)
        {
			GetCallerIdentityResponse getCallerIdentityResponse = new GetCallerIdentityResponse();

			getCallerIdentityResponse.HttpResponse = context.HttpResponse;
			getCallerIdentityResponse.AccountId = context.StringValue("GetCallerIdentity.AccountId");
			getCallerIdentityResponse.UserId = context.StringValue("GetCallerIdentity.UserId");
			getCallerIdentityResponse.Arn = context.StringValue("GetCallerIdentity.Arn");
			getCallerIdentityResponse.RequestId = context.StringValue("GetCallerIdentity.RequestId");
        
			return getCallerIdentityResponse;
        }
    }
}