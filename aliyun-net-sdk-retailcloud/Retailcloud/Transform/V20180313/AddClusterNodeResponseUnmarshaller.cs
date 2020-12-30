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
    public class AddClusterNodeResponseUnmarshaller
    {
        public static AddClusterNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddClusterNodeResponse addClusterNodeResponse = new AddClusterNodeResponse();

			addClusterNodeResponse.HttpResponse = _ctx.HttpResponse;
			addClusterNodeResponse.Code = _ctx.IntegerValue("AddClusterNode.Code");
			addClusterNodeResponse.ErrMsg = _ctx.StringValue("AddClusterNode.ErrMsg");
			addClusterNodeResponse.RequestId = _ctx.StringValue("AddClusterNode.RequestId");
			addClusterNodeResponse.Success = _ctx.BooleanValue("AddClusterNode.Success");

			AddClusterNodeResponse.AddClusterNode_Result result = new AddClusterNodeResponse.AddClusterNode_Result();
			result.Nonsense = _ctx.IntegerValue("AddClusterNode.Result.Nonsense");
			addClusterNodeResponse.Result = result;
        
			return addClusterNodeResponse;
        }
    }
}
