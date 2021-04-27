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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveShiftConfigsResponseUnmarshaller
    {
        public static DescribeLiveShiftConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveShiftConfigsResponse describeLiveShiftConfigsResponse = new DescribeLiveShiftConfigsResponse();

			describeLiveShiftConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveShiftConfigsResponse.RequestId = _ctx.StringValue("DescribeLiveShiftConfigs.RequestId");

			List<DescribeLiveShiftConfigsResponse.DescribeLiveShiftConfigs_Config> describeLiveShiftConfigsResponse_content = new List<DescribeLiveShiftConfigsResponse.DescribeLiveShiftConfigs_Config>();
			for (int i = 0; i < _ctx.Length("DescribeLiveShiftConfigs.Content.Length"); i++) {
				DescribeLiveShiftConfigsResponse.DescribeLiveShiftConfigs_Config config = new DescribeLiveShiftConfigsResponse.DescribeLiveShiftConfigs_Config();
				config.DomainName = _ctx.StringValue("DescribeLiveShiftConfigs.Content["+ i +"].DomainName");
				config.AppName = _ctx.StringValue("DescribeLiveShiftConfigs.Content["+ i +"].AppName");
				config.StreamName = _ctx.StringValue("DescribeLiveShiftConfigs.Content["+ i +"].StreamName");
				config.Vision = _ctx.IntegerValue("DescribeLiveShiftConfigs.Content["+ i +"].Vision");

				describeLiveShiftConfigsResponse_content.Add(config);
			}
			describeLiveShiftConfigsResponse.Content = describeLiveShiftConfigsResponse_content;
        
			return describeLiveShiftConfigsResponse;
        }
    }
}
