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
using Aliyun.Acs.Sms.Model.V20160927;
using System.Collections.Generic;

namespace Aliyun.Acs.Sms.Transform.V20160927
{
    public class QuerySmsFailByPageResponseUnmarshaller
    {
        public static QuerySmsFailByPageResponse Unmarshall(UnmarshallerContext context)
        {
            QuerySmsFailByPageResponse querySmsFailByPageResponse = new QuerySmsFailByPageResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QuerySmsFailByPage.RequestId"),
                PageNumber = context.IntegerValue("QuerySmsFailByPage.PageNumber"),
                PageSize = context.IntegerValue("QuerySmsFailByPage.PageSize"),
                TotalCount = context.IntegerValue("QuerySmsFailByPage.TotalCount")
            };
            List<QuerySmsFailByPageResponse.Stat> data = new List<QuerySmsFailByPageResponse.Stat>();
			for (int i = 0; i < context.Length("QuerySmsFailByPage.data.Length"); i++) {
                QuerySmsFailByPageResponse.Stat stat = new QuerySmsFailByPageResponse.Stat()
                {
                    ReceiverNum = context.StringValue($"QuerySmsFailByPage.data[{i}].ReceiverNum"),
                    SmsCode = context.StringValue($"QuerySmsFailByPage.data[{i}].SmsCode"),
                    SmsStatus = context.IntegerValue($"QuerySmsFailByPage.data[{i}].SmsStatus"),
                    ResultCode = context.StringValue($"QuerySmsFailByPage.data[{i}].ResultCode")
                };
                data.Add(stat);
			}
			querySmsFailByPageResponse.Data = data;
        
			return querySmsFailByPageResponse;
        }
    }
}