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
using Aliyun.Acs.Push.Model.V20150827;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20150827
{
    public class QueryMessageCountResponseUnmarshaller
    {
        public static QueryMessageCountResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMessageCountResponse queryMessageCountResponse = new QueryMessageCountResponse();

			queryMessageCountResponse.HttpResponse = context.HttpResponse;
			queryMessageCountResponse.RequestId = context.StringValue("QueryMessageCount.RequestId");

			List<QueryMessageCountResponse.BillInfo> billInfos = new List<QueryMessageCountResponse.BillInfo>();
			for (int i = 0; i < context.Length("QueryMessageCount.BillInfos.Length"); i++) {
				QueryMessageCountResponse.BillInfo billInfo = new QueryMessageCountResponse.BillInfo();
				billInfo.Date = context.StringValue("QueryMessageCount.BillInfos["+ i +"].Date");
				billInfo.Count = context.IntegerValue("QueryMessageCount.BillInfos["+ i +"].Count");

				billInfos.Add(billInfo);
			}
			queryMessageCountResponse.BillInfos = billInfos;
        
			return queryMessageCountResponse;
        }
    }
}