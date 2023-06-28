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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ModifyMemberResponseUnmarshaller
    {
        public static ModifyMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyMemberResponse modifyMemberResponse = new ModifyMemberResponse();

			modifyMemberResponse.HttpResponse = _ctx.HttpResponse;
			modifyMemberResponse.Code = _ctx.IntegerValue("ModifyMember.Code");
			modifyMemberResponse.Message = _ctx.StringValue("ModifyMember.Message");
			modifyMemberResponse.Data = _ctx.StringValue("ModifyMember.Data");
			modifyMemberResponse.RequestId = _ctx.StringValue("ModifyMember.RequestId");
			modifyMemberResponse.Success = _ctx.BooleanValue("ModifyMember.Success");
        
			return modifyMemberResponse;
        }
    }
}
