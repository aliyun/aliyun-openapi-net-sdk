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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDepartsResponseUnmarshaller
    {
        public static DescribeDepartsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDepartsResponse describeDepartsResponse = new DescribeDepartsResponse();

			describeDepartsResponse.HttpResponse = context.HttpResponse;
			describeDepartsResponse.RequestId = context.StringValue("DescribeDeparts.RequestId");
			describeDepartsResponse.PageSize = context.IntegerValue("DescribeDeparts.PageSize");
			describeDepartsResponse.CurrentPage = context.IntegerValue("DescribeDeparts.CurrentPage");
			describeDepartsResponse.TotalCount = context.IntegerValue("DescribeDeparts.TotalCount");

			List<DescribeDepartsResponse.DescribeDeparts_Depart> describeDepartsResponse_items = new List<DescribeDepartsResponse.DescribeDeparts_Depart>();
			for (int i = 0; i < context.Length("DescribeDeparts.Items.Length"); i++) {
				DescribeDepartsResponse.DescribeDeparts_Depart depart = new DescribeDepartsResponse.DescribeDeparts_Depart();
				depart.Id = context.LongValue("DescribeDeparts.Items["+ i +"].Id");
				depart.DepartId = context.LongValue("DescribeDeparts.Items["+ i +"].DepartId");
				depart.DepartName = context.StringValue("DescribeDeparts.Items["+ i +"].DepartName");
				depart.Comment = context.StringValue("DescribeDeparts.Items["+ i +"].Comment");
				depart.ParentDepartId = context.LongValue("DescribeDeparts.Items["+ i +"].ParentDepartId");
				depart.ParentDepartName = context.StringValue("DescribeDeparts.Items["+ i +"].ParentDepartName");
				depart.Level = context.IntegerValue("DescribeDeparts.Items["+ i +"].Level");

				describeDepartsResponse_items.Add(depart);
			}
			describeDepartsResponse.Items = describeDepartsResponse_items;
        
			return describeDepartsResponse;
        }
    }
}
