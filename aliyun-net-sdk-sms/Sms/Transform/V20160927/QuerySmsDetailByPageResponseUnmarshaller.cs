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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sms.Transform.V20160927
{
    public class QuerySmsDetailByPageResponseUnmarshaller
    {
        public static QuerySmsDetailByPageResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySmsDetailByPageResponse querySmsDetailByPageResponse = new QuerySmsDetailByPageResponse();

			querySmsDetailByPageResponse.HttpResponse = context.HttpResponse;
			querySmsDetailByPageResponse.RequestId = context.StringValue("QuerySmsDetailByPage.RequestId");
			querySmsDetailByPageResponse.PageNumber = context.IntegerValue("QuerySmsDetailByPage.PageNumber");
			querySmsDetailByPageResponse.PageSize = context.IntegerValue("QuerySmsDetailByPage.PageSize");
			querySmsDetailByPageResponse.TotalCount = context.IntegerValue("QuerySmsDetailByPage.TotalCount");

			List<QuerySmsDetailByPageResponse.stat> data = new List<QuerySmsDetailByPageResponse.stat>();
			for (int i = 0; i < context.Length("QuerySmsDetailByPage.data.Length"); i++) {
				QuerySmsDetailByPageResponse.stat stat = new QuerySmsDetailByPageResponse.stat();
				stat.ReceiverNum = context.StringValue("QuerySmsDetailByPage.data["+ i +"].ReceiverNum");
				stat.SmsCode = context.StringValue("QuerySmsDetailByPage.data["+ i +"].SmsCode");
				stat.SmsContent = context.StringValue("QuerySmsDetailByPage.data["+ i +"].SmsContent");
				stat.SmsStatus = context.IntegerValue("QuerySmsDetailByPage.data["+ i +"].SmsStatus");
				stat.ResultCode = context.StringValue("QuerySmsDetailByPage.data["+ i +"].ResultCode");

				data.Add(stat);
			}
			querySmsDetailByPageResponse.Data = data;
        
			return querySmsDetailByPageResponse;
        }
    }
}