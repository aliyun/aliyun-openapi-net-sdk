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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeAutoCcBlacklistResponseUnmarshaller
    {
        public static DescribeAutoCcBlacklistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoCcBlacklistResponse describeAutoCcBlacklistResponse = new DescribeAutoCcBlacklistResponse();

			describeAutoCcBlacklistResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoCcBlacklistResponse.RequestId = _ctx.StringValue("DescribeAutoCcBlacklist.RequestId");
			describeAutoCcBlacklistResponse.TotalCount = _ctx.LongValue("DescribeAutoCcBlacklist.TotalCount");

			List<DescribeAutoCcBlacklistResponse.DescribeAutoCcBlacklist_AutoCcBlacklistItem> describeAutoCcBlacklistResponse_autoCcBlacklist = new List<DescribeAutoCcBlacklistResponse.DescribeAutoCcBlacklist_AutoCcBlacklistItem>();
			for (int i = 0; i < _ctx.Length("DescribeAutoCcBlacklist.AutoCcBlacklist.Length"); i++) {
				DescribeAutoCcBlacklistResponse.DescribeAutoCcBlacklist_AutoCcBlacklistItem autoCcBlacklistItem = new DescribeAutoCcBlacklistResponse.DescribeAutoCcBlacklist_AutoCcBlacklistItem();
				autoCcBlacklistItem.DestIp = _ctx.StringValue("DescribeAutoCcBlacklist.AutoCcBlacklist["+ i +"].DestIp");
				autoCcBlacklistItem.SourceIp = _ctx.StringValue("DescribeAutoCcBlacklist.AutoCcBlacklist["+ i +"].SourceIp");
				autoCcBlacklistItem.EndTime = _ctx.LongValue("DescribeAutoCcBlacklist.AutoCcBlacklist["+ i +"].EndTime");
				autoCcBlacklistItem.Type = _ctx.StringValue("DescribeAutoCcBlacklist.AutoCcBlacklist["+ i +"].Type");

				describeAutoCcBlacklistResponse_autoCcBlacklist.Add(autoCcBlacklistItem);
			}
			describeAutoCcBlacklistResponse.AutoCcBlacklist = describeAutoCcBlacklistResponse_autoCcBlacklist;
        
			return describeAutoCcBlacklistResponse;
        }
    }
}
