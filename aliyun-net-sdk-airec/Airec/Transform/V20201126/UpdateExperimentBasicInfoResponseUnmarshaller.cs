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
    public class UpdateExperimentBasicInfoResponseUnmarshaller
    {
        public static UpdateExperimentBasicInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateExperimentBasicInfoResponse updateExperimentBasicInfoResponse = new UpdateExperimentBasicInfoResponse();

			updateExperimentBasicInfoResponse.HttpResponse = _ctx.HttpResponse;
			updateExperimentBasicInfoResponse.RequestId = _ctx.StringValue("UpdateExperimentBasicInfo.requestId");

			UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result result = new UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result();
			result.ExperimentId = _ctx.StringValue("UpdateExperimentBasicInfo.Result.experimentId");
			result.Name = _ctx.StringValue("UpdateExperimentBasicInfo.Result.name");
			result.Description = _ctx.StringValue("UpdateExperimentBasicInfo.Result.description");
			result.Status = _ctx.StringValue("UpdateExperimentBasicInfo.Result.status");
			result._Base = _ctx.BooleanValue("UpdateExperimentBasicInfo.Result.base");
			result.OnlineTime = _ctx.StringValue("UpdateExperimentBasicInfo.Result.onlineTime");
			result.OfflineTime = _ctx.StringValue("UpdateExperimentBasicInfo.Result.offlineTime");

			List<string> result_buckets = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateExperimentBasicInfo.Result.Buckets.Length"); i++) {
				result_buckets.Add(_ctx.StringValue("UpdateExperimentBasicInfo.Result.Buckets["+ i +"]"));
			}
			result.Buckets = result_buckets;

			List<UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm> result_algorithms = new List<UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm>();
			for (int i = 0; i < _ctx.Length("UpdateExperimentBasicInfo.Result.Algorithms.Length"); i++) {
				UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm algorithm = new UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm();
				algorithm.Key = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].key");
				algorithm.Name = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].name");
				algorithm.Category = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].category");
				algorithm.Type = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].type");
				algorithm.DefaultValue = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].defaultValue");
				algorithm.ExperimentValue = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].experimentValue");
				algorithm.HasConfig = _ctx.BooleanValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].hasConfig");

				List<UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm.UpdateExperimentBasicInfo_ConfigItem> algorithm_config = new List<UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm.UpdateExperimentBasicInfo_ConfigItem>();
				for (int j = 0; j < _ctx.Length("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].Config.Length"); j++) {
					UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm.UpdateExperimentBasicInfo_ConfigItem configItem = new UpdateExperimentBasicInfoResponse.UpdateExperimentBasicInfo_Result.UpdateExperimentBasicInfo_Algorithm.UpdateExperimentBasicInfo_ConfigItem();
					configItem.Key = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].Config["+ j +"].key");
					configItem.Name = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].Config["+ j +"].name");
					configItem.DefaultValue = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].Config["+ j +"].defaultValue");
					configItem.ExperimentValue = _ctx.StringValue("UpdateExperimentBasicInfo.Result.Algorithms["+ i +"].Config["+ j +"].experimentValue");

					algorithm_config.Add(configItem);
				}
				algorithm.Config = algorithm_config;

				result_algorithms.Add(algorithm);
			}
			result.Algorithms = result_algorithms;
			updateExperimentBasicInfoResponse.Result = result;
        
			return updateExperimentBasicInfoResponse;
        }
    }
}
