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
    public class DescribeBaseExperimentResponseUnmarshaller
    {
        public static DescribeBaseExperimentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBaseExperimentResponse describeBaseExperimentResponse = new DescribeBaseExperimentResponse();

			describeBaseExperimentResponse.HttpResponse = _ctx.HttpResponse;
			describeBaseExperimentResponse.RequestId = _ctx.StringValue("DescribeBaseExperiment.requestId");

			DescribeBaseExperimentResponse.DescribeBaseExperiment_Result result = new DescribeBaseExperimentResponse.DescribeBaseExperiment_Result();
			result.ExperimentId = _ctx.StringValue("DescribeBaseExperiment.Result.experimentId");
			result.Name = _ctx.StringValue("DescribeBaseExperiment.Result.name");
			result.Description = _ctx.StringValue("DescribeBaseExperiment.Result.description");
			result.Status = _ctx.StringValue("DescribeBaseExperiment.Result.status");
			result._Base = _ctx.BooleanValue("DescribeBaseExperiment.Result.base");
			result.OnlineTime = _ctx.StringValue("DescribeBaseExperiment.Result.onlineTime");
			result.OfflineTime = _ctx.StringValue("DescribeBaseExperiment.Result.offlineTime");

			List<string> result_buckets = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBaseExperiment.Result.Buckets.Length"); i++) {
				result_buckets.Add(_ctx.StringValue("DescribeBaseExperiment.Result.Buckets["+ i +"]"));
			}
			result.Buckets = result_buckets;

			List<DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm> result_algorithms = new List<DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm>();
			for (int i = 0; i < _ctx.Length("DescribeBaseExperiment.Result.Algorithms.Length"); i++) {
				DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm algorithm = new DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm();
				algorithm.Key = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].key");
				algorithm.Name = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].name");
				algorithm.Category = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].category");
				algorithm.Type = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].type");
				algorithm.DefaultValue = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].defaultValue");
				algorithm.ExperimentValue = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].experimentValue");
				algorithm.HasConfig = _ctx.BooleanValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].hasConfig");

				List<DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm.DescribeBaseExperiment_ConfigItem> algorithm_config = new List<DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm.DescribeBaseExperiment_ConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeBaseExperiment.Result.Algorithms["+ i +"].Config.Length"); j++) {
					DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm.DescribeBaseExperiment_ConfigItem configItem = new DescribeBaseExperimentResponse.DescribeBaseExperiment_Result.DescribeBaseExperiment_Algorithm.DescribeBaseExperiment_ConfigItem();
					configItem.Key = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].Config["+ j +"].key");
					configItem.Name = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].Config["+ j +"].name");
					configItem.DefaultValue = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].Config["+ j +"].defaultValue");
					configItem.ExperimentValue = _ctx.StringValue("DescribeBaseExperiment.Result.Algorithms["+ i +"].Config["+ j +"].experimentValue");

					algorithm_config.Add(configItem);
				}
				algorithm.Config = algorithm_config;

				result_algorithms.Add(algorithm);
			}
			result.Algorithms = result_algorithms;
			describeBaseExperimentResponse.Result = result;
        
			return describeBaseExperimentResponse;
        }
    }
}
