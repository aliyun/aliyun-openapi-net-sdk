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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribePropertyUserItemResponseUnmarshaller
    {
        public static DescribePropertyUserItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyUserItemResponse describePropertyUserItemResponse = new DescribePropertyUserItemResponse();

			describePropertyUserItemResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyUserItemResponse.RequestId = _ctx.StringValue("DescribePropertyUserItem.RequestId");

			DescribePropertyUserItemResponse.DescribePropertyUserItem_PageInfo pageInfo = new DescribePropertyUserItemResponse.DescribePropertyUserItem_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyUserItem.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyUserItem.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyUserItem.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyUserItem.PageInfo.CurrentPage");
			describePropertyUserItemResponse.PageInfo = pageInfo;

			List<DescribePropertyUserItemResponse.DescribePropertyUserItem_PropertyUserItem> describePropertyUserItemResponse_propertyItems = new List<DescribePropertyUserItemResponse.DescribePropertyUserItem_PropertyUserItem>();
			for (int i = 0; i < _ctx.Length("DescribePropertyUserItem.PropertyItems.Length"); i++) {
				DescribePropertyUserItemResponse.DescribePropertyUserItem_PropertyUserItem propertyUserItem = new DescribePropertyUserItemResponse.DescribePropertyUserItem_PropertyUserItem();
				propertyUserItem.User = _ctx.StringValue("DescribePropertyUserItem.PropertyItems["+ i +"].User");
				propertyUserItem.Count = _ctx.IntegerValue("DescribePropertyUserItem.PropertyItems["+ i +"].Count");

				describePropertyUserItemResponse_propertyItems.Add(propertyUserItem);
			}
			describePropertyUserItemResponse.PropertyItems = describePropertyUserItemResponse_propertyItems;
        
			return describePropertyUserItemResponse;
        }
    }
}
