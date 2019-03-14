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
    public class DescribeThreatDistributeResponseUnmarshaller
    {
        public static DescribeThreatDistributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeThreatDistributeResponse describeThreatDistributeResponse = new DescribeThreatDistributeResponse();

			describeThreatDistributeResponse.HttpResponse = context.HttpResponse;
			describeThreatDistributeResponse.RequestId = context.StringValue("DescribeThreatDistribute.RequestId");

			List<string> describeThreatDistributeResponse_categories = new List<string>();
			for (int i = 0; i < context.Length("DescribeThreatDistribute.Categories.Length"); i++) {
				describeThreatDistributeResponse_categories.Add(context.StringValue("DescribeThreatDistribute.Categories["+ i +"]"));
			}
			describeThreatDistributeResponse.Categories = describeThreatDistributeResponse_categories;

			List<DescribeThreatDistributeResponse.DescribeThreatDistribute_Item> describeThreatDistributeResponse_items = new List<DescribeThreatDistributeResponse.DescribeThreatDistribute_Item>();
			for (int i = 0; i < context.Length("DescribeThreatDistribute.Items.Length"); i++) {
				DescribeThreatDistributeResponse.DescribeThreatDistribute_Item item = new DescribeThreatDistributeResponse.DescribeThreatDistribute_Item();
				item.Data = context.FloatValue("DescribeThreatDistribute.Items["+ i +"].Data");
				item.Id = context.StringValue("DescribeThreatDistribute.Items["+ i +"].Id");
				item.Name = context.StringValue("DescribeThreatDistribute.Items["+ i +"].Name");

				describeThreatDistributeResponse_items.Add(item);
			}
			describeThreatDistributeResponse.Items = describeThreatDistributeResponse_items;
        
			return describeThreatDistributeResponse;
        }
    }
}
