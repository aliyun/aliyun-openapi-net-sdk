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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeEnumItemsResponseUnmarshaller
    {
        public static DescribeEnumItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEnumItemsResponse describeEnumItemsResponse = new DescribeEnumItemsResponse();

			describeEnumItemsResponse.HttpResponse = _ctx.HttpResponse;
			describeEnumItemsResponse.RequestId = _ctx.StringValue("DescribeEnumItems.RequestId");

			List<DescribeEnumItemsResponse.DescribeEnumItems_DataItem> describeEnumItemsResponse_data = new List<DescribeEnumItemsResponse.DescribeEnumItems_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeEnumItems.Data.Length"); i++) {
				DescribeEnumItemsResponse.DescribeEnumItems_DataItem dataItem = new DescribeEnumItemsResponse.DescribeEnumItems_DataItem();
				dataItem.Key = _ctx.StringValue("DescribeEnumItems.Data["+ i +"].Key");
				dataItem._Value = _ctx.StringValue("DescribeEnumItems.Data["+ i +"].Value");

				describeEnumItemsResponse_data.Add(dataItem);
			}
			describeEnumItemsResponse.Data = describeEnumItemsResponse_data;
        
			return describeEnumItemsResponse;
        }
    }
}
