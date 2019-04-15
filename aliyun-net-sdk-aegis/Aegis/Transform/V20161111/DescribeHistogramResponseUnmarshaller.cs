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
    public class DescribeHistogramResponseUnmarshaller
    {
        public static DescribeHistogramResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHistogramResponse describeHistogramResponse = new DescribeHistogramResponse();

			describeHistogramResponse.HttpResponse = context.HttpResponse;
			describeHistogramResponse.RequestId = context.StringValue("DescribeHistogram.RequestId");

			List<string> describeHistogramResponse_categories = new List<string>();
			for (int i = 0; i < context.Length("DescribeHistogram.Categories.Length"); i++) {
				describeHistogramResponse_categories.Add(context.StringValue("DescribeHistogram.Categories["+ i +"]"));
			}
			describeHistogramResponse.Categories = describeHistogramResponse_categories;

			List<DescribeHistogramResponse.DescribeHistogram_ItemsItem> describeHistogramResponse_items = new List<DescribeHistogramResponse.DescribeHistogram_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeHistogram.Items.Length"); i++) {
				DescribeHistogramResponse.DescribeHistogram_ItemsItem itemsItem = new DescribeHistogramResponse.DescribeHistogram_ItemsItem();

				List<string> itemsItem_data = new List<string>();
				for (int j = 0; j < context.Length("DescribeHistogram.Items["+ i +"].Data.Length"); j++) {
					itemsItem_data.Add(context.StringValue("DescribeHistogram.Items["+ i +"].Data["+ j +"]"));
				}
				itemsItem.Data = itemsItem_data;

				describeHistogramResponse_items.Add(itemsItem);
			}
			describeHistogramResponse.Items = describeHistogramResponse_items;
        
			return describeHistogramResponse;
        }
    }
}
