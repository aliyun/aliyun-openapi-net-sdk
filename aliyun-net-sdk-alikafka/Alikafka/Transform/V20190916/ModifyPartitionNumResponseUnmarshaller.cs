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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class ModifyPartitionNumResponseUnmarshaller
    {
        public static ModifyPartitionNumResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyPartitionNumResponse modifyPartitionNumResponse = new ModifyPartitionNumResponse();

			modifyPartitionNumResponse.HttpResponse = _ctx.HttpResponse;
			modifyPartitionNumResponse.Code = _ctx.IntegerValue("ModifyPartitionNum.Code");
			modifyPartitionNumResponse.Message = _ctx.StringValue("ModifyPartitionNum.Message");
			modifyPartitionNumResponse.RequestId = _ctx.StringValue("ModifyPartitionNum.RequestId");
			modifyPartitionNumResponse.Success = _ctx.BooleanValue("ModifyPartitionNum.Success");
        
			return modifyPartitionNumResponse;
        }
    }
}
