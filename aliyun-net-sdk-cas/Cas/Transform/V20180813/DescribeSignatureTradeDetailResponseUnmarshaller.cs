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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeSignatureTradeDetailResponseUnmarshaller
    {
        public static DescribeSignatureTradeDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSignatureTradeDetailResponse describeSignatureTradeDetailResponse = new DescribeSignatureTradeDetailResponse();

			describeSignatureTradeDetailResponse.HttpResponse = context.HttpResponse;
			describeSignatureTradeDetailResponse.RequestId = context.StringValue("DescribeSignatureTradeDetail.RequestId");
			describeSignatureTradeDetailResponse.Id = context.LongValue("DescribeSignatureTradeDetail.Id");
			describeSignatureTradeDetailResponse.DocTitle = context.StringValue("DescribeSignatureTradeDetail.DocTitle");
			describeSignatureTradeDetailResponse.TransactionId = context.StringValue("DescribeSignatureTradeDetail.TransactionId");
			describeSignatureTradeDetailResponse.PeopleName = context.StringValue("DescribeSignatureTradeDetail.PeopleName");
			describeSignatureTradeDetailResponse.CreateTime = context.LongValue("DescribeSignatureTradeDetail.CreateTime");
			describeSignatureTradeDetailResponse.SignStatus = context.IntegerValue("DescribeSignatureTradeDetail.SignStatus");
			describeSignatureTradeDetailResponse.SignMode = context.IntegerValue("DescribeSignatureTradeDetail.SignMode");
			describeSignatureTradeDetailResponse.DocId = context.StringValue("DescribeSignatureTradeDetail.DocId");
			describeSignatureTradeDetailResponse.PeopleId = context.StringValue("DescribeSignatureTradeDetail.PeopleId");
			describeSignatureTradeDetailResponse.PeopleIdentity = context.StringValue("DescribeSignatureTradeDetail.PeopleIdentity");
			describeSignatureTradeDetailResponse.PeopleMobile = context.StringValue("DescribeSignatureTradeDetail.PeopleMobile");
			describeSignatureTradeDetailResponse.PeopleEmail = context.StringValue("DescribeSignatureTradeDetail.PeopleEmail");
			describeSignatureTradeDetailResponse.SignCompany = context.StringValue("DescribeSignatureTradeDetail.SignCompany");
        
			return describeSignatureTradeDetailResponse;
        }
    }
}
