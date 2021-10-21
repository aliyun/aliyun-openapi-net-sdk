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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class CreateGadInstanceMemberResponseUnmarshaller
    {
        public static CreateGadInstanceMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGadInstanceMemberResponse createGadInstanceMemberResponse = new CreateGadInstanceMemberResponse();

			createGadInstanceMemberResponse.HttpResponse = _ctx.HttpResponse;
			createGadInstanceMemberResponse.RequestId = _ctx.StringValue("CreateGadInstanceMember.RequestId");

			CreateGadInstanceMemberResponse.CreateGadInstanceMember_Result result = new CreateGadInstanceMemberResponse.CreateGadInstanceMember_Result();
			result.GadInstanceName = _ctx.StringValue("CreateGadInstanceMember.Result.GadInstanceName");
			result.CreateCount = _ctx.StringValue("CreateGadInstanceMember.Result.CreateCount");
			createGadInstanceMemberResponse.Result = result;
        
			return createGadInstanceMemberResponse;
        }
    }
}
