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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeCdnIpListResponseUnmarshaller
    {
        public static DescribeCdnIpListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnIpListResponse describeCdnIpListResponse = new DescribeCdnIpListResponse();

			describeCdnIpListResponse.HttpResponse = context.HttpResponse;
			describeCdnIpListResponse.RequestId = context.StringValue("DescribeCdnIpList.RequestId");
			describeCdnIpListResponse.Module = context.StringValue("DescribeCdnIpList.Module");

			DescribeCdnIpListResponse.DescribeCdnIpList_PageInfo pageInfo = new DescribeCdnIpListResponse.DescribeCdnIpList_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeCdnIpList.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeCdnIpList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeCdnIpList.PageInfo.CurrentPage");
			describeCdnIpListResponse.PageInfo = pageInfo;

			List<DescribeCdnIpListResponse.DescribeCdnIpList_Data> describeCdnIpListResponse_dataList = new List<DescribeCdnIpListResponse.DescribeCdnIpList_Data>();
			for (int i = 0; i < context.Length("DescribeCdnIpList.DataList.Length"); i++) {
				DescribeCdnIpListResponse.DescribeCdnIpList_Data data = new DescribeCdnIpListResponse.DescribeCdnIpList_Data();
				data.Id = context.IntegerValue("DescribeCdnIpList.DataList["+ i +"].Id");
				data.VendorAliuid = context.IntegerValue("DescribeCdnIpList.DataList["+ i +"].VendorAliuid");
				data.IpSeg = context.StringValue("DescribeCdnIpList.DataList["+ i +"].IpSeg");
				data.State = context.IntegerValue("DescribeCdnIpList.DataList["+ i +"].State");
				data.CreateTime = context.StringValue("DescribeCdnIpList.DataList["+ i +"].CreateTime");
				data.UpdateTime = context.StringValue("DescribeCdnIpList.DataList["+ i +"].UpdateTime");

				describeCdnIpListResponse_dataList.Add(data);
			}
			describeCdnIpListResponse.DataList = describeCdnIpListResponse_dataList;
        
			return describeCdnIpListResponse;
        }
    }
}
