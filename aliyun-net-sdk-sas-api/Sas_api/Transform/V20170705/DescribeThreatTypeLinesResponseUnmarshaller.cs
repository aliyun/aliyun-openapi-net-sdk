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
    public class DescribeThreatTypeLinesResponseUnmarshaller
    {
        public static DescribeThreatTypeLinesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeThreatTypeLinesResponse describeThreatTypeLinesResponse = new DescribeThreatTypeLinesResponse();

			describeThreatTypeLinesResponse.HttpResponse = context.HttpResponse;
			describeThreatTypeLinesResponse.RequestId = context.StringValue("DescribeThreatTypeLines.RequestId");

			List<string> describeThreatTypeLinesResponse_categories = new List<string>();
			for (int i = 0; i < context.Length("DescribeThreatTypeLines.Categories.Length"); i++) {
				describeThreatTypeLinesResponse_categories.Add(context.StringValue("DescribeThreatTypeLines.Categories["+ i +"]"));
			}
			describeThreatTypeLinesResponse.Categories = describeThreatTypeLinesResponse_categories;

			List<DescribeThreatTypeLinesResponse.DescribeThreatTypeLines_Item> describeThreatTypeLinesResponse_items = new List<DescribeThreatTypeLinesResponse.DescribeThreatTypeLines_Item>();
			for (int i = 0; i < context.Length("DescribeThreatTypeLines.Items.Length"); i++) {
				DescribeThreatTypeLinesResponse.DescribeThreatTypeLines_Item item = new DescribeThreatTypeLinesResponse.DescribeThreatTypeLines_Item();
				item.Data = context.FloatValue("DescribeThreatTypeLines.Items["+ i +"].Data");
				item.Id = context.StringValue("DescribeThreatTypeLines.Items["+ i +"].Id");
				item.Name = context.StringValue("DescribeThreatTypeLines.Items["+ i +"].Name");

				describeThreatTypeLinesResponse_items.Add(item);
			}
			describeThreatTypeLinesResponse.Items = describeThreatTypeLinesResponse_items;
        
			return describeThreatTypeLinesResponse;
        }
    }
}
