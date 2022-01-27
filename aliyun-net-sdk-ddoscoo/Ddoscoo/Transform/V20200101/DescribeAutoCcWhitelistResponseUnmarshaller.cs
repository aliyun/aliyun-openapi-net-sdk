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
    public class DescribeAutoCcWhitelistResponseUnmarshaller
    {
        public static DescribeAutoCcWhitelistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoCcWhitelistResponse describeAutoCcWhitelistResponse = new DescribeAutoCcWhitelistResponse();

			describeAutoCcWhitelistResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoCcWhitelistResponse.RequestId = _ctx.StringValue("DescribeAutoCcWhitelist.RequestId");
			describeAutoCcWhitelistResponse.TotalCount = _ctx.LongValue("DescribeAutoCcWhitelist.TotalCount");

			List<DescribeAutoCcWhitelistResponse.DescribeAutoCcWhitelist_AutoCcWhitelistItem> describeAutoCcWhitelistResponse_autoCcWhitelist = new List<DescribeAutoCcWhitelistResponse.DescribeAutoCcWhitelist_AutoCcWhitelistItem>();
			for (int i = 0; i < _ctx.Length("DescribeAutoCcWhitelist.AutoCcWhitelist.Length"); i++) {
				DescribeAutoCcWhitelistResponse.DescribeAutoCcWhitelist_AutoCcWhitelistItem autoCcWhitelistItem = new DescribeAutoCcWhitelistResponse.DescribeAutoCcWhitelist_AutoCcWhitelistItem();
				autoCcWhitelistItem.DestIp = _ctx.StringValue("DescribeAutoCcWhitelist.AutoCcWhitelist["+ i +"].DestIp");
				autoCcWhitelistItem.SourceIp = _ctx.StringValue("DescribeAutoCcWhitelist.AutoCcWhitelist["+ i +"].SourceIp");
				autoCcWhitelistItem.EndTime = _ctx.LongValue("DescribeAutoCcWhitelist.AutoCcWhitelist["+ i +"].EndTime");
				autoCcWhitelistItem.Type = _ctx.StringValue("DescribeAutoCcWhitelist.AutoCcWhitelist["+ i +"].Type");

				describeAutoCcWhitelistResponse_autoCcWhitelist.Add(autoCcWhitelistItem);
			}
			describeAutoCcWhitelistResponse.AutoCcWhitelist = describeAutoCcWhitelistResponse_autoCcWhitelist;
        
			return describeAutoCcWhitelistResponse;
        }
    }
}
