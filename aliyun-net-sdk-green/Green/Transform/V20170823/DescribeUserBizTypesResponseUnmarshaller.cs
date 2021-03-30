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
        public static DescribeUserBizTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserBizTypesResponse describeUserBizTypesResponse = new DescribeUserBizTypesResponse();

			describeUserBizTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeUserBizTypesResponse.RequestId = _ctx.StringValue("DescribeUserBizTypes.RequestId");

			List<DescribeUserBizTypesResponse.DescribeUserBizTypes_Item> describeUserBizTypesResponse_bizTypeList = new List<DescribeUserBizTypesResponse.DescribeUserBizTypes_Item>();
			for (int i = 0; i < _ctx.Length("DescribeUserBizTypes.BizTypeList.Length"); i++) {
				DescribeUserBizTypesResponse.DescribeUserBizTypes_Item item = new DescribeUserBizTypesResponse.DescribeUserBizTypes_Item();
				item.BizType = _ctx.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].BizType");
				item.SourceBizType = _ctx.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].SourceBizType");
				item.Gray = _ctx.BooleanValue("DescribeUserBizTypes.BizTypeList["+ i +"].Gray");
				item.Source = _ctx.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].Source");
				item.CiteTemplate = _ctx.BooleanValue("DescribeUserBizTypes.BizTypeList["+ i +"].CiteTemplate");
				item.IndustryInfo = _ctx.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].IndustryInfo");
				item.Description = _ctx.StringValue("DescribeUserBizTypes.BizTypeList["+ i +"].Description");

				describeUserBizTypesResponse_bizTypeList.Add(item);
			}
			describeUserBizTypesResponse.BizTypeList = describeUserBizTypesResponse_bizTypeList;

			List<DescribeUserBizTypesResponse.DescribeUserBizTypes_ImportItem> describeUserBizTypesResponse_bizTypeListImport = new List<DescribeUserBizTypesResponse.DescribeUserBizTypes_ImportItem>();
			for (int i = 0; i < _ctx.Length("DescribeUserBizTypes.BizTypeListImport.Length"); i++) {
				DescribeUserBizTypesResponse.DescribeUserBizTypes_ImportItem importItem = new DescribeUserBizTypesResponse.DescribeUserBizTypes_ImportItem();
				importItem.BizType = _ctx.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].BizType");
				importItem.SourceBizType = _ctx.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].SourceBizType");
				importItem.Gray = _ctx.BooleanValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].Gray");
				importItem.Source = _ctx.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].Source");
				importItem.CiteTemplate = _ctx.BooleanValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].CiteTemplate");
				importItem.IndustryInfo = _ctx.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].IndustryInfo");
				importItem.Description = _ctx.StringValue("DescribeUserBizTypes.BizTypeListImport["+ i +"].Description");

				describeUserBizTypesResponse_bizTypeListImport.Add(importItem);
			}
			describeUserBizTypesResponse.BizTypeListImport = describeUserBizTypesResponse_bizTypeListImport;
        
			return describeUserBizTypesResponse;
        }
    }
}
