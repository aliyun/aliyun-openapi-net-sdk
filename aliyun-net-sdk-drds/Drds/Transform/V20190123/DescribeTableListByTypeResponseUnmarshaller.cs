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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeTableListByTypeResponseUnmarshaller
    {
        public static DescribeTableListByTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTableListByTypeResponse describeTableListByTypeResponse = new DescribeTableListByTypeResponse();

			describeTableListByTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeTableListByTypeResponse.RequestId = _ctx.StringValue("DescribeTableListByType.RequestId");
			describeTableListByTypeResponse.Success = _ctx.BooleanValue("DescribeTableListByType.Success");
			describeTableListByTypeResponse.PageNumber = _ctx.IntegerValue("DescribeTableListByType.PageNumber");
			describeTableListByTypeResponse.PageSize = _ctx.IntegerValue("DescribeTableListByType.PageSize");
			describeTableListByTypeResponse.Total = _ctx.IntegerValue("DescribeTableListByType.Total");

			List<DescribeTableListByTypeResponse.DescribeTableListByType_ListItem> describeTableListByTypeResponse_list = new List<DescribeTableListByTypeResponse.DescribeTableListByType_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeTableListByType.List.Length"); i++) {
				DescribeTableListByTypeResponse.DescribeTableListByType_ListItem listItem = new DescribeTableListByTypeResponse.DescribeTableListByType_ListItem();
				listItem.TableName = _ctx.StringValue("DescribeTableListByType.List["+ i +"].TableName");
				listItem.Property = _ctx.StringValue("DescribeTableListByType.List["+ i +"].Property");

				describeTableListByTypeResponse_list.Add(listItem);
			}
			describeTableListByTypeResponse.List = describeTableListByTypeResponse_list;
        
			return describeTableListByTypeResponse;
        }
    }
}
