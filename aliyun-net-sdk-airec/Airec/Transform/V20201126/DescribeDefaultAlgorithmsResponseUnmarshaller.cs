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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeDefaultAlgorithmsResponseUnmarshaller
    {
        public static DescribeDefaultAlgorithmsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDefaultAlgorithmsResponse describeDefaultAlgorithmsResponse = new DescribeDefaultAlgorithmsResponse();

			describeDefaultAlgorithmsResponse.HttpResponse = _ctx.HttpResponse;
			describeDefaultAlgorithmsResponse.RequestId = _ctx.StringValue("DescribeDefaultAlgorithms.requestId");

			List<DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem> describeDefaultAlgorithmsResponse_result = new List<DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeDefaultAlgorithms.Result.Length"); i++) {
				DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem resultItem = new DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem();
				resultItem.Key = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].key");
				resultItem.Name = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].name");
				resultItem.Category = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].category");
				resultItem.Type = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].type");
				resultItem.DefaultValue = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].defaultValue");
				resultItem.ExperimentValue = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].experimentValue");
				resultItem.HasConfig = _ctx.BooleanValue("DescribeDefaultAlgorithms.Result["+ i +"].hasConfig");

				List<DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem.DescribeDefaultAlgorithms_ConfigItem> resultItem_config = new List<DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem.DescribeDefaultAlgorithms_ConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeDefaultAlgorithms.Result["+ i +"].Config.Length"); j++) {
					DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem.DescribeDefaultAlgorithms_ConfigItem configItem = new DescribeDefaultAlgorithmsResponse.DescribeDefaultAlgorithms_ResultItem.DescribeDefaultAlgorithms_ConfigItem();
					configItem.Key = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].Config["+ j +"].key");
					configItem.Name = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].Config["+ j +"].name");
					configItem.DefaultValue = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].Config["+ j +"].defaultValue");
					configItem.ExperimentValue = _ctx.StringValue("DescribeDefaultAlgorithms.Result["+ i +"].Config["+ j +"].experimentValue");

					resultItem_config.Add(configItem);
				}
				resultItem.Config = resultItem_config;

				describeDefaultAlgorithmsResponse_result.Add(resultItem);
			}
			describeDefaultAlgorithmsResponse.Result = describeDefaultAlgorithmsResponse_result;
        
			return describeDefaultAlgorithmsResponse;
        }
    }
}
