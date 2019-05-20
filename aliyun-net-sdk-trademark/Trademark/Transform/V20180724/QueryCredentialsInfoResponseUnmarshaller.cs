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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryCredentialsInfoResponseUnmarshaller
    {
        public static QueryCredentialsInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCredentialsInfoResponse queryCredentialsInfoResponse = new QueryCredentialsInfoResponse();

			queryCredentialsInfoResponse.HttpResponse = context.HttpResponse;
			queryCredentialsInfoResponse.RequestId = context.StringValue("QueryCredentialsInfo.RequestId");

			QueryCredentialsInfoResponse.QueryCredentialsInfo_CredentialsInfo credentialsInfo = new QueryCredentialsInfoResponse.QueryCredentialsInfo_CredentialsInfo();
			credentialsInfo.CardNumber = context.StringValue("QueryCredentialsInfo.CredentialsInfo.CardNumber");
			credentialsInfo.Address = context.StringValue("QueryCredentialsInfo.CredentialsInfo.Address");
			credentialsInfo.CompanyName = context.StringValue("QueryCredentialsInfo.CredentialsInfo.CompanyName");
			credentialsInfo.PersonName = context.StringValue("QueryCredentialsInfo.CredentialsInfo.PersonName");
			credentialsInfo.Province = context.StringValue("QueryCredentialsInfo.CredentialsInfo.Province");
			queryCredentialsInfoResponse.CredentialsInfo = credentialsInfo;
        
			return queryCredentialsInfoResponse;
        }
    }
}
