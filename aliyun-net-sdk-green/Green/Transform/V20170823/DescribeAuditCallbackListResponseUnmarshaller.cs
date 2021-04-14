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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeAuditCallbackListResponseUnmarshaller
    {
        public static DescribeAuditCallbackListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAuditCallbackListResponse describeAuditCallbackListResponse = new DescribeAuditCallbackListResponse();

			describeAuditCallbackListResponse.HttpResponse = _ctx.HttpResponse;
			describeAuditCallbackListResponse.RequestId = _ctx.StringValue("DescribeAuditCallbackList.RequestId");
			describeAuditCallbackListResponse.TotalCount = _ctx.IntegerValue("DescribeAuditCallbackList.TotalCount");

			List<DescribeAuditCallbackListResponse.DescribeAuditCallbackList_Callback> describeAuditCallbackListResponse_callbackList = new List<DescribeAuditCallbackListResponse.DescribeAuditCallbackList_Callback>();
			for (int i = 0; i < _ctx.Length("DescribeAuditCallbackList.CallbackList.Length"); i++) {
				DescribeAuditCallbackListResponse.DescribeAuditCallbackList_Callback callback = new DescribeAuditCallbackListResponse.DescribeAuditCallbackList_Callback();
				callback.Id = _ctx.LongValue("DescribeAuditCallbackList.CallbackList["+ i +"].Id");
				callback.Name = _ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].Name");
				callback.Url = _ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].Url");
				callback.Seed = _ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].Seed");
				callback.CryptType = _ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].CryptType");
				callback.CreateTime = _ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].CreateTime");
				callback.ModifiedTime = _ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].ModifiedTime");

				List<string> callback_callbackTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAuditCallbackList.CallbackList["+ i +"].CallbackTypes.Length"); j++) {
					callback_callbackTypes.Add(_ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].CallbackTypes["+ j +"]"));
				}
				callback.CallbackTypes = callback_callbackTypes;

				List<string> callback_callbackSuggestions = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAuditCallbackList.CallbackList["+ i +"].CallbackSuggestions.Length"); j++) {
					callback_callbackSuggestions.Add(_ctx.StringValue("DescribeAuditCallbackList.CallbackList["+ i +"].CallbackSuggestions["+ j +"]"));
				}
				callback.CallbackSuggestions = callback_callbackSuggestions;

				describeAuditCallbackListResponse_callbackList.Add(callback);
			}
			describeAuditCallbackListResponse.CallbackList = describeAuditCallbackListResponse_callbackList;
        
			return describeAuditCallbackListResponse;
        }
    }
}
