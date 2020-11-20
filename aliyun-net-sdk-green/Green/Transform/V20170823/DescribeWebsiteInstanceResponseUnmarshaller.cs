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
    public class DescribeWebsiteInstanceResponseUnmarshaller
    {
        public static DescribeWebsiteInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebsiteInstanceResponse describeWebsiteInstanceResponse = new DescribeWebsiteInstanceResponse();

			describeWebsiteInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeWebsiteInstanceResponse.RequestId = _ctx.StringValue("DescribeWebsiteInstance.RequestId");
			describeWebsiteInstanceResponse.PageSize = _ctx.IntegerValue("DescribeWebsiteInstance.PageSize");
			describeWebsiteInstanceResponse.CurrentPage = _ctx.IntegerValue("DescribeWebsiteInstance.CurrentPage");
			describeWebsiteInstanceResponse.TotalCount = _ctx.IntegerValue("DescribeWebsiteInstance.TotalCount");

			List<DescribeWebsiteInstanceResponse.DescribeWebsiteInstance_WebsiteInstance> describeWebsiteInstanceResponse_websiteInstanceList = new List<DescribeWebsiteInstanceResponse.DescribeWebsiteInstance_WebsiteInstance>();
			for (int i = 0; i < _ctx.Length("DescribeWebsiteInstance.WebsiteInstanceList.Length"); i++) {
				DescribeWebsiteInstanceResponse.DescribeWebsiteInstance_WebsiteInstance websiteInstance = new DescribeWebsiteInstanceResponse.DescribeWebsiteInstance_WebsiteInstance();
				websiteInstance.Protocol = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].Protocol");
				websiteInstance.InstanceId = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].InstanceId");
				websiteInstance.WebsiteScanInterval = _ctx.IntegerValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].WebsiteScanInterval");
				websiteInstance.Domain = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].Domain");
				websiteInstance.BuyTime = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].BuyTime");
				websiteInstance.IndexPageScanInterval = _ctx.IntegerValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].IndexPageScanInterval");
				websiteInstance.IndexPage = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].IndexPage");
				websiteInstance.ExpiredTime = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].ExpiredTime");
				websiteInstance.Status = _ctx.StringValue("DescribeWebsiteInstance.WebsiteInstanceList["+ i +"].Status");

				describeWebsiteInstanceResponse_websiteInstanceList.Add(websiteInstance);
			}
			describeWebsiteInstanceResponse.WebsiteInstanceList = describeWebsiteInstanceResponse_websiteInstanceList;
        
			return describeWebsiteInstanceResponse;
        }
    }
}
