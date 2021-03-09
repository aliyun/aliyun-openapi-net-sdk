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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class CreateFaultResponseUnmarshaller
    {
        public static CreateFaultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFaultResponse createFaultResponse = new CreateFaultResponse();

			createFaultResponse.HttpResponse = _ctx.HttpResponse;
			createFaultResponse.RequestId = _ctx.StringValue("CreateFault.RequestId");
			createFaultResponse.Success = _ctx.BooleanValue("CreateFault.Success");
			createFaultResponse.Code = _ctx.StringValue("CreateFault.Code");
			createFaultResponse.Message = _ctx.StringValue("CreateFault.Message");
			createFaultResponse.HttpStatusCode = _ctx.IntegerValue("CreateFault.HttpStatusCode");
        
			return createFaultResponse;
        }
    }
}
