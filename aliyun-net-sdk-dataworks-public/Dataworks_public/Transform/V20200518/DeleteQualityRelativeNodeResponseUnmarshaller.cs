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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class DeleteQualityRelativeNodeResponseUnmarshaller
    {
        public static DeleteQualityRelativeNodeResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteQualityRelativeNodeResponse deleteQualityRelativeNodeResponse = new DeleteQualityRelativeNodeResponse();

			deleteQualityRelativeNodeResponse.HttpResponse = context.HttpResponse;
			deleteQualityRelativeNodeResponse.Success = context.BooleanValue("DeleteQualityRelativeNode.Success");
			deleteQualityRelativeNodeResponse.ErrorCode = context.StringValue("DeleteQualityRelativeNode.ErrorCode");
			deleteQualityRelativeNodeResponse.ErrorMessage = context.StringValue("DeleteQualityRelativeNode.ErrorMessage");
			deleteQualityRelativeNodeResponse.HttpStatusCode = context.IntegerValue("DeleteQualityRelativeNode.HttpStatusCode");
			deleteQualityRelativeNodeResponse.Data = context.BooleanValue("DeleteQualityRelativeNode.Data");
			deleteQualityRelativeNodeResponse.RequestId = context.StringValue("DeleteQualityRelativeNode.RequestId");
        
			return deleteQualityRelativeNodeResponse;
        }
    }
}
