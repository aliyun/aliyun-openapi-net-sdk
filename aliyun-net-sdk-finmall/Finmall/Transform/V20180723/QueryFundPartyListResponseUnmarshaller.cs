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
using Aliyun.Acs.finmall.Model.V20180723;

namespace Aliyun.Acs.finmall.Transform.V20180723
{
    public class QueryFundPartyListResponseUnmarshaller
    {
        public static QueryFundPartyListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFundPartyListResponse queryFundPartyListResponse = new QueryFundPartyListResponse();

			queryFundPartyListResponse.HttpResponse = context.HttpResponse;
			queryFundPartyListResponse.Code = context.StringValue("QueryFundPartyList.Code");
			queryFundPartyListResponse.Message = context.StringValue("QueryFundPartyList.Message");
			queryFundPartyListResponse.RequestId = context.StringValue("QueryFundPartyList.RequestId");
			queryFundPartyListResponse.Data = context.StringValue("QueryFundPartyList.Data");
        
			return queryFundPartyListResponse;
        }
    }
}
