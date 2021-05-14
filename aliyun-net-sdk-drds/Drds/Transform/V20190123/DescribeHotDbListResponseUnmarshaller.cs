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
    public class DescribeHotDbListResponseUnmarshaller
    {
        public static DescribeHotDbListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHotDbListResponse describeHotDbListResponse = new DescribeHotDbListResponse();

			describeHotDbListResponse.HttpResponse = _ctx.HttpResponse;
			describeHotDbListResponse.RequestId = _ctx.StringValue("DescribeHotDbList.RequestId");
			describeHotDbListResponse.Success = _ctx.BooleanValue("DescribeHotDbList.Success");
			describeHotDbListResponse.Msg = _ctx.StringValue("DescribeHotDbList.Msg");

			DescribeHotDbListResponse.DescribeHotDbList_Data data = new DescribeHotDbListResponse.DescribeHotDbList_Data();
			data.RandomCode = _ctx.StringValue("DescribeHotDbList.Data.RandomCode");

			List<DescribeHotDbListResponse.DescribeHotDbList_Data.DescribeHotDbList_InstanceDb> data_list = new List<DescribeHotDbListResponse.DescribeHotDbList_Data.DescribeHotDbList_InstanceDb>();
			for (int i = 0; i < _ctx.Length("DescribeHotDbList.Data.List.Length"); i++) {
				DescribeHotDbListResponse.DescribeHotDbList_Data.DescribeHotDbList_InstanceDb instanceDb = new DescribeHotDbListResponse.DescribeHotDbList_Data.DescribeHotDbList_InstanceDb();
				instanceDb.InstanceName = _ctx.StringValue("DescribeHotDbList.Data.List["+ i +"].InstanceName");

				List<string> instanceDb_hotDbList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeHotDbList.Data.List["+ i +"].HotDbList.Length"); j++) {
					instanceDb_hotDbList.Add(_ctx.StringValue("DescribeHotDbList.Data.List["+ i +"].HotDbList["+ j +"]"));
				}
				instanceDb.HotDbList = instanceDb_hotDbList;

				data_list.Add(instanceDb);
			}
			data.List = data_list;
			describeHotDbListResponse.Data = data;
        
			return describeHotDbListResponse;
        }
    }
}
