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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class MoveAppResourceResponseUnmarshaller
    {
        public static MoveAppResourceResponse Unmarshall(UnmarshallerContext context)
        {
			MoveAppResourceResponse moveAppResourceResponse = new MoveAppResourceResponse();

			moveAppResourceResponse.HttpResponse = context.HttpResponse;
			moveAppResourceResponse.RequestId = context.StringValue("MoveAppResource.RequestId");

			List<string> moveAppResourceResponse_nonExistResourceIds = new List<string>();
			for (int i = 0; i < context.Length("MoveAppResource.NonExistResourceIds.Length"); i++) {
				moveAppResourceResponse_nonExistResourceIds.Add(context.StringValue("MoveAppResource.NonExistResourceIds["+ i +"]"));
			}
			moveAppResourceResponse.NonExistResourceIds = moveAppResourceResponse_nonExistResourceIds;

			List<string> moveAppResourceResponse_failedResourceIds = new List<string>();
			for (int i = 0; i < context.Length("MoveAppResource.FailedResourceIds.Length"); i++) {
				moveAppResourceResponse_failedResourceIds.Add(context.StringValue("MoveAppResource.FailedResourceIds["+ i +"]"));
			}
			moveAppResourceResponse.FailedResourceIds = moveAppResourceResponse_failedResourceIds;
        
			return moveAppResourceResponse;
        }
    }
}
