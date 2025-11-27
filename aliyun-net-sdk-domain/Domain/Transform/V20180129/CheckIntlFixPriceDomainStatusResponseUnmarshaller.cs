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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class CheckIntlFixPriceDomainStatusResponseUnmarshaller
    {
        public static CheckIntlFixPriceDomainStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckIntlFixPriceDomainStatusResponse checkIntlFixPriceDomainStatusResponse = new CheckIntlFixPriceDomainStatusResponse();

			checkIntlFixPriceDomainStatusResponse.HttpResponse = _ctx.HttpResponse;
			checkIntlFixPriceDomainStatusResponse.RequestId = _ctx.StringValue("CheckIntlFixPriceDomainStatus.RequestId");

			CheckIntlFixPriceDomainStatusResponse.CheckIntlFixPriceDomainStatus_Module module = new CheckIntlFixPriceDomainStatusResponse.CheckIntlFixPriceDomainStatus_Module();
			module.Domain = _ctx.StringValue("CheckIntlFixPriceDomainStatus.Module.Domain");
			module.Price = _ctx.LongValue("CheckIntlFixPriceDomainStatus.Module.Price");
			module.Currency = _ctx.StringValue("CheckIntlFixPriceDomainStatus.Module.Currency");
			module.RegDate = _ctx.LongValue("CheckIntlFixPriceDomainStatus.Module.RegDate");
			module.DeadDate = _ctx.LongValue("CheckIntlFixPriceDomainStatus.Module.DeadDate");
			module.EndTime = _ctx.LongValue("CheckIntlFixPriceDomainStatus.Module.EndTime");
			module.Premium = _ctx.BooleanValue("CheckIntlFixPriceDomainStatus.Module.Premium");
			checkIntlFixPriceDomainStatusResponse.Module = module;
        
			return checkIntlFixPriceDomainStatusResponse;
        }
    }
}
