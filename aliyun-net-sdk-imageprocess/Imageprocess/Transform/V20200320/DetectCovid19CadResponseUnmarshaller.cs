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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class DetectCovid19CadResponseUnmarshaller
    {
        public static DetectCovid19CadResponse Unmarshall(UnmarshallerContext context)
        {
			DetectCovid19CadResponse detectCovid19CadResponse = new DetectCovid19CadResponse();

			detectCovid19CadResponse.HttpResponse = context.HttpResponse;
			detectCovid19CadResponse.RequestId = context.StringValue("DetectCovid19Cad.RequestId");

			DetectCovid19CadResponse.DetectCovid19Cad_Data data = new DetectCovid19CadResponse.DetectCovid19Cad_Data();
			data.NewProbability = context.StringValue("DetectCovid19Cad.Data.NewProbability");
			data.NormalProbability = context.StringValue("DetectCovid19Cad.Data.NormalProbability");
			data.OtherProbability = context.StringValue("DetectCovid19Cad.Data.OtherProbability");
			data.LesionRatio = context.StringValue("DetectCovid19Cad.Data.LesionRatio");
			data.Mask = context.StringValue("DetectCovid19Cad.Data.Mask");
			detectCovid19CadResponse.Data = data;
        
			return detectCovid19CadResponse;
        }
    }
}
