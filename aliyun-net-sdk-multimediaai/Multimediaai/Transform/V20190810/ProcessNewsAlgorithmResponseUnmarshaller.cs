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
using Aliyun.Acs.multimediaai.Model.V20190810;

namespace Aliyun.Acs.multimediaai.Transform.V20190810
{
    public class ProcessNewsAlgorithmResponseUnmarshaller
    {
        public static ProcessNewsAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ProcessNewsAlgorithmResponse processNewsAlgorithmResponse = new ProcessNewsAlgorithmResponse();

			processNewsAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			processNewsAlgorithmResponse.RequestId = _ctx.StringValue("ProcessNewsAlgorithm.RequestId");
			processNewsAlgorithmResponse.Code = _ctx.IntegerValue("ProcessNewsAlgorithm.Code");
			processNewsAlgorithmResponse.Message = _ctx.StringValue("ProcessNewsAlgorithm.Message");
			processNewsAlgorithmResponse.Data = _ctx.StringValue("ProcessNewsAlgorithm.Data");
        
			return processNewsAlgorithmResponse;
        }
    }
}
