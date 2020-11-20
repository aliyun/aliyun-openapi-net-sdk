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
    public class DescribeWebsiteStatResponseUnmarshaller
    {
        public static DescribeWebsiteStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebsiteStatResponse describeWebsiteStatResponse = new DescribeWebsiteStatResponse();

			describeWebsiteStatResponse.HttpResponse = _ctx.HttpResponse;
			describeWebsiteStatResponse.RequestId = _ctx.StringValue("DescribeWebsiteStat.RequestId");
			describeWebsiteStatResponse.TotalCount = _ctx.IntegerValue("DescribeWebsiteStat.TotalCount");

			List<DescribeWebsiteStatResponse.DescribeWebsiteStat_WebsiteStat> describeWebsiteStatResponse_websiteStatList = new List<DescribeWebsiteStatResponse.DescribeWebsiteStat_WebsiteStat>();
			for (int i = 0; i < _ctx.Length("DescribeWebsiteStat.WebsiteStatList.Length"); i++) {
				DescribeWebsiteStatResponse.DescribeWebsiteStat_WebsiteStat websiteStat = new DescribeWebsiteStatResponse.DescribeWebsiteStat_WebsiteStat();
				websiteStat.SubServiceModule = _ctx.StringValue("DescribeWebsiteStat.WebsiteStatList["+ i +"].SubServiceModule");
				websiteStat.InstanceCount = _ctx.IntegerValue("DescribeWebsiteStat.WebsiteStatList["+ i +"].InstanceCount");
				websiteStat.ScanCount = _ctx.IntegerValue("DescribeWebsiteStat.WebsiteStatList["+ i +"].ScanCount");
				websiteStat.RiskCount = _ctx.IntegerValue("DescribeWebsiteStat.WebsiteStatList["+ i +"].RiskCount");

				describeWebsiteStatResponse_websiteStatList.Add(websiteStat);
			}
			describeWebsiteStatResponse.WebsiteStatList = describeWebsiteStatResponse_websiteStatList;
        
			return describeWebsiteStatResponse;
        }
    }
}
