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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class CreateCubeBySqlResponseUnmarshaller
    {
        public static CreateCubeBySqlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateCubeBySqlResponse createCubeBySqlResponse = new CreateCubeBySqlResponse();

			createCubeBySqlResponse.HttpResponse = _ctx.HttpResponse;
			createCubeBySqlResponse.RequestId = _ctx.StringValue("CreateCubeBySql.RequestId");
			createCubeBySqlResponse.Result = _ctx.StringValue("CreateCubeBySql.Result");
			createCubeBySqlResponse.Success = _ctx.BooleanValue("CreateCubeBySql.Success");
        
			return createCubeBySqlResponse;
        }
    }
}
