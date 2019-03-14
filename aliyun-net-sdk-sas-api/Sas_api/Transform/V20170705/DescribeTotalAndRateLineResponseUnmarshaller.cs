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
using Aliyun.Acs.Sas_api.Model.V20170705;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class DescribeTotalAndRateLineResponseUnmarshaller
    {
        public static DescribeTotalAndRateLineResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTotalAndRateLineResponse describeTotalAndRateLineResponse = new DescribeTotalAndRateLineResponse();

			describeTotalAndRateLineResponse.HttpResponse = context.HttpResponse;
			describeTotalAndRateLineResponse.RequestId = context.StringValue("DescribeTotalAndRateLine.RequestId");

			List<string> describeTotalAndRateLineResponse_categories = new List<string>();
			for (int i = 0; i < context.Length("DescribeTotalAndRateLine.Categories.Length"); i++) {
				describeTotalAndRateLineResponse_categories.Add(context.StringValue("DescribeTotalAndRateLine.Categories["+ i +"]"));
			}
			describeTotalAndRateLineResponse.Categories = describeTotalAndRateLineResponse_categories;

			List<DescribeTotalAndRateLineResponse.DescribeTotalAndRateLine_Item> describeTotalAndRateLineResponse_items = new List<DescribeTotalAndRateLineResponse.DescribeTotalAndRateLine_Item>();
			for (int i = 0; i < context.Length("DescribeTotalAndRateLine.Items.Length"); i++) {
				DescribeTotalAndRateLineResponse.DescribeTotalAndRateLine_Item item = new DescribeTotalAndRateLineResponse.DescribeTotalAndRateLine_Item();
				item.Data = context.FloatValue("DescribeTotalAndRateLine.Items["+ i +"].Data");
				item.Id = context.StringValue("DescribeTotalAndRateLine.Items["+ i +"].Id");
				item.Name = context.StringValue("DescribeTotalAndRateLine.Items["+ i +"].Name");

				describeTotalAndRateLineResponse_items.Add(item);
			}
			describeTotalAndRateLineResponse.Items = describeTotalAndRateLineResponse_items;
        
			return describeTotalAndRateLineResponse;
        }
    }
}
