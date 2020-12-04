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
        public static ListEmailVerificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmailVerificationResponse listEmailVerificationResponse = new ListEmailVerificationResponse();

			listEmailVerificationResponse.HttpResponse = _ctx.HttpResponse;
			listEmailVerificationResponse.RequestId = _ctx.StringValue("ListEmailVerification.RequestId");
			listEmailVerificationResponse.TotalItemNum = _ctx.IntegerValue("ListEmailVerification.TotalItemNum");
			listEmailVerificationResponse.CurrentPageNum = _ctx.IntegerValue("ListEmailVerification.CurrentPageNum");
			listEmailVerificationResponse.TotalPageNum = _ctx.IntegerValue("ListEmailVerification.TotalPageNum");
			listEmailVerificationResponse.PageSize = _ctx.IntegerValue("ListEmailVerification.PageSize");
			listEmailVerificationResponse.PrePage = _ctx.BooleanValue("ListEmailVerification.PrePage");
			listEmailVerificationResponse.NextPage = _ctx.BooleanValue("ListEmailVerification.NextPage");

			List<ListEmailVerificationResponse.ListEmailVerification_EmailVerification> listEmailVerificationResponse_data = new List<ListEmailVerificationResponse.ListEmailVerification_EmailVerification>();
			for (int i = 0; i < _ctx.Length("ListEmailVerification.Data.Length"); i++) {
				ListEmailVerificationResponse.ListEmailVerification_EmailVerification emailVerification = new ListEmailVerificationResponse.ListEmailVerification_EmailVerification();
				emailVerification.GmtCreate = _ctx.StringValue("ListEmailVerification.Data["+ i +"].GmtCreate");
				emailVerification.GmtModified = _ctx.StringValue("ListEmailVerification.Data["+ i +"].GmtModified");
				emailVerification.Email = _ctx.StringValue("ListEmailVerification.Data["+ i +"].Email");
				emailVerification.UserId = _ctx.StringValue("ListEmailVerification.Data["+ i +"].UserId");
				emailVerification.EmailVerificationNo = _ctx.StringValue("ListEmailVerification.Data["+ i +"].EmailVerificationNo");
				emailVerification.TokenSendTime = _ctx.StringValue("ListEmailVerification.Data["+ i +"].TokenSendTime");
				emailVerification.VerificationStatus = _ctx.IntegerValue("ListEmailVerification.Data["+ i +"].VerificationStatus");
				emailVerification.VerificationTime = _ctx.StringValue("ListEmailVerification.Data["+ i +"].VerificationTime");
				emailVerification.SendIp = _ctx.StringValue("ListEmailVerification.Data["+ i +"].SendIp");
				emailVerification.ConfirmIp = _ctx.StringValue("ListEmailVerification.Data["+ i +"].ConfirmIp");

				listEmailVerificationResponse_data.Add(emailVerification);
			}
			listEmailVerificationResponse.Data = listEmailVerificationResponse_data;
        
			return listEmailVerificationResponse;
        }
    }
}
