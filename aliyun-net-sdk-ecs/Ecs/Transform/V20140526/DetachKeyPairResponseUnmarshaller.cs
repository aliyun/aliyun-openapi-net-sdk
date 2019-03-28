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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DetachKeyPairResponseUnmarshaller
    {
        public static DetachKeyPairResponse Unmarshall(UnmarshallerContext context)
        {
			DetachKeyPairResponse detachKeyPairResponse = new DetachKeyPairResponse();

			detachKeyPairResponse.HttpResponse = context.HttpResponse;
			detachKeyPairResponse.RequestId = context.StringValue("DetachKeyPair.RequestId");
			detachKeyPairResponse.TotalCount = context.StringValue("DetachKeyPair.TotalCount");
			detachKeyPairResponse.FailCount = context.StringValue("DetachKeyPair.FailCount");
			detachKeyPairResponse.KeyPairName = context.StringValue("DetachKeyPair.KeyPairName");

			List<DetachKeyPairResponse.DetachKeyPair_Result> detachKeyPairResponse_results = new List<DetachKeyPairResponse.DetachKeyPair_Result>();
			for (int i = 0; i < context.Length("DetachKeyPair.Results.Length"); i++) {
				DetachKeyPairResponse.DetachKeyPair_Result result = new DetachKeyPairResponse.DetachKeyPair_Result();
				result.InstanceId = context.StringValue("DetachKeyPair.Results["+ i +"].InstanceId");
				result.Success = context.StringValue("DetachKeyPair.Results["+ i +"].Success");
				result.Code = context.StringValue("DetachKeyPair.Results["+ i +"].Code");
				result.Message = context.StringValue("DetachKeyPair.Results["+ i +"].Message");

				detachKeyPairResponse_results.Add(result);
			}
			detachKeyPairResponse.Results = detachKeyPairResponse_results;
        
			return detachKeyPairResponse;
        }
    }
}
