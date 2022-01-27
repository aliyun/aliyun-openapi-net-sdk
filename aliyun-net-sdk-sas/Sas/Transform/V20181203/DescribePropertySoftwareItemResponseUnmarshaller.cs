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
    public class DescribePropertySoftwareItemResponseUnmarshaller
    {
        public static DescribePropertySoftwareItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertySoftwareItemResponse describePropertySoftwareItemResponse = new DescribePropertySoftwareItemResponse();

			describePropertySoftwareItemResponse.HttpResponse = _ctx.HttpResponse;
			describePropertySoftwareItemResponse.RequestId = _ctx.StringValue("DescribePropertySoftwareItem.RequestId");

			DescribePropertySoftwareItemResponse.DescribePropertySoftwareItem_PageInfo pageInfo = new DescribePropertySoftwareItemResponse.DescribePropertySoftwareItem_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertySoftwareItem.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertySoftwareItem.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertySoftwareItem.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertySoftwareItem.PageInfo.CurrentPage");
			describePropertySoftwareItemResponse.PageInfo = pageInfo;

			List<DescribePropertySoftwareItemResponse.DescribePropertySoftwareItem_PropertySoftwareItem> describePropertySoftwareItemResponse_propertyItems = new List<DescribePropertySoftwareItemResponse.DescribePropertySoftwareItem_PropertySoftwareItem>();
			for (int i = 0; i < _ctx.Length("DescribePropertySoftwareItem.PropertyItems.Length"); i++) {
				DescribePropertySoftwareItemResponse.DescribePropertySoftwareItem_PropertySoftwareItem propertySoftwareItem = new DescribePropertySoftwareItemResponse.DescribePropertySoftwareItem_PropertySoftwareItem();
				propertySoftwareItem.Name = _ctx.StringValue("DescribePropertySoftwareItem.PropertyItems["+ i +"].Name");
				propertySoftwareItem.Count = _ctx.IntegerValue("DescribePropertySoftwareItem.PropertyItems["+ i +"].Count");

				describePropertySoftwareItemResponse_propertyItems.Add(propertySoftwareItem);
			}
			describePropertySoftwareItemResponse.PropertyItems = describePropertySoftwareItemResponse_propertyItems;
        
			return describePropertySoftwareItemResponse;
        }
    }
}
