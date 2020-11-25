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
    public class AttachKeyPairResponseUnmarshaller
    {
        public static AttachKeyPairResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AttachKeyPairResponse attachKeyPairResponse = new AttachKeyPairResponse();

			attachKeyPairResponse.HttpResponse = _ctx.HttpResponse;
			attachKeyPairResponse.RequestId = _ctx.StringValue("AttachKeyPair.RequestId");
			attachKeyPairResponse.TotalCount = _ctx.StringValue("AttachKeyPair.TotalCount");
			attachKeyPairResponse.FailCount = _ctx.StringValue("AttachKeyPair.FailCount");
			attachKeyPairResponse.KeyPairName = _ctx.StringValue("AttachKeyPair.KeyPairName");

			List<AttachKeyPairResponse.AttachKeyPair_Result> attachKeyPairResponse_results = new List<AttachKeyPairResponse.AttachKeyPair_Result>();
			for (int i = 0; i < _ctx.Length("AttachKeyPair.Results.Length"); i++) {
				AttachKeyPairResponse.AttachKeyPair_Result result = new AttachKeyPairResponse.AttachKeyPair_Result();
				result.InstanceId = _ctx.StringValue("AttachKeyPair.Results["+ i +"].InstanceId");
				result.Success = _ctx.StringValue("AttachKeyPair.Results["+ i +"].Success");
				result.Code = _ctx.StringValue("AttachKeyPair.Results["+ i +"].Code");
				result.Message = _ctx.StringValue("AttachKeyPair.Results["+ i +"].Message");

				attachKeyPairResponse_results.Add(result);
			}
			attachKeyPairResponse.Results = attachKeyPairResponse_results;
        
			return attachKeyPairResponse;
        }
    }
}
