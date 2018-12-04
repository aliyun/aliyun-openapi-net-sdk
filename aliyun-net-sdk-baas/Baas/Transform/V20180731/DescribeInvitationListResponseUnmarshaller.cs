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
    public class DescribeInvitationListResponseUnmarshaller
    {
        public static DescribeInvitationListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInvitationListResponse describeInvitationListResponse = new DescribeInvitationListResponse();

			describeInvitationListResponse.HttpResponse = context.HttpResponse;
			describeInvitationListResponse.RequestId = context.StringValue("DescribeInvitationList.RequestId");
			describeInvitationListResponse.Success = context.BooleanValue("DescribeInvitationList.Success");
			describeInvitationListResponse.ErrorCode = context.IntegerValue("DescribeInvitationList.ErrorCode");

			List<DescribeInvitationListResponse.DescribeInvitationList_InvitationList> describeInvitationListResponse_result = new List<DescribeInvitationListResponse.DescribeInvitationList_InvitationList>();
			for (int i = 0; i < context.Length("DescribeInvitationList.Result.Length"); i++) {
				DescribeInvitationListResponse.DescribeInvitationList_InvitationList invitationList = new DescribeInvitationListResponse.DescribeInvitationList_InvitationList();
				invitationList.Code = context.StringValue("DescribeInvitationList.Result["+ i +"].Code");
				invitationList.SendTime = context.StringValue("DescribeInvitationList.Result["+ i +"].SendTime");
				invitationList.ConsortiumId = context.StringValue("DescribeInvitationList.Result["+ i +"].ConsortiumId");
				invitationList.ExpireTime = context.StringValue("DescribeInvitationList.Result["+ i +"].ExpireTime");
				invitationList.Email = context.StringValue("DescribeInvitationList.Result["+ i +"].Email");

				describeInvitationListResponse_result.Add(invitationList);
			}
			describeInvitationListResponse.Result = describeInvitationListResponse_result;
        
			return describeInvitationListResponse;
        }
    }
}