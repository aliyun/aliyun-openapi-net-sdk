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
using Aliyun.Acs.AiContent.Model.V20240611;

namespace Aliyun.Acs.AiContent.Transform.V20240611
{
    public class Personalizedtxt2imgAddInferenceJobResponseUnmarshaller
    {
        public static Personalizedtxt2imgAddInferenceJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Personalizedtxt2imgAddInferenceJobResponse personalizedtxt2imgAddInferenceJobResponse = new Personalizedtxt2imgAddInferenceJobResponse();

			personalizedtxt2imgAddInferenceJobResponse.HttpResponse = _ctx.HttpResponse;
			personalizedtxt2imgAddInferenceJobResponse.RequestId = _ctx.StringValue("Personalizedtxt2imgAddInferenceJob.requestId");
			personalizedtxt2imgAddInferenceJobResponse.Success = _ctx.BooleanValue("Personalizedtxt2imgAddInferenceJob.success");
			personalizedtxt2imgAddInferenceJobResponse.ErrCode = _ctx.StringValue("Personalizedtxt2imgAddInferenceJob.errCode");
			personalizedtxt2imgAddInferenceJobResponse.ErrMessage = _ctx.StringValue("Personalizedtxt2imgAddInferenceJob.errMessage");

			Personalizedtxt2imgAddInferenceJobResponse.Personalizedtxt2imgAddInferenceJob_Data data = new Personalizedtxt2imgAddInferenceJobResponse.Personalizedtxt2imgAddInferenceJob_Data();
			data.ModelTrainStatus = _ctx.StringValue("Personalizedtxt2imgAddInferenceJob.Data.modelTrainStatus");
			personalizedtxt2imgAddInferenceJobResponse.Data = data;
        
			return personalizedtxt2imgAddInferenceJobResponse;
        }
    }
}
