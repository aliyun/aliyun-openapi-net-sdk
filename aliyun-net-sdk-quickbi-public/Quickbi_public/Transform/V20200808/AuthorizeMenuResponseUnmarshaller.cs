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
using Aliyun.Acs.quickbi_public.Model.V20200808;

namespace Aliyun.Acs.quickbi_public.Transform.V20200808
{
    public class AuthorizeMenuResponseUnmarshaller
    {
        public static AuthorizeMenuResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AuthorizeMenuResponse authorizeMenuResponse = new AuthorizeMenuResponse();

			authorizeMenuResponse.HttpResponse = _ctx.HttpResponse;
			authorizeMenuResponse.RequestId = _ctx.StringValue("AuthorizeMenu.RequestId");
			authorizeMenuResponse.Result = _ctx.IntegerValue("AuthorizeMenu.Result");
			authorizeMenuResponse.Success = _ctx.BooleanValue("AuthorizeMenu.Success");
        
			return authorizeMenuResponse;
        }
    }
}
