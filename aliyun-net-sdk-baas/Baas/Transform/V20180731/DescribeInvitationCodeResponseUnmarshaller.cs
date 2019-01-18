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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeInvitationCodeResponseUnmarshaller
    {
        public static DescribeInvitationCodeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInvitationCodeResponse describeInvitationCodeResponse = new DescribeInvitationCodeResponse();

			describeInvitationCodeResponse.HttpResponse = context.HttpResponse;
			describeInvitationCodeResponse.RequestId = context.StringValue("DescribeInvitationCode.RequestId");
			describeInvitationCodeResponse.Success = context.BooleanValue("DescribeInvitationCode.Success");
			describeInvitationCodeResponse.ErrorCode = context.IntegerValue("DescribeInvitationCode.ErrorCode");
			describeInvitationCodeResponse.DynamicCode = context.StringValue("DescribeInvitationCode.DynamicCode");
			describeInvitationCodeResponse.DynamicMessage = context.StringValue("DescribeInvitationCode.DynamicMessage");

			DescribeInvitationCodeResponse.DescribeInvitationCode_Result result = new DescribeInvitationCodeResponse.DescribeInvitationCode_Result();
			result.Id = context.IntegerValue("DescribeInvitationCode.Result.Id");
			result.Code = context.StringValue("DescribeInvitationCode.Result.Code");
			result.SendTime = context.StringValue("DescribeInvitationCode.Result.SendTime");
			result.SenderId = context.LongValue("DescribeInvitationCode.Result.SenderId");
			result.SenderBid = context.StringValue("DescribeInvitationCode.Result.SenderBid");
			result.ConsortiumId = context.StringValue("DescribeInvitationCode.Result.ConsortiumId");
			result.SenderName = context.StringValue("DescribeInvitationCode.Result.SenderName");
			result.Accepted = context.BooleanValue("DescribeInvitationCode.Result.Accepted");
			result.ExpireTime = context.StringValue("DescribeInvitationCode.Result.ExpireTime");
			result.Email = context.StringValue("DescribeInvitationCode.Result.Email");
			result.Url = context.StringValue("DescribeInvitationCode.Result.Url");
			describeInvitationCodeResponse.Result = result;
        
			return describeInvitationCodeResponse;
        }
    }
}