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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeFilterFieldsResponseUnmarshaller
    {
        public static DescribeFilterFieldsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFilterFieldsResponse describeFilterFieldsResponse = new DescribeFilterFieldsResponse();

			describeFilterFieldsResponse.HttpResponse = context.HttpResponse;
			describeFilterFieldsResponse.RequestId = context.StringValue("DescribeFilterFields.RequestId");
			describeFilterFieldsResponse.Total = context.LongValue("DescribeFilterFields.Total");

			List<DescribeFilterFieldsResponse.DescribeFilterFields_LogFilterListItem> describeFilterFieldsResponse_logFilterList = new List<DescribeFilterFieldsResponse.DescribeFilterFields_LogFilterListItem>();
			for (int i = 0; i < context.Length("DescribeFilterFields.LogFilterList.Length"); i++) {
				DescribeFilterFieldsResponse.DescribeFilterFields_LogFilterListItem logFilterListItem = new DescribeFilterFieldsResponse.DescribeFilterFields_LogFilterListItem();
				logFilterListItem.Fields = context.StringValue("DescribeFilterFields.LogFilterList["+ i +"].Fields");

				describeFilterFieldsResponse_logFilterList.Add(logFilterListItem);
			}
			describeFilterFieldsResponse.LogFilterList = describeFilterFieldsResponse_logFilterList;
        
			return describeFilterFieldsResponse;
        }
    }
}
