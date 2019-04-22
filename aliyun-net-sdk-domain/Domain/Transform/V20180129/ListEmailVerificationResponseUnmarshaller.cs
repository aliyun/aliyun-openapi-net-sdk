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
    public class ListEmailVerificationResponseUnmarshaller
    {
        public static ListEmailVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			ListEmailVerificationResponse listEmailVerificationResponse = new ListEmailVerificationResponse();

			listEmailVerificationResponse.HttpResponse = context.HttpResponse;
			listEmailVerificationResponse.RequestId = context.StringValue("ListEmailVerification.RequestId");
			listEmailVerificationResponse.TotalItemNum = context.IntegerValue("ListEmailVerification.TotalItemNum");
			listEmailVerificationResponse.CurrentPageNum = context.IntegerValue("ListEmailVerification.CurrentPageNum");
			listEmailVerificationResponse.TotalPageNum = context.IntegerValue("ListEmailVerification.TotalPageNum");
			listEmailVerificationResponse.PageSize = context.IntegerValue("ListEmailVerification.PageSize");
			listEmailVerificationResponse.PrePage = context.BooleanValue("ListEmailVerification.PrePage");
			listEmailVerificationResponse.NextPage = context.BooleanValue("ListEmailVerification.NextPage");

			List<ListEmailVerificationResponse.ListEmailVerification_EmailVerification> listEmailVerificationResponse_data = new List<ListEmailVerificationResponse.ListEmailVerification_EmailVerification>();
			for (int i = 0; i < context.Length("ListEmailVerification.Data.Length"); i++) {
				ListEmailVerificationResponse.ListEmailVerification_EmailVerification emailVerification = new ListEmailVerificationResponse.ListEmailVerification_EmailVerification();
				emailVerification.GmtCreate = context.StringValue("ListEmailVerification.Data["+ i +"].GmtCreate");
				emailVerification.GmtModified = context.StringValue("ListEmailVerification.Data["+ i +"].GmtModified");
				emailVerification.Email = context.StringValue("ListEmailVerification.Data["+ i +"].Email");
				emailVerification.UserId = context.StringValue("ListEmailVerification.Data["+ i +"].UserId");
				emailVerification.EmailVerificationNo = context.StringValue("ListEmailVerification.Data["+ i +"].EmailVerificationNo");
				emailVerification.TokenSendTime = context.StringValue("ListEmailVerification.Data["+ i +"].TokenSendTime");
				emailVerification.VerificationStatus = context.IntegerValue("ListEmailVerification.Data["+ i +"].VerificationStatus");
				emailVerification.VerificationTime = context.StringValue("ListEmailVerification.Data["+ i +"].VerificationTime");
				emailVerification.SendIp = context.StringValue("ListEmailVerification.Data["+ i +"].SendIp");
				emailVerification.ConfirmIp = context.StringValue("ListEmailVerification.Data["+ i +"].ConfirmIp");

				listEmailVerificationResponse_data.Add(emailVerification);
			}
			listEmailVerificationResponse.Data = listEmailVerificationResponse_data;
        
			return listEmailVerificationResponse;
        }
    }
}
