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
        public static DetachKeyPairResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetachKeyPairResponse detachKeyPairResponse = new DetachKeyPairResponse();

			detachKeyPairResponse.HttpResponse = _ctx.HttpResponse;
			detachKeyPairResponse.RequestId = _ctx.StringValue("DetachKeyPair.RequestId");
			detachKeyPairResponse.TotalCount = _ctx.StringValue("DetachKeyPair.TotalCount");
			detachKeyPairResponse.FailCount = _ctx.StringValue("DetachKeyPair.FailCount");
			detachKeyPairResponse.KeyPairName = _ctx.StringValue("DetachKeyPair.KeyPairName");

			List<DetachKeyPairResponse.DetachKeyPair_Result> detachKeyPairResponse_results = new List<DetachKeyPairResponse.DetachKeyPair_Result>();
			for (int i = 0; i < _ctx.Length("DetachKeyPair.Results.Length"); i++) {
				DetachKeyPairResponse.DetachKeyPair_Result result = new DetachKeyPairResponse.DetachKeyPair_Result();
				result.InstanceId = _ctx.StringValue("DetachKeyPair.Results["+ i +"].InstanceId");
				result.Success = _ctx.StringValue("DetachKeyPair.Results["+ i +"].Success");
				result.Code = _ctx.StringValue("DetachKeyPair.Results["+ i +"].Code");
				result.Message = _ctx.StringValue("DetachKeyPair.Results["+ i +"].Message");

				detachKeyPairResponse_results.Add(result);
			}
			detachKeyPairResponse.Results = detachKeyPairResponse_results;
        
			return detachKeyPairResponse;
        }
    }
}
