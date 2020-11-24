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
    public class DescribePortViewSourceProvincesResponseUnmarshaller
    {
        public static DescribePortViewSourceProvincesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortViewSourceProvincesResponse describePortViewSourceProvincesResponse = new DescribePortViewSourceProvincesResponse();

			describePortViewSourceProvincesResponse.HttpResponse = _ctx.HttpResponse;
			describePortViewSourceProvincesResponse.RequestId = _ctx.StringValue("DescribePortViewSourceProvinces.RequestId");

			List<DescribePortViewSourceProvincesResponse.DescribePortViewSourceProvinces_Province> describePortViewSourceProvincesResponse_sourceProvinces = new List<DescribePortViewSourceProvincesResponse.DescribePortViewSourceProvinces_Province>();
			for (int i = 0; i < _ctx.Length("DescribePortViewSourceProvinces.SourceProvinces.Length"); i++) {
				DescribePortViewSourceProvincesResponse.DescribePortViewSourceProvinces_Province province = new DescribePortViewSourceProvincesResponse.DescribePortViewSourceProvinces_Province();
				province.Count = _ctx.LongValue("DescribePortViewSourceProvinces.SourceProvinces["+ i +"].Count");
				province.ProvinceId = _ctx.StringValue("DescribePortViewSourceProvinces.SourceProvinces["+ i +"].ProvinceId");

				describePortViewSourceProvincesResponse_sourceProvinces.Add(province);
			}
			describePortViewSourceProvincesResponse.SourceProvinces = describePortViewSourceProvincesResponse_sourceProvinces;
        
			return describePortViewSourceProvincesResponse;
        }
    }
}
