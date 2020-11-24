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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebCustomPortsResponseUnmarshaller
    {
        public static DescribeWebCustomPortsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebCustomPortsResponse describeWebCustomPortsResponse = new DescribeWebCustomPortsResponse();

			describeWebCustomPortsResponse.HttpResponse = _ctx.HttpResponse;
			describeWebCustomPortsResponse.RequestId = _ctx.StringValue("DescribeWebCustomPorts.RequestId");

			List<DescribeWebCustomPortsResponse.DescribeWebCustomPorts_WebCustomPort> describeWebCustomPortsResponse_webCustomPorts = new List<DescribeWebCustomPortsResponse.DescribeWebCustomPorts_WebCustomPort>();
			for (int i = 0; i < _ctx.Length("DescribeWebCustomPorts.WebCustomPorts.Length"); i++) {
				DescribeWebCustomPortsResponse.DescribeWebCustomPorts_WebCustomPort webCustomPort = new DescribeWebCustomPortsResponse.DescribeWebCustomPorts_WebCustomPort();
				webCustomPort.ProxyType = _ctx.StringValue("DescribeWebCustomPorts.WebCustomPorts["+ i +"].ProxyType");

				List<string> webCustomPort_proxyPorts = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeWebCustomPorts.WebCustomPorts["+ i +"].ProxyPorts.Length"); j++) {
					webCustomPort_proxyPorts.Add(_ctx.StringValue("DescribeWebCustomPorts.WebCustomPorts["+ i +"].ProxyPorts["+ j +"]"));
				}
				webCustomPort.ProxyPorts = webCustomPort_proxyPorts;

				describeWebCustomPortsResponse_webCustomPorts.Add(webCustomPort);
			}
			describeWebCustomPortsResponse.WebCustomPorts = describeWebCustomPortsResponse_webCustomPorts;
        
			return describeWebCustomPortsResponse;
        }
    }
}
