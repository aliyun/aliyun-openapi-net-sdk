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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class CreateAliDnsRecordIdResponseUnmarshaller
    {
        public static CreateAliDnsRecordIdResponse Unmarshall(UnmarshallerContext context)
        {
			CreateAliDnsRecordIdResponse createAliDnsRecordIdResponse = new CreateAliDnsRecordIdResponse();

			createAliDnsRecordIdResponse.HttpResponse = context.HttpResponse;
			createAliDnsRecordIdResponse.RequestId = context.StringValue("CreateAliDnsRecordId.RequestId");
        
			return createAliDnsRecordIdResponse;
        }
    }
}
