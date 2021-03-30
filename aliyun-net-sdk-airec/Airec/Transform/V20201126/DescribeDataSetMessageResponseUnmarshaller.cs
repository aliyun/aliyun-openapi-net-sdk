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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeDataSetMessageResponseUnmarshaller
    {
        public static DescribeDataSetMessageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataSetMessageResponse describeDataSetMessageResponse = new DescribeDataSetMessageResponse();

			describeDataSetMessageResponse.HttpResponse = _ctx.HttpResponse;
			describeDataSetMessageResponse.Code = _ctx.StringValue("DescribeDataSetMessage.code");
			describeDataSetMessageResponse.Message = _ctx.StringValue("DescribeDataSetMessage.message");
			describeDataSetMessageResponse.RequestId = _ctx.StringValue("DescribeDataSetMessage.requestId");

			List<DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem> describeDataSetMessageResponse_result = new List<DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeDataSetMessage.Result.Length"); i++) {
				DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem resultItem = new DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem();
				resultItem.ErrorLevel = _ctx.StringValue("DescribeDataSetMessage.Result["+ i +"].errorLevel");
				resultItem.ErrorType = _ctx.StringValue("DescribeDataSetMessage.Result["+ i +"].errorType");
				resultItem.Message = _ctx.StringValue("DescribeDataSetMessage.Result["+ i +"].message");
				resultItem.Timestamp = _ctx.StringValue("DescribeDataSetMessage.Result["+ i +"].timestamp");

				describeDataSetMessageResponse_result.Add(resultItem);
			}
			describeDataSetMessageResponse.Result = describeDataSetMessageResponse_result;
        
			return describeDataSetMessageResponse;
        }
    }
}
