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
using Aliyun.Acs.ledgerdb.Model.V20191122;

namespace Aliyun.Acs.ledgerdb.Transform.V20191122
{
    public class GetMemberResponseUnmarshaller
    {
        public static GetMemberResponse Unmarshall(UnmarshallerContext context)
        {
			GetMemberResponse getMemberResponse = new GetMemberResponse();

			getMemberResponse.HttpResponse = context.HttpResponse;
			getMemberResponse.RequestId = context.StringValue("GetMember.RequestId");
			getMemberResponse.LedgerId = context.StringValue("GetMember.LedgerId");
			getMemberResponse.MemberId = context.StringValue("GetMember.MemberId");
			getMemberResponse.AliUid = context.StringValue("GetMember.AliUid");
			getMemberResponse.KeyType = context.StringValue("GetMember.KeyType");
			getMemberResponse.PublicKey = context.StringValue("GetMember.PublicKey");
			getMemberResponse.Role = context.StringValue("GetMember.Role");
			getMemberResponse.State = context.StringValue("GetMember.State");
			getMemberResponse.CreateTime = context.LongValue("GetMember.CreateTime");
			getMemberResponse.UpdateTime = context.LongValue("GetMember.UpdateTime");
        
			return getMemberResponse;
        }
    }
}
