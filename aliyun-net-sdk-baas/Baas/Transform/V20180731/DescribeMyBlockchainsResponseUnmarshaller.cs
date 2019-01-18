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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeMyBlockchainsResponseUnmarshaller
    {
        public static DescribeMyBlockchainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMyBlockchainsResponse describeMyBlockchainsResponse = new DescribeMyBlockchainsResponse();

			describeMyBlockchainsResponse.HttpResponse = context.HttpResponse;
			describeMyBlockchainsResponse.RequestId = context.StringValue("DescribeMyBlockchains.RequestId");

			List<DescribeMyBlockchainsResponse.DescribeMyBlockchains_ResultItem> describeMyBlockchainsResponse_result = new List<DescribeMyBlockchainsResponse.DescribeMyBlockchains_ResultItem>();
			for (int i = 0; i < context.Length("DescribeMyBlockchains.Result.Length"); i++) {
				DescribeMyBlockchainsResponse.DescribeMyBlockchains_ResultItem resultItem = new DescribeMyBlockchainsResponse.DescribeMyBlockchains_ResultItem();
				resultItem.Id = context.IntegerValue("DescribeMyBlockchains.Result["+ i +"].Id");
				resultItem.Bizid = context.StringValue("DescribeMyBlockchains.Result["+ i +"].Bizid");
				resultItem.Username = context.StringValue("DescribeMyBlockchains.Result["+ i +"].Username");
				resultItem.ReqAddr = context.StringValue("DescribeMyBlockchains.Result["+ i +"].ReqAddr");
				resultItem.SignedAddr = context.StringValue("DescribeMyBlockchains.Result["+ i +"].SignedAddr");
				resultItem.Status = context.IntegerValue("DescribeMyBlockchains.Result["+ i +"].Status");
				resultItem.RejectReason = context.StringValue("DescribeMyBlockchains.Result["+ i +"].RejectReason");
				resultItem.Createtime = context.LongValue("DescribeMyBlockchains.Result["+ i +"].Createtime");
				resultItem.Updatetime = context.LongValue("DescribeMyBlockchains.Result["+ i +"].Updatetime");

				describeMyBlockchainsResponse_result.Add(resultItem);
			}
			describeMyBlockchainsResponse.Result = describeMyBlockchainsResponse_result;
        
			return describeMyBlockchainsResponse;
        }
    }
}