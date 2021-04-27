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
    public class DescribeRiskItemTypeResponseUnmarshaller
    {
        public static DescribeRiskItemTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRiskItemTypeResponse describeRiskItemTypeResponse = new DescribeRiskItemTypeResponse();

			describeRiskItemTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeRiskItemTypeResponse.RequestId = _ctx.StringValue("DescribeRiskItemType.RequestId");

			List<DescribeRiskItemTypeResponse.DescribeRiskItemType_ItemType> describeRiskItemTypeResponse_list = new List<DescribeRiskItemTypeResponse.DescribeRiskItemType_ItemType>();
			for (int i = 0; i < _ctx.Length("DescribeRiskItemType.List.Length"); i++) {
				DescribeRiskItemTypeResponse.DescribeRiskItemType_ItemType itemType = new DescribeRiskItemTypeResponse.DescribeRiskItemType_ItemType();
				itemType.Id = _ctx.LongValue("DescribeRiskItemType.List["+ i +"].Id");
				itemType.Title = _ctx.StringValue("DescribeRiskItemType.List["+ i +"].Title");

				describeRiskItemTypeResponse_list.Add(itemType);
			}
			describeRiskItemTypeResponse.List = describeRiskItemTypeResponse_list;
        
			return describeRiskItemTypeResponse;
        }
    }
}
