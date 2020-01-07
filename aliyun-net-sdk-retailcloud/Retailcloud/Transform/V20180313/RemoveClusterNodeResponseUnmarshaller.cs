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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class RemoveClusterNodeResponseUnmarshaller
    {
        public static RemoveClusterNodeResponse Unmarshall(UnmarshallerContext context)
        {
			RemoveClusterNodeResponse removeClusterNodeResponse = new RemoveClusterNodeResponse();

			removeClusterNodeResponse.HttpResponse = context.HttpResponse;
			removeClusterNodeResponse.Code = context.IntegerValue("RemoveClusterNode.Code");
			removeClusterNodeResponse.ErrMsg = context.StringValue("RemoveClusterNode.ErrMsg");
			removeClusterNodeResponse.RequestId = context.StringValue("RemoveClusterNode.RequestId");
			removeClusterNodeResponse.Success = context.BooleanValue("RemoveClusterNode.Success");

			RemoveClusterNodeResponse.RemoveClusterNode_Result result = new RemoveClusterNodeResponse.RemoveClusterNode_Result();
			result.Nonsense = context.IntegerValue("RemoveClusterNode.Result.Nonsense");
			removeClusterNodeResponse.Result = result;
        
			return removeClusterNodeResponse;
        }
    }
}
