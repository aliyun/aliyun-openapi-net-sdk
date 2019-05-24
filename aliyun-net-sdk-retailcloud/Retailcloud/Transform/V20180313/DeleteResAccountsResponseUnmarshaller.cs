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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DeleteResAccountsResponseUnmarshaller
    {
        public static DeleteResAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteResAccountsResponse deleteResAccountsResponse = new DeleteResAccountsResponse();

			deleteResAccountsResponse.HttpResponse = context.HttpResponse;
			deleteResAccountsResponse.Code = context.IntegerValue("DeleteResAccounts.Code");
			deleteResAccountsResponse.Success = context.BooleanValue("DeleteResAccounts.Success");
			deleteResAccountsResponse.RequestId = context.StringValue("DeleteResAccounts.RequestId");
			deleteResAccountsResponse.ErrMsg = context.StringValue("DeleteResAccounts.ErrMsg");
			deleteResAccountsResponse._Class = context.StringValue("DeleteResAccounts.Class");
			deleteResAccountsResponse.TransmitAliyun = context.BooleanValue("DeleteResAccounts.TransmitAliyun");

			DeleteResAccountsResponse.DeleteResAccounts_Result result = new DeleteResAccountsResponse.DeleteResAccounts_Result();
			result.RequestId = context.StringValue("DeleteResAccounts.Result.RequestId");
			result._Class = context.StringValue("DeleteResAccounts.Result.Class");
			deleteResAccountsResponse.Result = result;
        
			return deleteResAccountsResponse;
        }
    }
}
