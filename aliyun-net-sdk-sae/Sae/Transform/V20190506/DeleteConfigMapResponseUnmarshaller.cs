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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DeleteConfigMapResponseUnmarshaller
    {
        public static DeleteConfigMapResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteConfigMapResponse deleteConfigMapResponse = new DeleteConfigMapResponse();

			deleteConfigMapResponse.HttpResponse = context.HttpResponse;
			deleteConfigMapResponse.RequestId = context.StringValue("DeleteConfigMap.RequestId");
			deleteConfigMapResponse.Message = context.StringValue("DeleteConfigMap.Message");
			deleteConfigMapResponse.Code = context.StringValue("DeleteConfigMap.Code");
			deleteConfigMapResponse.ErrorCode = context.StringValue("DeleteConfigMap.ErrorCode");
			deleteConfigMapResponse.TraceId = context.StringValue("DeleteConfigMap.TraceId");
			deleteConfigMapResponse.Success = context.BooleanValue("DeleteConfigMap.Success");

			DeleteConfigMapResponse.DeleteConfigMap_Data data = new DeleteConfigMapResponse.DeleteConfigMap_Data();
			data.ConfigMapId = context.LongValue("DeleteConfigMap.Data.ConfigMapId");
			deleteConfigMapResponse.Data = data;
        
			return deleteConfigMapResponse;
        }
    }
}
