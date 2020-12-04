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
    public class DescribeCloudMonitorServicesResponseUnmarshaller
    {
        public static DescribeCloudMonitorServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudMonitorServicesResponse describeCloudMonitorServicesResponse = new DescribeCloudMonitorServicesResponse();

			describeCloudMonitorServicesResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudMonitorServicesResponse.RequestId = _ctx.StringValue("DescribeCloudMonitorServices.RequestId");
			describeCloudMonitorServicesResponse.TotalCount = _ctx.IntegerValue("DescribeCloudMonitorServices.TotalCount");

			List<string> describeCloudMonitorServicesResponse_items = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCloudMonitorServices.Items.Length"); i++) {
				describeCloudMonitorServicesResponse_items.Add(_ctx.StringValue("DescribeCloudMonitorServices.Items["+ i +"]"));
			}
			describeCloudMonitorServicesResponse.Items = describeCloudMonitorServicesResponse_items;
        
			return describeCloudMonitorServicesResponse;
        }
    }
}
