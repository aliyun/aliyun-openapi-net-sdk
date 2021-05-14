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
    public class DescribeBackMenuResponseUnmarshaller
    {
        public static DescribeBackMenuResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackMenuResponse describeBackMenuResponse = new DescribeBackMenuResponse();

			describeBackMenuResponse.HttpResponse = _ctx.HttpResponse;
			describeBackMenuResponse.RequestId = _ctx.StringValue("DescribeBackMenu.RequestId");
			describeBackMenuResponse.Success = _ctx.BooleanValue("DescribeBackMenu.Success");

			List<DescribeBackMenuResponse.DescribeBackMenu_ListItem> describeBackMenuResponse_list = new List<DescribeBackMenuResponse.DescribeBackMenu_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeBackMenu.List.Length"); i++) {
				DescribeBackMenuResponse.DescribeBackMenu_ListItem listItem = new DescribeBackMenuResponse.DescribeBackMenu_ListItem();
				listItem.MenuName = _ctx.StringValue("DescribeBackMenu.List["+ i +"].MenuName");
				listItem.Support = _ctx.BooleanValue("DescribeBackMenu.List["+ i +"].Support");

				describeBackMenuResponse_list.Add(listItem);
			}
			describeBackMenuResponse.List = describeBackMenuResponse_list;
        
			return describeBackMenuResponse;
        }
    }
}
