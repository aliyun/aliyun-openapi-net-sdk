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
    public class UpdateExperimentConfigResponseUnmarshaller
    {
        public static UpdateExperimentConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateExperimentConfigResponse updateExperimentConfigResponse = new UpdateExperimentConfigResponse();

			updateExperimentConfigResponse.HttpResponse = _ctx.HttpResponse;
			updateExperimentConfigResponse.RequestId = _ctx.StringValue("UpdateExperimentConfig.requestId");

			UpdateExperimentConfigResponse.UpdateExperimentConfig_Result result = new UpdateExperimentConfigResponse.UpdateExperimentConfig_Result();
			result.ExperimentId = _ctx.StringValue("UpdateExperimentConfig.Result.experimentId");
			result.Name = _ctx.StringValue("UpdateExperimentConfig.Result.name");
			result.Description = _ctx.StringValue("UpdateExperimentConfig.Result.description");
			result.Status = _ctx.StringValue("UpdateExperimentConfig.Result.status");
			result._Base = _ctx.BooleanValue("UpdateExperimentConfig.Result.base");
			result.OnlineTime = _ctx.StringValue("UpdateExperimentConfig.Result.onlineTime");
			result.OfflineTime = _ctx.StringValue("UpdateExperimentConfig.Result.offlineTime");

			List<string> result_buckets = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateExperimentConfig.Result.Buckets.Length"); i++) {
				result_buckets.Add(_ctx.StringValue("UpdateExperimentConfig.Result.Buckets["+ i +"]"));
			}
			result.Buckets = result_buckets;

			List<UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm> result_algorithms = new List<UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm>();
			for (int i = 0; i < _ctx.Length("UpdateExperimentConfig.Result.Algorithms.Length"); i++) {
				UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm algorithm = new UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm();
				algorithm.Key = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].key");
				algorithm.Name = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].name");
				algorithm.Category = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].category");
				algorithm.Type = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].type");
				algorithm.DefaultValue = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].defaultValue");
				algorithm.ExperimentValue = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].experimentValue");
				algorithm.HasConfig = _ctx.BooleanValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].hasConfig");

				List<UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm.UpdateExperimentConfig_ConfigItem> algorithm_config = new List<UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm.UpdateExperimentConfig_ConfigItem>();
				for (int j = 0; j < _ctx.Length("UpdateExperimentConfig.Result.Algorithms["+ i +"].Config.Length"); j++) {
					UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm.UpdateExperimentConfig_ConfigItem configItem = new UpdateExperimentConfigResponse.UpdateExperimentConfig_Result.UpdateExperimentConfig_Algorithm.UpdateExperimentConfig_ConfigItem();
					configItem.Key = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].Config["+ j +"].key");
					configItem.Name = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].Config["+ j +"].name");
					configItem.DefaultValue = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].Config["+ j +"].defaultValue");
					configItem.ExperimentValue = _ctx.StringValue("UpdateExperimentConfig.Result.Algorithms["+ i +"].Config["+ j +"].experimentValue");

					algorithm_config.Add(configItem);
				}
				algorithm.Config = algorithm_config;

				result_algorithms.Add(algorithm);
			}
			result.Algorithms = result_algorithms;
			updateExperimentConfigResponse.Result = result;
        
			return updateExperimentConfigResponse;
        }
    }
}
