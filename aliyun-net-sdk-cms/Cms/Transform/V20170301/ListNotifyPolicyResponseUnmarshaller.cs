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
using Aliyun.Acs.Cms.Model.V20170301;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20170301
{
    public class ListNotifyPolicyResponseUnmarshaller
    {
        public static ListNotifyPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			ListNotifyPolicyResponse listNotifyPolicyResponse = new ListNotifyPolicyResponse();

			listNotifyPolicyResponse.HttpResponse = context.HttpResponse;
			listNotifyPolicyResponse.Code = context.StringValue("ListNotifyPolicy.Code");
			listNotifyPolicyResponse.Message = context.StringValue("ListNotifyPolicy.Message");
			listNotifyPolicyResponse.Success = context.StringValue("ListNotifyPolicy.Success");
			listNotifyPolicyResponse.TraceId = context.StringValue("ListNotifyPolicy.TraceId");
			listNotifyPolicyResponse.Total = context.IntegerValue("ListNotifyPolicy.Total");

			List<ListNotifyPolicyResponse.ListNotifyPolicy_NotifyPolicy> listNotifyPolicyResponse_notifyPolicyList = new List<ListNotifyPolicyResponse.ListNotifyPolicy_NotifyPolicy>();
			for (int i = 0; i < context.Length("ListNotifyPolicy.NotifyPolicyList.Length"); i++) {
				ListNotifyPolicyResponse.ListNotifyPolicy_NotifyPolicy notifyPolicy = new ListNotifyPolicyResponse.ListNotifyPolicy_NotifyPolicy();
				notifyPolicy.AlertName = context.StringValue("ListNotifyPolicy.NotifyPolicyList["+ i +"].AlertName");
				notifyPolicy.Dimensions = context.StringValue("ListNotifyPolicy.NotifyPolicyList["+ i +"].Dimensions");
				notifyPolicy.Type = context.StringValue("ListNotifyPolicy.NotifyPolicyList["+ i +"].Type");
				notifyPolicy.Id = context.StringValue("ListNotifyPolicy.NotifyPolicyList["+ i +"].Id");
				notifyPolicy.StartTime = context.LongValue("ListNotifyPolicy.NotifyPolicyList["+ i +"].StartTime");
				notifyPolicy.EndTime = context.LongValue("ListNotifyPolicy.NotifyPolicyList["+ i +"].EndTime");

				listNotifyPolicyResponse_notifyPolicyList.Add(notifyPolicy);
			}
			listNotifyPolicyResponse.NotifyPolicyList = listNotifyPolicyResponse_notifyPolicyList;
        
			return listNotifyPolicyResponse;
        }
    }
}