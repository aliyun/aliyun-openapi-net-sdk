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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeLoginBaseConfigsResponseUnmarshaller
    {
        public static DescribeLoginBaseConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoginBaseConfigsResponse describeLoginBaseConfigsResponse = new DescribeLoginBaseConfigsResponse();

			describeLoginBaseConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeLoginBaseConfigsResponse.CurrentPage = _ctx.IntegerValue("DescribeLoginBaseConfigs.CurrentPage");
			describeLoginBaseConfigsResponse.RequestId = _ctx.StringValue("DescribeLoginBaseConfigs.RequestId");
			describeLoginBaseConfigsResponse.PageSize = _ctx.IntegerValue("DescribeLoginBaseConfigs.PageSize");
			describeLoginBaseConfigsResponse.TotalCount = _ctx.IntegerValue("DescribeLoginBaseConfigs.TotalCount");

			List<DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig> describeLoginBaseConfigsResponse_baseConfigs = new List<DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig>();
			for (int i = 0; i < _ctx.Length("DescribeLoginBaseConfigs.BaseConfigs.Length"); i++) {
				DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig baseConfig = new DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig();
				baseConfig.EndTime = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].EndTime");
				baseConfig.Account = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].Account");
				baseConfig.StartTime = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].StartTime");
				baseConfig.Ip = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].Ip");
				baseConfig.TotalCount = _ctx.IntegerValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].TotalCount");
				baseConfig.UuidCount = _ctx.IntegerValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].UuidCount");
				baseConfig.Location = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].Location");

				List<DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig.DescribeLoginBaseConfigs_Target> baseConfig_targetList = new List<DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig.DescribeLoginBaseConfigs_Target>();
				for (int j = 0; j < _ctx.Length("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].TargetList.Length"); j++) {
					DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig.DescribeLoginBaseConfigs_Target target = new DescribeLoginBaseConfigsResponse.DescribeLoginBaseConfigs_BaseConfig.DescribeLoginBaseConfigs_Target();
					target.Target = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].TargetList["+ j +"].Target");
					target.TargetType = _ctx.StringValue("DescribeLoginBaseConfigs.BaseConfigs["+ i +"].TargetList["+ j +"].TargetType");

					baseConfig_targetList.Add(target);
				}
				baseConfig.TargetList = baseConfig_targetList;

				describeLoginBaseConfigsResponse_baseConfigs.Add(baseConfig);
			}
			describeLoginBaseConfigsResponse.BaseConfigs = describeLoginBaseConfigsResponse_baseConfigs;
        
			return describeLoginBaseConfigsResponse;
        }
    }
}
