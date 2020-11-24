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
    public class DescribePortViewSourceIspsResponseUnmarshaller
    {
        public static DescribePortViewSourceIspsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortViewSourceIspsResponse describePortViewSourceIspsResponse = new DescribePortViewSourceIspsResponse();

			describePortViewSourceIspsResponse.HttpResponse = _ctx.HttpResponse;
			describePortViewSourceIspsResponse.RequestId = _ctx.StringValue("DescribePortViewSourceIsps.RequestId");

			List<DescribePortViewSourceIspsResponse.DescribePortViewSourceIsps_Isp> describePortViewSourceIspsResponse_isps = new List<DescribePortViewSourceIspsResponse.DescribePortViewSourceIsps_Isp>();
			for (int i = 0; i < _ctx.Length("DescribePortViewSourceIsps.Isps.Length"); i++) {
				DescribePortViewSourceIspsResponse.DescribePortViewSourceIsps_Isp isp = new DescribePortViewSourceIspsResponse.DescribePortViewSourceIsps_Isp();
				isp.IspId = _ctx.StringValue("DescribePortViewSourceIsps.Isps["+ i +"].IspId");
				isp.Count = _ctx.LongValue("DescribePortViewSourceIsps.Isps["+ i +"].Count");

				describePortViewSourceIspsResponse_isps.Add(isp);
			}
			describePortViewSourceIspsResponse.Isps = describePortViewSourceIspsResponse_isps;
        
			return describePortViewSourceIspsResponse;
        }
    }
}
