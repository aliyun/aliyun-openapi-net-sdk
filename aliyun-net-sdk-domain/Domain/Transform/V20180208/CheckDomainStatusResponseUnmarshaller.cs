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
using Aliyun.Acs.Domain.Model.V20180208;

namespace Aliyun.Acs.Domain.Transform.V20180208
{
    public class CheckDomainStatusResponseUnmarshaller
    {
        public static CheckDomainStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckDomainStatusResponse checkDomainStatusResponse = new CheckDomainStatusResponse();

			checkDomainStatusResponse.HttpResponse = _ctx.HttpResponse;
			checkDomainStatusResponse.RequestId = _ctx.StringValue("CheckDomainStatus.RequestId");
			checkDomainStatusResponse.HttpStatusCode = _ctx.IntegerValue("CheckDomainStatus.HttpStatusCode");
			checkDomainStatusResponse.ErrorCode = _ctx.StringValue("CheckDomainStatus.ErrorCode");
			checkDomainStatusResponse.Success = _ctx.BooleanValue("CheckDomainStatus.Success");

			CheckDomainStatusResponse.CheckDomainStatus_Module module = new CheckDomainStatusResponse.CheckDomainStatus_Module();
			module.Domain = _ctx.StringValue("CheckDomainStatus.Module.Domain");
			module.Price = _ctx.FloatValue("CheckDomainStatus.Module.Price");
			module.RegDate = _ctx.LongValue("CheckDomainStatus.Module.RegDate");
			module.DeadDate = _ctx.LongValue("CheckDomainStatus.Module.DeadDate");
			module.EndTime = _ctx.LongValue("CheckDomainStatus.Module.EndTime");
			checkDomainStatusResponse.Module = module;
        
			return checkDomainStatusResponse;
        }
    }
}
