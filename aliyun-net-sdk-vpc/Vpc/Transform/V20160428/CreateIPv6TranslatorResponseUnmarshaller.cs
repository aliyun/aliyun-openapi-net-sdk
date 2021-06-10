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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class CreateIPv6TranslatorResponseUnmarshaller
    {
        public static CreateIPv6TranslatorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateIPv6TranslatorResponse createIPv6TranslatorResponse = new CreateIPv6TranslatorResponse();

			createIPv6TranslatorResponse.HttpResponse = _ctx.HttpResponse;
			createIPv6TranslatorResponse.RequestId = _ctx.StringValue("CreateIPv6Translator.RequestId");
			createIPv6TranslatorResponse.Ipv6TranslatorId = _ctx.StringValue("CreateIPv6Translator.Ipv6TranslatorId");
			createIPv6TranslatorResponse.Name = _ctx.StringValue("CreateIPv6Translator.Name");
			createIPv6TranslatorResponse.Spec = _ctx.StringValue("CreateIPv6Translator.Spec");
			createIPv6TranslatorResponse.OrderId = _ctx.LongValue("CreateIPv6Translator.OrderId");
        
			return createIPv6TranslatorResponse;
        }
    }
}
