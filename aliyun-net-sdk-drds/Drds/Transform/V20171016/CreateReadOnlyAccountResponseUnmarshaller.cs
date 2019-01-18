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
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class CreateReadOnlyAccountResponseUnmarshaller
    {
        public static CreateReadOnlyAccountResponse Unmarshall(UnmarshallerContext context)
        {
			CreateReadOnlyAccountResponse createReadOnlyAccountResponse = new CreateReadOnlyAccountResponse();

			createReadOnlyAccountResponse.HttpResponse = context.HttpResponse;
			createReadOnlyAccountResponse.RequestId = context.StringValue("CreateReadOnlyAccount.RequestId");
			createReadOnlyAccountResponse.Success = context.BooleanValue("CreateReadOnlyAccount.Success");

			CreateReadOnlyAccountResponse.CreateReadOnlyAccount_Data data = new CreateReadOnlyAccountResponse.CreateReadOnlyAccount_Data();
			data.DbName = context.StringValue("CreateReadOnlyAccount.Data.DbName");
			data.DrdsInstanceId = context.StringValue("CreateReadOnlyAccount.Data.DrdsInstanceId");
			data.AccountName = context.StringValue("CreateReadOnlyAccount.Data.AccountName");
			createReadOnlyAccountResponse.Data = data;
        
			return createReadOnlyAccountResponse;
        }
    }
}