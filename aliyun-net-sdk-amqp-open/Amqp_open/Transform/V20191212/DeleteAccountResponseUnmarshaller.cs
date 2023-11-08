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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class DeleteAccountResponseUnmarshaller
    {
        public static DeleteAccountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteAccountResponse deleteAccountResponse = new DeleteAccountResponse();

			deleteAccountResponse.HttpResponse = _ctx.HttpResponse;
			deleteAccountResponse.RequestId = _ctx.StringValue("DeleteAccount.RequestId");
			deleteAccountResponse.Code = _ctx.IntegerValue("DeleteAccount.Code");
			deleteAccountResponse.Message = _ctx.StringValue("DeleteAccount.Message");
			deleteAccountResponse.Data = _ctx.BooleanValue("DeleteAccount.Data");
			deleteAccountResponse.Success = _ctx.BooleanValue("DeleteAccount.Success");
        
			return deleteAccountResponse;
        }
    }
}
