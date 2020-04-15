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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class RefuseAdditionalMaterialResponseUnmarshaller
    {
        public static RefuseAdditionalMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			RefuseAdditionalMaterialResponse refuseAdditionalMaterialResponse = new RefuseAdditionalMaterialResponse();

			refuseAdditionalMaterialResponse.HttpResponse = context.HttpResponse;
			refuseAdditionalMaterialResponse.RequestId = context.StringValue("RefuseAdditionalMaterial.RequestId");
			refuseAdditionalMaterialResponse.Success = context.BooleanValue("RefuseAdditionalMaterial.Success");
			refuseAdditionalMaterialResponse.ErrorMsg = context.StringValue("RefuseAdditionalMaterial.ErrorMsg");
			refuseAdditionalMaterialResponse.ErrorCode = context.StringValue("RefuseAdditionalMaterial.ErrorCode");
        
			return refuseAdditionalMaterialResponse;
        }
    }
}
