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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeUserBizTypesResponseUnmarshaller
    {
        public static DescribeUserBizTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserBizTypesResponse describeUserBizTypesResponse = new DescribeUserBizTypesResponse();

			describeUserBizTypesResponse.HttpResponse = context.HttpResponse;
			describeUserBizTypesResponse.RequestId = context.StringValue("DescribeUserBizTypes.RequestId");

			List<DescribeUserBizTypesResponse.DescribeUserBizTypes_Item> describeUserBizTypesResponse_bizTypeList = new List<DescribeUserBizTypesResponse.DescribeUserBizTypes_Item>();
			for (int i = 0; i < context.Length("DescribeUserBizTypes.BizTypeList.Length"); i++) {
				DescribeUserBizTypesResponse.DescribeUserBizTypes_Item item = new DescribeUserBizTypesResponse.DescribeUserBizTypes_Item();
				item.BizType = context.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].BizType");
				item.SourceBizType = context.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].SourceBizType");
				item.Gray = context.BooleanValue("DescribeUserBizTypes.BizTypeList["+ i +"].Gray");
				item.Source = context.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].Source");

				describeUserBizTypesResponse_bizTypeList.Add(item);
			}
			describeUserBizTypesResponse.BizTypeList = describeUserBizTypesResponse_bizTypeList;

			List<DescribeUserBizTypesResponse.DescribeUserBizTypes_Item> describeUserBizTypesResponse_bizTypeListImport = new List<DescribeUserBizTypesResponse.DescribeUserBizTypes_Item>();
			for (int i = 0; i < context.Length("DescribeUserBizTypes.BizTypeListImport.Length"); i++) {
				DescribeUserBizTypesResponse.DescribeUserBizTypes_Item item = new DescribeUserBizTypesResponse.DescribeUserBizTypes_Item();
				item.BizType = context.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].BizType");
				item.SourceBizType = context.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].SourceBizType");
				item.Gray = context.BooleanValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].Gray");
				item.Source = context.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].Source");

				describeUserBizTypesResponse_bizTypeListImport.Add(item);
			}
			describeUserBizTypesResponse.BizTypeListImport = describeUserBizTypesResponse_bizTypeListImport;
        
			return describeUserBizTypesResponse;
        }
    }
}
