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
    public class Personalizedtxt2imgAddModelTrainJobResponseUnmarshaller
    {
        public static Personalizedtxt2imgAddModelTrainJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Personalizedtxt2imgAddModelTrainJobResponse personalizedtxt2imgAddModelTrainJobResponse = new Personalizedtxt2imgAddModelTrainJobResponse();

			personalizedtxt2imgAddModelTrainJobResponse.HttpResponse = _ctx.HttpResponse;
			personalizedtxt2imgAddModelTrainJobResponse.RequestId = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.requestId");
			personalizedtxt2imgAddModelTrainJobResponse.Success = _ctx.BooleanValue("Personalizedtxt2imgAddModelTrainJob.success");
			personalizedtxt2imgAddModelTrainJobResponse.ErrCode = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.errCode");
			personalizedtxt2imgAddModelTrainJobResponse.ErrMessage = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.errMessage");

			Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data data = new Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data();
			data.ModelTrainStatus = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.modelTrainStatus");
			personalizedtxt2imgAddModelTrainJobResponse.Data = data;
        
			return personalizedtxt2imgAddModelTrainJobResponse;
        }
    }
}
