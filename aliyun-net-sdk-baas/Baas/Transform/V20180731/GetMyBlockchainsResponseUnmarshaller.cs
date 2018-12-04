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
    public class GetMyBlockchainsResponseUnmarshaller
    {
        public static GetMyBlockchainsResponse Unmarshall(UnmarshallerContext context)
        {
			GetMyBlockchainsResponse getMyBlockchainsResponse = new GetMyBlockchainsResponse();

			getMyBlockchainsResponse.HttpResponse = context.HttpResponse;
			getMyBlockchainsResponse.RequestId = context.StringValue("GetMyBlockchains.RequestId");

			List<GetMyBlockchainsResponse.GetMyBlockchains_ResultItem> getMyBlockchainsResponse_result = new List<GetMyBlockchainsResponse.GetMyBlockchains_ResultItem>();
			for (int i = 0; i < context.Length("GetMyBlockchains.Result.Length"); i++) {
				GetMyBlockchainsResponse.GetMyBlockchains_ResultItem resultItem = new GetMyBlockchainsResponse.GetMyBlockchains_ResultItem();
				resultItem.Id = context.IntegerValue("GetMyBlockchains.Result["+ i +"].Id");
				resultItem.Bizid = context.StringValue("GetMyBlockchains.Result["+ i +"].Bizid");
				resultItem.Username = context.StringValue("GetMyBlockchains.Result["+ i +"].Username");
				resultItem.ReqAddr = context.StringValue("GetMyBlockchains.Result["+ i +"].ReqAddr");
				resultItem.SignedAddr = context.StringValue("GetMyBlockchains.Result["+ i +"].SignedAddr");
				resultItem.Status = context.IntegerValue("GetMyBlockchains.Result["+ i +"].Status");
				resultItem.RejectReason = context.StringValue("GetMyBlockchains.Result["+ i +"].RejectReason");
				resultItem.Createtime = context.LongValue("GetMyBlockchains.Result["+ i +"].Createtime");
				resultItem.Updatetime = context.LongValue("GetMyBlockchains.Result["+ i +"].Updatetime");

				getMyBlockchainsResponse_result.Add(resultItem);
			}
			getMyBlockchainsResponse.Result = getMyBlockchainsResponse_result;
        
			return getMyBlockchainsResponse;
        }
    }
}