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
        public static AttachKeyPairResponse Unmarshall(UnmarshallerContext context)
        {
			AttachKeyPairResponse attachKeyPairResponse = new AttachKeyPairResponse();

			attachKeyPairResponse.HttpResponse = context.HttpResponse;
			attachKeyPairResponse.RequestId = context.StringValue("AttachKeyPair.RequestId");
			attachKeyPairResponse.TotalCount = context.StringValue("AttachKeyPair.TotalCount");
			attachKeyPairResponse.FailCount = context.StringValue("AttachKeyPair.FailCount");
			attachKeyPairResponse.KeyPairName = context.StringValue("AttachKeyPair.KeyPairName");

			List<AttachKeyPairResponse.AttachKeyPair_Result> attachKeyPairResponse_results = new List<AttachKeyPairResponse.AttachKeyPair_Result>();
			for (int i = 0; i < context.Length("AttachKeyPair.Results.Length"); i++) {
				AttachKeyPairResponse.AttachKeyPair_Result result = new AttachKeyPairResponse.AttachKeyPair_Result();
				result.InstanceId = context.StringValue("AttachKeyPair.Results["+ i +"].InstanceId");
				result.Success = context.StringValue("AttachKeyPair.Results["+ i +"].Success");
				result.Code = context.StringValue("AttachKeyPair.Results["+ i +"].Code");
				result.Message = context.StringValue("AttachKeyPair.Results["+ i +"].Message");

				attachKeyPairResponse_results.Add(result);
			}
			attachKeyPairResponse.Results = attachKeyPairResponse_results;
        
			return attachKeyPairResponse;
        }
    }
}
