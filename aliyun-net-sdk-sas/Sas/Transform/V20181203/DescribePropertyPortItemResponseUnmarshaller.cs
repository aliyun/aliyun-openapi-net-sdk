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
    public class DescribePropertyPortItemResponseUnmarshaller
    {
        public static DescribePropertyPortItemResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePropertyPortItemResponse describePropertyPortItemResponse = new DescribePropertyPortItemResponse();

			describePropertyPortItemResponse.HttpResponse = context.HttpResponse;
			describePropertyPortItemResponse.RequestId = context.StringValue("DescribePropertyPortItem.RequestId");

			DescribePropertyPortItemResponse.DescribePropertyPortItem_PageInfo pageInfo = new DescribePropertyPortItemResponse.DescribePropertyPortItem_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribePropertyPortItem.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribePropertyPortItem.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribePropertyPortItem.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribePropertyPortItem.PageInfo.CurrentPage");
			describePropertyPortItemResponse.PageInfo = pageInfo;

			List<DescribePropertyPortItemResponse.DescribePropertyPortItem_PropertyItem> describePropertyPortItemResponse_propertyItems = new List<DescribePropertyPortItemResponse.DescribePropertyPortItem_PropertyItem>();
			for (int i = 0; i < context.Length("DescribePropertyPortItem.PropertyItems.Length"); i++) {
				DescribePropertyPortItemResponse.DescribePropertyPortItem_PropertyItem propertyItem = new DescribePropertyPortItemResponse.DescribePropertyPortItem_PropertyItem();
				propertyItem.Port = context.StringValue("DescribePropertyPortItem.PropertyItems["+ i +"].Port");
				propertyItem.Proto = context.StringValue("DescribePropertyPortItem.PropertyItems["+ i +"].Proto");
				propertyItem.Count = context.IntegerValue("DescribePropertyPortItem.PropertyItems["+ i +"].Count");

				describePropertyPortItemResponse_propertyItems.Add(propertyItem);
			}
			describePropertyPortItemResponse.PropertyItems = describePropertyPortItemResponse_propertyItems;
        
			return describePropertyPortItemResponse;
        }
    }
}
