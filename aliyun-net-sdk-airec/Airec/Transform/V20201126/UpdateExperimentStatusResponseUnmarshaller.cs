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
    public class UpdateExperimentStatusResponseUnmarshaller
    {
        public static UpdateExperimentStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateExperimentStatusResponse updateExperimentStatusResponse = new UpdateExperimentStatusResponse();

			updateExperimentStatusResponse.HttpResponse = _ctx.HttpResponse;
			updateExperimentStatusResponse.RequestId = _ctx.StringValue("UpdateExperimentStatus.requestId");

			UpdateExperimentStatusResponse.UpdateExperimentStatus_Result result = new UpdateExperimentStatusResponse.UpdateExperimentStatus_Result();
			result.ExperimentId = _ctx.StringValue("UpdateExperimentStatus.Result.experimentId");
			result.Name = _ctx.StringValue("UpdateExperimentStatus.Result.name");
			result.Description = _ctx.StringValue("UpdateExperimentStatus.Result.description");
			result.Status = _ctx.StringValue("UpdateExperimentStatus.Result.status");
			result._Base = _ctx.BooleanValue("UpdateExperimentStatus.Result.base");
			result.OnlineTime = _ctx.StringValue("UpdateExperimentStatus.Result.onlineTime");
			result.OfflineTime = _ctx.StringValue("UpdateExperimentStatus.Result.offlineTime");

			List<string> result_buckets = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateExperimentStatus.Result.Buckets.Length"); i++) {
				result_buckets.Add(_ctx.StringValue("UpdateExperimentStatus.Result.Buckets["+ i +"]"));
			}
			result.Buckets = result_buckets;

			List<UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm> result_algorithms = new List<UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm>();
			for (int i = 0; i < _ctx.Length("UpdateExperimentStatus.Result.Algorithms.Length"); i++) {
				UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm algorithm = new UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm();
				algorithm.Key = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].key");
				algorithm.Name = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].name");
				algorithm.Category = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].category");
				algorithm.Type = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].type");
				algorithm.DefaultValue = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].defaultValue");
				algorithm.ExperimentValue = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].experimentValue");
				algorithm.HasConfig = _ctx.BooleanValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].hasConfig");

				List<UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm.UpdateExperimentStatus_ConfigItem> algorithm_config = new List<UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm.UpdateExperimentStatus_ConfigItem>();
				for (int j = 0; j < _ctx.Length("UpdateExperimentStatus.Result.Algorithms["+ i +"].Config.Length"); j++) {
					UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm.UpdateExperimentStatus_ConfigItem configItem = new UpdateExperimentStatusResponse.UpdateExperimentStatus_Result.UpdateExperimentStatus_Algorithm.UpdateExperimentStatus_ConfigItem();
					configItem.Key = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].Config["+ j +"].key");
					configItem.Name = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].Config["+ j +"].name");
					configItem.DefaultValue = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].Config["+ j +"].defaultValue");
					configItem.ExperimentValue = _ctx.StringValue("UpdateExperimentStatus.Result.Algorithms["+ i +"].Config["+ j +"].experimentValue");

					algorithm_config.Add(configItem);
				}
				algorithm.Config = algorithm_config;

				result_algorithms.Add(algorithm);
			}
			result.Algorithms = result_algorithms;
			updateExperimentStatusResponse.Result = result;
        
			return updateExperimentStatusResponse;
        }
    }
}
