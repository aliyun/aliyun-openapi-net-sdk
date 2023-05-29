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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeProjectMessagesResponseUnmarshaller
    {
        public static DescribeProjectMessagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProjectMessagesResponse describeProjectMessagesResponse = new DescribeProjectMessagesResponse();

			describeProjectMessagesResponse.HttpResponse = _ctx.HttpResponse;
			describeProjectMessagesResponse.RequestId = _ctx.StringValue("DescribeProjectMessages.RequestId");
			describeProjectMessagesResponse.TotalCount = _ctx.LongValue("DescribeProjectMessages.TotalCount");
			describeProjectMessagesResponse.Success = _ctx.BooleanValue("DescribeProjectMessages.Success");

			List<DescribeProjectMessagesResponse.DescribeProjectMessages_ProjectMessage> describeProjectMessagesResponse_result = new List<DescribeProjectMessagesResponse.DescribeProjectMessages_ProjectMessage>();
			for (int i = 0; i < _ctx.Length("DescribeProjectMessages.Result.Length"); i++) {
				DescribeProjectMessagesResponse.DescribeProjectMessages_ProjectMessage projectMessage = new DescribeProjectMessagesResponse.DescribeProjectMessages_ProjectMessage();
				projectMessage.GmtCreate = _ctx.LongValue("DescribeProjectMessages.Result["+ i +"].GmtCreate");
				projectMessage._Operator = _ctx.LongValue("DescribeProjectMessages.Result["+ i +"].Operator");
				projectMessage.OperatorRole = _ctx.StringValue("DescribeProjectMessages.Result["+ i +"].OperatorRole");
				projectMessage.Content = _ctx.StringValue("DescribeProjectMessages.Result["+ i +"].Content");
				projectMessage.OperatorName = _ctx.StringValue("DescribeProjectMessages.Result["+ i +"].OperatorName");

				describeProjectMessagesResponse_result.Add(projectMessage);
			}
			describeProjectMessagesResponse.Result = describeProjectMessagesResponse_result;
        
			return describeProjectMessagesResponse;
        }
    }
}
