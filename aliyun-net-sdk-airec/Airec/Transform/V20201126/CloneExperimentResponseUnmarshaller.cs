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
    public class CloneExperimentResponseUnmarshaller
    {
        public static CloneExperimentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CloneExperimentResponse cloneExperimentResponse = new CloneExperimentResponse();

			cloneExperimentResponse.HttpResponse = _ctx.HttpResponse;
			cloneExperimentResponse.RequestId = _ctx.StringValue("CloneExperiment.requestId");

			CloneExperimentResponse.CloneExperiment_Result result = new CloneExperimentResponse.CloneExperiment_Result();
			result.ExperimentId = _ctx.StringValue("CloneExperiment.Result.experimentId");
			result.Name = _ctx.StringValue("CloneExperiment.Result.name");
			result.Description = _ctx.StringValue("CloneExperiment.Result.description");
			result.Status = _ctx.StringValue("CloneExperiment.Result.status");
			result._Base = _ctx.BooleanValue("CloneExperiment.Result.base");
			result.OnlineTime = _ctx.StringValue("CloneExperiment.Result.onlineTime");
			result.OfflineTime = _ctx.StringValue("CloneExperiment.Result.offlineTime");

			List<string> result_buckets = new List<string>();
			for (int i = 0; i < _ctx.Length("CloneExperiment.Result.Buckets.Length"); i++) {
				result_buckets.Add(_ctx.StringValue("CloneExperiment.Result.Buckets["+ i +"]"));
			}
			result.Buckets = result_buckets;

			List<CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm> result_algorithms = new List<CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm>();
			for (int i = 0; i < _ctx.Length("CloneExperiment.Result.Algorithms.Length"); i++) {
				CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm algorithm = new CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm();
				algorithm.Key = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].key");
				algorithm.Name = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].name");
				algorithm.Category = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].category");
				algorithm.Type = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].type");
				algorithm.DefaultValue = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].defaultValue");
				algorithm.ExperimentValue = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].experimentValue");
				algorithm.HasConfig = _ctx.BooleanValue("CloneExperiment.Result.Algorithms["+ i +"].hasConfig");

				List<CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm.CloneExperiment_ConfigItem> algorithm_config = new List<CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm.CloneExperiment_ConfigItem>();
				for (int j = 0; j < _ctx.Length("CloneExperiment.Result.Algorithms["+ i +"].Config.Length"); j++) {
					CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm.CloneExperiment_ConfigItem configItem = new CloneExperimentResponse.CloneExperiment_Result.CloneExperiment_Algorithm.CloneExperiment_ConfigItem();
					configItem.Key = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].Config["+ j +"].key");
					configItem.Name = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].Config["+ j +"].name");
					configItem.DefaultValue = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].Config["+ j +"].defaultValue");
					configItem.ExperimentValue = _ctx.StringValue("CloneExperiment.Result.Algorithms["+ i +"].Config["+ j +"].experimentValue");

					algorithm_config.Add(configItem);
				}
				algorithm.Config = algorithm_config;

				result_algorithms.Add(algorithm);
			}
			result.Algorithms = result_algorithms;
			cloneExperimentResponse.Result = result;
        
			return cloneExperimentResponse;
        }
    }
}
