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
    public class DescribeCdnVendorResponseUnmarshaller
    {
        public static DescribeCdnVendorResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnVendorResponse describeCdnVendorResponse = new DescribeCdnVendorResponse();

			describeCdnVendorResponse.HttpResponse = context.HttpResponse;
			describeCdnVendorResponse.RequestId = context.StringValue("DescribeCdnVendor.RequestId");
			describeCdnVendorResponse.Module = context.StringValue("DescribeCdnVendor.Module");

			DescribeCdnVendorResponse.DescribeCdnVendor_PageInfo pageInfo = new DescribeCdnVendorResponse.DescribeCdnVendor_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeCdnVendor.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeCdnVendor.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeCdnVendor.PageInfo.CurrentPage");
			describeCdnVendorResponse.PageInfo = pageInfo;

			List<DescribeCdnVendorResponse.DescribeCdnVendor_Data> describeCdnVendorResponse_dataList = new List<DescribeCdnVendorResponse.DescribeCdnVendor_Data>();
			for (int i = 0; i < context.Length("DescribeCdnVendor.DataList.Length"); i++) {
				DescribeCdnVendorResponse.DescribeCdnVendor_Data data = new DescribeCdnVendorResponse.DescribeCdnVendor_Data();
				data.VendorAliuid = context.IntegerValue("DescribeCdnVendor.DataList["+ i +"].VendorAliuid");
				data.VendorName = context.StringValue("DescribeCdnVendor.DataList["+ i +"].VendorName");
				data.SafetyFactor = context.StringValue("DescribeCdnVendor.DataList["+ i +"].SafetyFactor");
				data.GmtCreate = context.StringValue("DescribeCdnVendor.DataList["+ i +"].GmtCreate");
				data.UpdateTime = context.StringValue("DescribeCdnVendor.DataList["+ i +"].UpdateTime");

				describeCdnVendorResponse_dataList.Add(data);
			}
			describeCdnVendorResponse.DataList = describeCdnVendorResponse_dataList;
        
			return describeCdnVendorResponse;
        }
    }
}
