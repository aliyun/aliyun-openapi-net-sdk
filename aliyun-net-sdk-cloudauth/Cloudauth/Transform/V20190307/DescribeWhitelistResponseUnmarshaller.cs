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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeWhitelistResponseUnmarshaller
    {
        public static DescribeWhitelistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWhitelistResponse describeWhitelistResponse = new DescribeWhitelistResponse();

			describeWhitelistResponse.HttpResponse = _ctx.HttpResponse;
			describeWhitelistResponse.RequestId = _ctx.StringValue("DescribeWhitelist.RequestId");
			describeWhitelistResponse.TotalCount = _ctx.IntegerValue("DescribeWhitelist.TotalCount");
			describeWhitelistResponse.CurrentPage = _ctx.IntegerValue("DescribeWhitelist.CurrentPage");
			describeWhitelistResponse.PageSize = _ctx.IntegerValue("DescribeWhitelist.PageSize");

			List<DescribeWhitelistResponse.DescribeWhitelist_Item> describeWhitelistResponse_items = new List<DescribeWhitelistResponse.DescribeWhitelist_Item>();
			for (int i = 0; i < _ctx.Length("DescribeWhitelist.Items.Length"); i++) {
				DescribeWhitelistResponse.DescribeWhitelist_Item item = new DescribeWhitelistResponse.DescribeWhitelist_Item();
				item.Id = _ctx.LongValue("DescribeWhitelist.Items["+ i +"].Id");
				item.Uid = _ctx.LongValue("DescribeWhitelist.Items["+ i +"].Uid");
				item.BizType = _ctx.StringValue("DescribeWhitelist.Items["+ i +"].BizType");
				item.StartDate = _ctx.LongValue("DescribeWhitelist.Items["+ i +"].StartDate");
				item.EndDate = _ctx.LongValue("DescribeWhitelist.Items["+ i +"].EndDate");
				item.IdCardNum = _ctx.StringValue("DescribeWhitelist.Items["+ i +"].IdCardNum");
				item.BizId = _ctx.StringValue("DescribeWhitelist.Items["+ i +"].BizId");
				item.Valid = _ctx.IntegerValue("DescribeWhitelist.Items["+ i +"].Valid");
				item.GmtCreate = _ctx.LongValue("DescribeWhitelist.Items["+ i +"].GmtCreate");
				item.GmtModified = _ctx.LongValue("DescribeWhitelist.Items["+ i +"].GmtModified");

				describeWhitelistResponse_items.Add(item);
			}
			describeWhitelistResponse.Items = describeWhitelistResponse_items;
        
			return describeWhitelistResponse;
        }
    }
}
