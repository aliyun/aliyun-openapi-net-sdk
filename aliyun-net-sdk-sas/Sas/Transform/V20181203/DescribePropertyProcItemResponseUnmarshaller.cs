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
    public class DescribePropertyProcItemResponseUnmarshaller
    {
        public static DescribePropertyProcItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyProcItemResponse describePropertyProcItemResponse = new DescribePropertyProcItemResponse();

			describePropertyProcItemResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyProcItemResponse.RequestId = _ctx.StringValue("DescribePropertyProcItem.RequestId");

			DescribePropertyProcItemResponse.DescribePropertyProcItem_PageInfo pageInfo = new DescribePropertyProcItemResponse.DescribePropertyProcItem_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyProcItem.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyProcItem.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyProcItem.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyProcItem.PageInfo.CurrentPage");
			describePropertyProcItemResponse.PageInfo = pageInfo;

			List<DescribePropertyProcItemResponse.DescribePropertyProcItem_PropertyProcItem> describePropertyProcItemResponse_propertyItems = new List<DescribePropertyProcItemResponse.DescribePropertyProcItem_PropertyProcItem>();
			for (int i = 0; i < _ctx.Length("DescribePropertyProcItem.PropertyItems.Length"); i++) {
				DescribePropertyProcItemResponse.DescribePropertyProcItem_PropertyProcItem propertyProcItem = new DescribePropertyProcItemResponse.DescribePropertyProcItem_PropertyProcItem();
				propertyProcItem.Name = _ctx.StringValue("DescribePropertyProcItem.PropertyItems["+ i +"].Name");
				propertyProcItem.Count = _ctx.IntegerValue("DescribePropertyProcItem.PropertyItems["+ i +"].Count");

				describePropertyProcItemResponse_propertyItems.Add(propertyProcItem);
			}
			describePropertyProcItemResponse.PropertyItems = describePropertyProcItemResponse_propertyItems;
        
			return describePropertyProcItemResponse;
        }
    }
}
