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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeConfigsResponseUnmarshaller
    {
        public static DescribeConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConfigsResponse describeConfigsResponse = new DescribeConfigsResponse();

			describeConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeConfigsResponse.RequestId = _ctx.StringValue("DescribeConfigs.RequestId");

			List<DescribeConfigsResponse.DescribeConfigs_Config> describeConfigsResponse_configList = new List<DescribeConfigsResponse.DescribeConfigs_Config>();
			for (int i = 0; i < _ctx.Length("DescribeConfigs.ConfigList.Length"); i++) {
				DescribeConfigsResponse.DescribeConfigs_Config config = new DescribeConfigsResponse.DescribeConfigs_Config();
				config.Code = _ctx.StringValue("DescribeConfigs.ConfigList["+ i +"].Code");
				config._Value = _ctx.StringValue("DescribeConfigs.ConfigList["+ i +"].Value");
				config.DefaultValue = _ctx.StringValue("DescribeConfigs.ConfigList["+ i +"].DefaultValue");
				config.Description = _ctx.StringValue("DescribeConfigs.ConfigList["+ i +"].Description");
				config.Id = _ctx.LongValue("DescribeConfigs.ConfigList["+ i +"].Id");

				describeConfigsResponse_configList.Add(config);
			}
			describeConfigsResponse.ConfigList = describeConfigsResponse_configList;
        
			return describeConfigsResponse;
        }
    }
}
