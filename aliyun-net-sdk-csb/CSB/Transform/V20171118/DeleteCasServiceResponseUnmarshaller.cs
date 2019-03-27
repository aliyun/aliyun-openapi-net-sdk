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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class DeleteCasServiceResponseUnmarshaller
    {
        public static DeleteCasServiceResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteCasServiceResponse deleteCasServiceResponse = new DeleteCasServiceResponse();

			deleteCasServiceResponse.HttpResponse = context.HttpResponse;
			deleteCasServiceResponse.Code = context.IntegerValue("DeleteCasService.Code");
			deleteCasServiceResponse.Message = context.StringValue("DeleteCasService.Message");
			deleteCasServiceResponse.RequestId = context.StringValue("DeleteCasService.RequestId");
        
			return deleteCasServiceResponse;
        }
    }
}
